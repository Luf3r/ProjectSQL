
namespace WFABD
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvCity = new System.Windows.Forms.DataGridView();
            this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spCityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_cityDataSet = new WFABD.database_cityDataSet();
            this.databasecityDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.spCityTableAdapter = new WFABD.database_cityDataSetTableAdapters.spCityTableAdapter();
            this.tableAdapterManager = new WFABD.database_cityDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrynameengDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.logidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new WFABD.database_cityDataSetTableAdapters.logsTableAdapter();
            this.countryTableAdapter = new WFABD.database_cityDataSetTableAdapters.countryTableAdapter();
            this.txtContName = new System.Windows.Forms.TextBox();
            this.txtContEng = new System.Windows.Forms.TextBox();
            this.txtContCod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUPC = new System.Windows.Forms.Button();
            this.btnDELC = new System.Windows.Forms.Button();
            this.btnISC = new System.Windows.Forms.Button();
            this.txtcoID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_cityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasecityDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCity
            // 
            this.dgvCity.AutoGenerateColumns = false;
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityIdDataGridViewTextBoxColumn,
            this.citynameDataGridViewTextBoxColumn,
            this.latDataGridViewTextBoxColumn,
            this.longDataGridViewTextBoxColumn,
            this.countryidDataGridViewTextBoxColumn});
            this.dgvCity.DataSource = this.spCityBindingSource;
            this.dgvCity.Location = new System.Drawing.Point(12, 12);
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.Size = new System.Drawing.Size(543, 264);
            this.dgvCity.TabIndex = 0;
            this.dgvCity.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCity_CellDoubleClick);
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
            this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            this.cityIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citynameDataGridViewTextBoxColumn
            // 
            this.citynameDataGridViewTextBoxColumn.DataPropertyName = "city_name";
            this.citynameDataGridViewTextBoxColumn.HeaderText = "city_name";
            this.citynameDataGridViewTextBoxColumn.Name = "citynameDataGridViewTextBoxColumn";
            // 
            // latDataGridViewTextBoxColumn
            // 
            this.latDataGridViewTextBoxColumn.DataPropertyName = "lat";
            this.latDataGridViewTextBoxColumn.HeaderText = "lat";
            this.latDataGridViewTextBoxColumn.Name = "latDataGridViewTextBoxColumn";
            // 
            // longDataGridViewTextBoxColumn
            // 
            this.longDataGridViewTextBoxColumn.DataPropertyName = "long";
            this.longDataGridViewTextBoxColumn.HeaderText = "long";
            this.longDataGridViewTextBoxColumn.Name = "longDataGridViewTextBoxColumn";
            // 
            // countryidDataGridViewTextBoxColumn
            // 
            this.countryidDataGridViewTextBoxColumn.DataPropertyName = "country_id";
            this.countryidDataGridViewTextBoxColumn.HeaderText = "country_id";
            this.countryidDataGridViewTextBoxColumn.Name = "countryidDataGridViewTextBoxColumn";
            // 
            // spCityBindingSource
            // 
            this.spCityBindingSource.DataMember = "spCity";
            this.spCityBindingSource.DataSource = this.database_cityDataSet;
            // 
            // database_cityDataSet
            // 
            this.database_cityDataSet.DataSetName = "database_cityDataSet";
            this.database_cityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databasecityDataSetBindingSource
            // 
            this.databasecityDataSetBindingSource.DataSource = this.database_cityDataSet;
            this.databasecityDataSetBindingSource.Position = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(93, 336);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 20);
            this.txtCName.TabIndex = 4;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(93, 362);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 20);
            this.txtLat.TabIndex = 5;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(93, 388);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 20);
            this.txtLong.TabIndex = 6;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(93, 418);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(100, 20);
            this.txtCID.TabIndex = 7;
            // 
            // spCityTableAdapter
            // 
            this.spCityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.logsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFABD.database_cityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "City Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Long:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Country Id:";
            // 
            // dgvCountry
            // 
            this.dgvCountry.AllowUserToAddRows = false;
            this.dgvCountry.AllowUserToDeleteRows = false;
            this.dgvCountry.AutoGenerateColumns = false;
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.countrynameDataGridViewTextBoxColumn,
            this.countrynameengDataGridViewTextBoxColumn,
            this.countrycodeDataGridViewTextBoxColumn});
            this.dgvCountry.DataSource = this.countryBindingSource;
            this.dgvCountry.Location = new System.Drawing.Point(591, 12);
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.ReadOnly = true;
            this.dgvCountry.Size = new System.Drawing.Size(543, 264);
            this.dgvCountry.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countrynameDataGridViewTextBoxColumn
            // 
            this.countrynameDataGridViewTextBoxColumn.DataPropertyName = "country_name";
            this.countrynameDataGridViewTextBoxColumn.HeaderText = "country_name";
            this.countrynameDataGridViewTextBoxColumn.Name = "countrynameDataGridViewTextBoxColumn";
            // 
            // countrynameengDataGridViewTextBoxColumn
            // 
            this.countrynameengDataGridViewTextBoxColumn.DataPropertyName = "country_name_eng";
            this.countrynameengDataGridViewTextBoxColumn.HeaderText = "country_name_eng";
            this.countrynameengDataGridViewTextBoxColumn.Name = "countrynameengDataGridViewTextBoxColumn";
            // 
            // countrycodeDataGridViewTextBoxColumn
            // 
            this.countrycodeDataGridViewTextBoxColumn.DataPropertyName = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.HeaderText = "country_code";
            this.countrycodeDataGridViewTextBoxColumn.Name = "countrycodeDataGridViewTextBoxColumn";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "country";
            this.countryBindingSource.DataSource = this.database_cityDataSet;
            // 
            // dgvLogs
            // 
            this.dgvLogs.AutoGenerateColumns = false;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.tablenameDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn});
            this.dgvLogs.DataSource = this.logsBindingSource;
            this.dgvLogs.Location = new System.Drawing.Point(1152, 12);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.Size = new System.Drawing.Size(345, 264);
            this.dgvLogs.TabIndex = 13;
            // 
            // logidDataGridViewTextBoxColumn
            // 
            this.logidDataGridViewTextBoxColumn.DataPropertyName = "logid";
            this.logidDataGridViewTextBoxColumn.HeaderText = "logid";
            this.logidDataGridViewTextBoxColumn.Name = "logidDataGridViewTextBoxColumn";
            this.logidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // tablenameDataGridViewTextBoxColumn
            // 
            this.tablenameDataGridViewTextBoxColumn.DataPropertyName = "tablename";
            this.tablenameDataGridViewTextBoxColumn.HeaderText = "tablename";
            this.tablenameDataGridViewTextBoxColumn.Name = "tablenameDataGridViewTextBoxColumn";
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "operation";
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "logs";
            this.logsBindingSource.DataSource = this.database_cityDataSet;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // txtContName
            // 
            this.txtContName.Location = new System.Drawing.Point(684, 332);
            this.txtContName.Name = "txtContName";
            this.txtContName.Size = new System.Drawing.Size(100, 20);
            this.txtContName.TabIndex = 14;
            // 
            // txtContEng
            // 
            this.txtContEng.Location = new System.Drawing.Point(684, 362);
            this.txtContEng.Name = "txtContEng";
            this.txtContEng.Size = new System.Drawing.Size(100, 20);
            this.txtContEng.TabIndex = 15;
            // 
            // txtContCod
            // 
            this.txtContCod.Location = new System.Drawing.Point(684, 388);
            this.txtContCod.Name = "txtContCod";
            this.txtContCod.Size = new System.Drawing.Size(100, 20);
            this.txtContCod.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Country Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Country Eng Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Country Code:";
            // 
            // btnUPC
            // 
            this.btnUPC.Location = new System.Drawing.Point(591, 282);
            this.btnUPC.Name = "btnUPC";
            this.btnUPC.Size = new System.Drawing.Size(75, 23);
            this.btnUPC.TabIndex = 20;
            this.btnUPC.Text = "Update";
            this.btnUPC.UseVisualStyleBackColor = true;
            this.btnUPC.Click += new System.EventHandler(this.btnUPC_Click);
            // 
            // btnDELC
            // 
            this.btnDELC.Location = new System.Drawing.Point(672, 282);
            this.btnDELC.Name = "btnDELC";
            this.btnDELC.Size = new System.Drawing.Size(75, 23);
            this.btnDELC.TabIndex = 21;
            this.btnDELC.Text = "Delete";
            this.btnDELC.UseVisualStyleBackColor = true;
            this.btnDELC.Click += new System.EventHandler(this.btnDELC_Click);
            // 
            // btnISC
            // 
            this.btnISC.Location = new System.Drawing.Point(753, 282);
            this.btnISC.Name = "btnISC";
            this.btnISC.Size = new System.Drawing.Size(75, 23);
            this.btnISC.TabIndex = 22;
            this.btnISC.Text = "Insert";
            this.btnISC.UseVisualStyleBackColor = true;
            this.btnISC.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtcoID
            // 
            this.txtcoID.Location = new System.Drawing.Point(684, 415);
            this.txtcoID.Name = "txtcoID";
            this.txtcoID.Size = new System.Drawing.Size(100, 20);
            this.txtcoID.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(657, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 456);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcoID);
            this.Controls.Add(this.btnISC);
            this.Controls.Add(this.btnDELC);
            this.Controls.Add(this.btnUPC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContCod);
            this.Controls.Add(this.txtContEng);
            this.Controls.Add(this.txtContName);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.dgvCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_cityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasecityDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.BindingSource databasecityDataSetBindingSource;
        private database_cityDataSet database_cityDataSet;
        private System.Windows.Forms.BindingSource spCityBindingSource;
        private database_cityDataSetTableAdapters.spCityTableAdapter spCityTableAdapter;
        private database_cityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCountry;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private database_cityDataSetTableAdapters.logsTableAdapter logsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn logidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private database_cityDataSetTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.TextBox txtContName;
        private System.Windows.Forms.TextBox txtContEng;
        private System.Windows.Forms.TextBox txtContCod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUPC;
        private System.Windows.Forms.Button btnDELC;
        private System.Windows.Forms.Button btnISC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrynameengDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtcoID;
        private System.Windows.Forms.Label label8;
    }
}

