using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMIWork2
{
    public class WMItask
    {
        public static List<string> GetNamespacesToList(string _root)
        {
            List<string> nameSpace = new List<string>();

            try
            {
                // __namespace WMI class.
                ManagementClass nsClass = new ManagementClass()
                {
                    Scope = new ManagementScope(_root),
                    Path = new ManagementPath("__namespace"),
                    Options = new ObjectGetOptions()
                };

                foreach (ManagementObject ns in nsClass.GetInstances())
                {
                    string namespaceName = _root + "\\" + ns["Name"].ToString();
                    nameSpace.Add(namespaceName);
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show(e.Message);
            }
            // namespaceName return.
            // nameSpace.Sort();
            return nameSpace;
        }

        public static List<string> GetClassesToList(string _namespace)
        {
            List<string> classList = new List<string>();
            try
            {
                // selected namespace
                ManagementObjectSearcher searcher = new ManagementObjectSearcher()
                {
                    Scope = new ManagementScope(_namespace),
                    Query = new WqlObjectQuery("select * from meta_class"),
                    Options = new EnumerationOptions()
                };

                foreach (ManagementClass wmiClass in
                    searcher.Get())
                {
                    foreach (QualifierData qd in wmiClass.Qualifiers)
                    {
                        // dynamic static Class list.
                        if (qd.Name.Equals("dynamic") || qd.Name.Equals("static"))
                        {
                            classList.Add(wmiClass["__CLASS"].ToString());
                        }
                    }
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show(ex.Message);
            }
            // classes list.
            // classList.Sort();
            return classList;
        }

        public static List<string> GetPropertiesToList(string _namespace, string _class)
        {
            List<string> PropertyList = new List<string>();

            try
            {
                // Gets the property qualifiers.
                ObjectGetOptions op = new ObjectGetOptions(null, System.TimeSpan.MaxValue, true);

                ManagementClass mc = new ManagementClass(_namespace, _class, op);
                mc.Options.UseAmendedQualifiers = true;

                foreach (PropertyData dataObject in mc.Properties)
                {
                    PropertyList.Add(dataObject.Name);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return PropertyList;
        }

        public static DataSet GetPropertiesToDataSet(string _namespace, string _class)
        {
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            DataTable dt = new DataTable("Properties");
            DataSet ds = new DataSet();


            try
            {
                ManagementScope objMS = new ManagementScope(ManagementPath.DefaultPath);
                objMS.Connect();

                string query = "select * from " + _class;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher()
                {
                    Scope = new ManagementScope(_namespace),
                    Query = new WqlObjectQuery(query),
                    Options = new EnumerationOptions()
                };

                ManagementObjectCollection moc = searcher.Get();
                bool IsCreateColoum = false;

                foreach (ManagementObject item in moc)
                {
                    PropertyDataCollection pdc = item.Properties;
                    if (!IsCreateColoum)
                    {
                        foreach (var pdcItem in pdc)
                        {
                            dt.Columns.Add(pdcItem.Name, typeof(string));
                        }
                        ds.Tables.Add(dt);
                        IsCreateColoum = true;
                    }
                }


                foreach (ManagementObject item in searcher.Get())
                {
                    DataRow newRow = ds.Tables["Properties"].NewRow();
                    PropertyDataCollection pdc = item.Properties;

                    foreach (PropertyData pdcItem in pdc)
                    {
                        newRow[pdcItem.Name] = item[pdcItem.Name] != null ? item[pdcItem.Name] : "";
                        //Console.WriteLine("{0} : {1}", item.Name, boots[item.Name]);
                        //dictionary.Add(pdcItem.Name, item[pdcItem.Name] != null ? item[pdcItem.Name].ToString() : "");
                    }
                    ds.Tables["Properties"].Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }

        public static List<string> GetPropertiesValuesToList(string _namespace, string _classlist, List<string> _selectpropertylist)
        {
            List<string> propertyValueList = new List<string>();
            string buffer = "";
            int valueCount = 0;
            bool instanceCounter = true;

            try
            {
                // Performs WMI object query on the
                // selected class.
                string query = "select * from " + _classlist;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher()
                {
                    Scope = new ManagementScope(_namespace),
                    Query = new WqlObjectQuery(query),
                    Options = new EnumerationOptions()
                };

                foreach (ManagementObject wmiObject in searcher.Get())
                {
                    foreach (object property in _selectpropertylist)
                    {
                        if (wmiObject.Properties[property.ToString()].IsArray)
                        {
                            // Do nothing.
                        }
                        else
                        {
                            // Set buffer string used to separate instances in the list.
                            if (instanceCounter)
                            {
                                buffer = "";
                            }
                            else
                            {
                                buffer = "----------->>";
                            }

                            // Property is not an array.
                            if (wmiObject.Properties[property.ToString()].Type.ToString().Equals("String"))
                            {
                                // Property is a string.
                                propertyValueList.Add(buffer + property.ToString() + " = '" +
                                    wmiObject.GetPropertyValue(
                                    property.ToString()) + "'");

                                valueCount++;
                            }
                            else
                            {
                                // Property is not a string.
                                propertyValueList.Add(buffer + property.ToString() + " = " +
                                    wmiObject.GetPropertyValue(
                                    property.ToString()));
                                valueCount++;
                            }
                        }
                    }

                    if (instanceCounter)
                    {
                        instanceCounter = false;
                    }
                    else
                    {
                        instanceCounter = true;
                    }
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show(ex.Message);
            }
            propertyValueList.Sort();
            return propertyValueList;
        }
    }
}
