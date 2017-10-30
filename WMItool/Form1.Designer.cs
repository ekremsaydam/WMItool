namespace WMIWork2
{
    partial class frmWMITools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbWMI = new System.Windows.Forms.GroupBox();
            this.lbPropertyValue = new System.Windows.Forms.ListBox();
            this.lblPropertyValueStatus = new System.Windows.Forms.Label();
            this.lblPropertyStatus = new System.Windows.Forms.Label();
            this.lblPropertyValueResult = new System.Windows.Forms.Label();
            this.btnPropertyShow = new System.Windows.Forms.Button();
            this.lstProperty = new System.Windows.Forms.ListBox();
            this.lblPropertyResult = new System.Windows.Forms.Label();
            this.lblPropList = new System.Windows.Forms.Label();
            this.lblNameSpace = new System.Windows.Forms.Label();
            this.cmbClassList = new System.Windows.Forms.ComboBox();
            this.lblClassStatus = new System.Windows.Forms.Label();
            this.lblQueryClasses = new System.Windows.Forms.Label();
            this.cmbNamespaceValue = new System.Windows.Forms.ComboBox();
            this.gbPropertyDataTable = new System.Windows.Forms.GroupBox();
            this.btnGetPropertyData = new System.Windows.Forms.Button();
            this.dgProperty = new System.Windows.Forms.DataGridView();
            this.gbWMI.SuspendLayout();
            this.gbPropertyDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // gbWMI
            // 
            this.gbWMI.Controls.Add(this.lbPropertyValue);
            this.gbWMI.Controls.Add(this.lblPropertyValueStatus);
            this.gbWMI.Controls.Add(this.lblPropertyStatus);
            this.gbWMI.Controls.Add(this.lblPropertyValueResult);
            this.gbWMI.Controls.Add(this.btnPropertyShow);
            this.gbWMI.Controls.Add(this.lstProperty);
            this.gbWMI.Controls.Add(this.lblPropertyResult);
            this.gbWMI.Controls.Add(this.lblPropList);
            this.gbWMI.Controls.Add(this.lblNameSpace);
            this.gbWMI.Controls.Add(this.cmbClassList);
            this.gbWMI.Controls.Add(this.lblClassStatus);
            this.gbWMI.Controls.Add(this.lblQueryClasses);
            this.gbWMI.Controls.Add(this.cmbNamespaceValue);
            this.gbWMI.Location = new System.Drawing.Point(12, 12);
            this.gbWMI.Name = "gbWMI";
            this.gbWMI.Size = new System.Drawing.Size(1093, 253);
            this.gbWMI.TabIndex = 6;
            this.gbWMI.TabStop = false;
            this.gbWMI.Text = "WMI Query";
            // 
            // lbPropertyValue
            // 
            this.lbPropertyValue.FormattingEnabled = true;
            this.lbPropertyValue.Location = new System.Drawing.Point(733, 61);
            this.lbPropertyValue.Name = "lbPropertyValue";
            this.lbPropertyValue.Size = new System.Drawing.Size(347, 173);
            this.lbPropertyValue.TabIndex = 18;
            // 
            // lblPropertyValueStatus
            // 
            this.lblPropertyValueStatus.Location = new System.Drawing.Point(940, 13);
            this.lblPropertyValueStatus.Name = "lblPropertyValueStatus";
            this.lblPropertyValueStatus.Size = new System.Drawing.Size(140, 45);
            this.lblPropertyValueStatus.TabIndex = 17;
            // 
            // lblPropertyStatus
            // 
            this.lblPropertyStatus.Location = new System.Drawing.Point(418, 20);
            this.lblPropertyStatus.Name = "lblPropertyStatus";
            this.lblPropertyStatus.Size = new System.Drawing.Size(309, 23);
            this.lblPropertyStatus.TabIndex = 16;
            // 
            // lblPropertyValueResult
            // 
            this.lblPropertyValueResult.AutoSize = true;
            this.lblPropertyValueResult.Location = new System.Drawing.Point(898, 18);
            this.lblPropertyValueResult.Name = "lblPropertyValueResult";
            this.lblPropertyValueResult.Size = new System.Drawing.Size(46, 13);
            this.lblPropertyValueResult.TabIndex = 15;
            this.lblPropertyValueResult.Text = "Result : ";
            // 
            // btnPropertyShow
            // 
            this.btnPropertyShow.Location = new System.Drawing.Point(733, 34);
            this.btnPropertyShow.Name = "btnPropertyShow";
            this.btnPropertyShow.Size = new System.Drawing.Size(170, 23);
            this.btnPropertyShow.TabIndex = 14;
            this.btnPropertyShow.Text = "Aranan Property İçeriği";
            this.btnPropertyShow.UseVisualStyleBackColor = true;
            this.btnPropertyShow.Click += new System.EventHandler(this.btnPropertyShow_Click);
            // 
            // lstProperty
            // 
            this.lstProperty.HorizontalScrollbar = true;
            this.lstProperty.Location = new System.Drawing.Point(380, 61);
            this.lstProperty.Name = "lstProperty";
            this.lstProperty.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstProperty.Size = new System.Drawing.Size(347, 173);
            this.lstProperty.Sorted = true;
            this.lstProperty.TabIndex = 12;
            // 
            // lblPropertyResult
            // 
            this.lblPropertyResult.AutoSize = true;
            this.lblPropertyResult.Location = new System.Drawing.Point(377, 20);
            this.lblPropertyResult.Name = "lblPropertyResult";
            this.lblPropertyResult.Size = new System.Drawing.Size(46, 13);
            this.lblPropertyResult.TabIndex = 11;
            this.lblPropertyResult.Text = "Result : ";
            // 
            // lblPropList
            // 
            this.lblPropList.AutoSize = true;
            this.lblPropList.Location = new System.Drawing.Point(377, 44);
            this.lblPropList.Name = "lblPropList";
            this.lblPropList.Size = new System.Drawing.Size(113, 13);
            this.lblPropList.TabIndex = 10;
            this.lblPropList.Text = "Select the properties : ";
            // 
            // lblNameSpace
            // 
            this.lblNameSpace.AutoSize = true;
            this.lblNameSpace.Location = new System.Drawing.Point(6, 25);
            this.lblNameSpace.Name = "lblNameSpace";
            this.lblNameSpace.Size = new System.Drawing.Size(73, 13);
            this.lblNameSpace.TabIndex = 6;
            this.lblNameSpace.Text = "Namespace : ";
            // 
            // cmbClassList
            // 
            this.cmbClassList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassList.FormattingEnabled = true;
            this.cmbClassList.Location = new System.Drawing.Point(106, 66);
            this.cmbClassList.Name = "cmbClassList";
            this.cmbClassList.Size = new System.Drawing.Size(250, 21);
            this.cmbClassList.Sorted = true;
            this.cmbClassList.TabIndex = 8;
            this.cmbClassList.SelectedIndexChanged += new System.EventHandler(this.cmbClassList_SelectedIndexChanged);
            // 
            // lblClassStatus
            // 
            this.lblClassStatus.Location = new System.Drawing.Point(106, 48);
            this.lblClassStatus.Name = "lblClassStatus";
            this.lblClassStatus.Size = new System.Drawing.Size(250, 23);
            this.lblClassStatus.TabIndex = 9;
            // 
            // lblQueryClasses
            // 
            this.lblQueryClasses.AutoSize = true;
            this.lblQueryClasses.Location = new System.Drawing.Point(6, 61);
            this.lblQueryClasses.Name = "lblQueryClasses";
            this.lblQueryClasses.Size = new System.Drawing.Size(95, 26);
            this.lblQueryClasses.TabIndex = 7;
            this.lblQueryClasses.Text = "Classes\r\n(dynamic or static):";
            // 
            // cmbNamespaceValue
            // 
            this.cmbNamespaceValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamespaceValue.Location = new System.Drawing.Point(106, 22);
            this.cmbNamespaceValue.MaxDropDownItems = 25;
            this.cmbNamespaceValue.Name = "cmbNamespaceValue";
            this.cmbNamespaceValue.Size = new System.Drawing.Size(250, 21);
            this.cmbNamespaceValue.Sorted = true;
            this.cmbNamespaceValue.TabIndex = 5;
            this.cmbNamespaceValue.SelectedIndexChanged += new System.EventHandler(this.cmbNamespaceValue_SelectedIndexChanged);
            // 
            // gbPropertyDataTable
            // 
            this.gbPropertyDataTable.Controls.Add(this.dgProperty);
            this.gbPropertyDataTable.Controls.Add(this.btnGetPropertyData);
            this.gbPropertyDataTable.Location = new System.Drawing.Point(12, 271);
            this.gbPropertyDataTable.Name = "gbPropertyDataTable";
            this.gbPropertyDataTable.Size = new System.Drawing.Size(1093, 473);
            this.gbPropertyDataTable.TabIndex = 7;
            this.gbPropertyDataTable.TabStop = false;
            this.gbPropertyDataTable.Text = "Property Data";
            // 
            // btnGetPropertyData
            // 
            this.btnGetPropertyData.Location = new System.Drawing.Point(9, 444);
            this.btnGetPropertyData.Name = "btnGetPropertyData";
            this.btnGetPropertyData.Size = new System.Drawing.Size(1074, 23);
            this.btnGetPropertyData.TabIndex = 0;
            this.btnGetPropertyData.Text = "Property Verilerini Çek";
            this.btnGetPropertyData.UseVisualStyleBackColor = true;
            this.btnGetPropertyData.Click += new System.EventHandler(this.btnGetPropertyData_Click);
            // 
            // dgProperty
            // 
            this.dgProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProperty.Location = new System.Drawing.Point(6, 19);
            this.dgProperty.Name = "dgProperty";
            this.dgProperty.Size = new System.Drawing.Size(1074, 419);
            this.dgProperty.TabIndex = 1;
            // 
            // frmWMITools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 755);
            this.Controls.Add(this.gbPropertyDataTable);
            this.Controls.Add(this.gbWMI);
            this.Name = "frmWMITools";
            this.Text = "WMI Tools";
            this.Load += new System.EventHandler(this.frmWMITools_Load);
            this.gbWMI.ResumeLayout(false);
            this.gbWMI.PerformLayout();
            this.gbPropertyDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProperty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWMI;
        private System.Windows.Forms.Label lblNameSpace;
        private System.Windows.Forms.ComboBox cmbClassList;
        private System.Windows.Forms.Label lblClassStatus;
        private System.Windows.Forms.Label lblQueryClasses;
        private System.Windows.Forms.ComboBox cmbNamespaceValue;
        private System.Windows.Forms.ListBox lstProperty;
        private System.Windows.Forms.Label lblPropertyResult;
        private System.Windows.Forms.Label lblPropList;
        private System.Windows.Forms.Button btnPropertyShow;
        private System.Windows.Forms.Label lblPropertyValueResult;
        private System.Windows.Forms.Label lblPropertyStatus;
        private System.Windows.Forms.ListBox lbPropertyValue;
        private System.Windows.Forms.Label lblPropertyValueStatus;
        private System.Windows.Forms.GroupBox gbPropertyDataTable;
        private System.Windows.Forms.Button btnGetPropertyData;
        private System.Windows.Forms.DataGridView dgProperty;
    }
}

