using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WMIWork2
{
    public partial class frmWMITools : Form
    {
        public frmWMITools()
        {
            InitializeComponent();
        }

        private void frmWMITools_Load(object sender, EventArgs e)
        {
            cmbNamespaceValue.Items.Clear();
                        
            List<string> _namespace = WMItask.GetNamespacesToList("root");

            foreach (var item in _namespace)
            {
                cmbNamespaceValue.Items.Add(item);
            }
            lblClassStatus.Text = _namespace.Count.ToString() + " Namespace Bulundu.";
        }

        private void cmbNamespaceValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClassList.Items.Clear();
            cmbClassList.Text = "";
            List<string> _classList = WMItask.GetClassesToList(cmbNamespaceValue.Text);
            foreach (var item in _classList)
            {
                cmbClassList.Items.Add(item);
            }

            lblClassStatus.Text = _classList.Count.ToString() + " Dynamic yada Static Class bulundu.";

        }

        private void cmbClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProperty.Items.Clear();
            List<object> obj = new List<object>();
            obj.Add(cmbNamespaceValue.Text);
            obj.Add(cmbClassList.Text);
            object a;


            //Task<List<string>> task = Task<List<string>>.Factory.StartNew(WMIToolsA.GetWMIPropertiesToList, a);

            List<string> _propertyList = WMItask.GetPropertiesToList(cmbNamespaceValue.Text, cmbClassList.Text);

            foreach (var item in _propertyList)
            {
                lstProperty.Items.Add(item.ToString());
            }
            lblPropertyStatus.Text = _propertyList.Count.ToString() + " özellik bulundu.";
        }

        private void btnPropertyShow_Click(object sender, EventArgs e)
        {
            lbPropertyValue.Items.Clear();

            List<string> selecties = new List<string>();

            foreach (string item in lstProperty.SelectedItems)
            {
                selecties.Add(item);
            }
            List<string> propertyValueList = WMItask.GetPropertiesValuesToList(cmbNamespaceValue.Text, cmbClassList.Text, selecties);

            foreach (var item in propertyValueList)
            {
                lbPropertyValue.Items.Add(item);
            }
            lblPropertyValueStatus.Text = propertyValueList.Count.ToString() + " tane property değeri bulundu.";
        }

        private void btnGetPropertyData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Properties");

           // List<string> propertiesList = WMItask.GetPropertiesToList(cmbNamespaceValue.Text, cmbClassList.Text);
           DataSet propertiesDictionary = WMItask.GetPropertiesToDataSet(cmbNamespaceValue.Text, cmbClassList.Text);


            //foreach (var property in propertiesDictionary)
            //{
            //    dt.Columns.Add(property.Key, typeof(string));
            //}

            //DataSet ds = new DataSet();
            //ds.Tables.Add(dt);

            //DataRow newRow = ds.Tables["Properties"].NewRow();
            //foreach (var property in propertiesDictionary)
            //{
            //    newRow[property.Key] = property.Value;
            //}
            //ds.Tables["Properties"].Rows.Add(newRow);

            dgProperty.DataSource = propertiesDictionary.Tables["Properties"];
            
        }
    }
}
