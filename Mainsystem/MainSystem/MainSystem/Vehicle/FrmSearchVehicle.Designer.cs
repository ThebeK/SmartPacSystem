namespace MainSystem.Vehicles
{
    partial class FrmSearchVehicle
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvClientSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchSale = new System.Windows.Forms.TextBox();
            //this.sPDataSet = new MainSystem.SPDataSet();
            this.vehicleStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.vehicle_StatusTableAdapter = new MainSystem.SPDataSetTableAdapters.Vehicle_StatusTableAdapter();
            //this.sPDataSet1 = new MainSystem.SPDataSet1();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.vehicleTableAdapter = new MainSystem.SPDataSet1TableAdapters.VehicleTableAdapter();
            //this.sPDataSet2 = new MainSystem.SPDataSet2();
            this.vehicleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            //this.vehicleTableAdapter1 = new MainSystem.SPDataSet2TableAdapters.VehicleTableAdapter();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRegistrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastServicedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientSearch)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.sPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleStatusBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.sPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.sPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 396);
            this.panel2.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please Specify Vehicles make";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 51);
            this.panel1.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(768, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 26;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(821, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(277, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(235, 34);
            this.label13.TabIndex = 25;
            this.label13.Text = "Search Vehicles";
            // 
            // btnMaintain
            // 
            this.btnMaintain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMaintain.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.btnMaintain.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnMaintain.Location = new System.Drawing.Point(749, 326);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(98, 27);
            this.btnMaintain.TabIndex = 33;
            this.btnMaintain.Text = "Maintain";
            this.btnMaintain.UseVisualStyleBackColor = false;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(352, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Please specify valid Vehicles make";
            this.label3.Visible = false;
            // 
            // dgvClientSearch
            // 
            this.dgvClientSearch.AutoGenerateColumns = false;
            this.dgvClientSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.vehicleRegistrationNumberDataGridViewTextBoxColumn,
            this.vehicleMakeDataGridViewTextBoxColumn,
            this.vehicleModelDataGridViewTextBoxColumn,
            this.vINNumberDataGridViewTextBoxColumn,
            this.lastServicedDataGridViewTextBoxColumn,
            this.vehicleStatusIDDataGridViewTextBoxColumn,
            this.vNumberDataGridViewTextBoxColumn});
            this.dgvClientSearch.DataSource = this.vehicleBindingSource1;
            this.dgvClientSearch.Location = new System.Drawing.Point(351, 136);
            this.dgvClientSearch.Name = "dgvClientSearch";
            this.dgvClientSearch.Size = new System.Drawing.Size(414, 150);
            this.dgvClientSearch.TabIndex = 31;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(749, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 27);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchSale
            // 
            this.txtSearchSale.Location = new System.Drawing.Point(356, 77);
            this.txtSearchSale.Name = "txtSearchSale";
            this.txtSearchSale.Size = new System.Drawing.Size(387, 20);
            this.txtSearchSale.TabIndex = 29;
            // 
            // sPDataSet
            // 
            //this.sPDataSet.DataSetName = "SPDataSet";
            //this.sPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleStatusBindingSource
            // 
            this.vehicleStatusBindingSource.DataMember = "Vehicle_Status";
            //this.vehicleStatusBindingSource.DataSource = this.sPDataSet;
            // 
            // vehicle_StatusTableAdapter
            // 
            //this.vehicle_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // sPDataSet1
            // 
            //this.sPDataSet1.DataSetName = "SPDataSet1";
            //this.sPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            //this.vehicleBindingSource.DataSource = this.sPDataSet1;
            // 
            // vehicleTableAdapter
            // 
            //this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // sPDataSet2
            // 
            //this.sPDataSet2.DataSetName = "SPDataSet2";
            //this.sPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource1
            // 
            this.vehicleBindingSource1.DataMember = "Vehicle";
            //this.vehicleBindingSource1.DataSource = this.sPDataSet2;
            // 
            // vehicleTableAdapter1
            // 
            //this.vehicleTableAdapter1.ClearBeforeFill = true;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_ID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleRegistrationNumberDataGridViewTextBoxColumn
            // 
            this.vehicleRegistrationNumberDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Registration_Number";
            this.vehicleRegistrationNumberDataGridViewTextBoxColumn.HeaderText = "Vehicle_Registration_Number";
            this.vehicleRegistrationNumberDataGridViewTextBoxColumn.Name = "vehicleRegistrationNumberDataGridViewTextBoxColumn";
            // 
            // vehicleMakeDataGridViewTextBoxColumn
            // 
            this.vehicleMakeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Make";
            this.vehicleMakeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Make";
            this.vehicleMakeDataGridViewTextBoxColumn.Name = "vehicleMakeDataGridViewTextBoxColumn";
            // 
            // vehicleModelDataGridViewTextBoxColumn
            // 
            this.vehicleModelDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Model";
            this.vehicleModelDataGridViewTextBoxColumn.HeaderText = "Vehicle_Model";
            this.vehicleModelDataGridViewTextBoxColumn.Name = "vehicleModelDataGridViewTextBoxColumn";
            // 
            // vINNumberDataGridViewTextBoxColumn
            // 
            this.vINNumberDataGridViewTextBoxColumn.DataPropertyName = "VIN_Number";
            this.vINNumberDataGridViewTextBoxColumn.HeaderText = "VIN_Number";
            this.vINNumberDataGridViewTextBoxColumn.Name = "vINNumberDataGridViewTextBoxColumn";
            // 
            // lastServicedDataGridViewTextBoxColumn
            // 
            this.lastServicedDataGridViewTextBoxColumn.DataPropertyName = "Last_Serviced";
            this.lastServicedDataGridViewTextBoxColumn.HeaderText = "Last_Serviced";
            this.lastServicedDataGridViewTextBoxColumn.Name = "lastServicedDataGridViewTextBoxColumn";
            // 
            // vehicleStatusIDDataGridViewTextBoxColumn
            // 
            this.vehicleStatusIDDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Status_ID";
            this.vehicleStatusIDDataGridViewTextBoxColumn.HeaderText = "Vehicle_Status_ID";
            this.vehicleStatusIDDataGridViewTextBoxColumn.Name = "vehicleStatusIDDataGridViewTextBoxColumn";
            // 
            // vNumberDataGridViewTextBoxColumn
            // 
            this.vNumberDataGridViewTextBoxColumn.DataPropertyName = "V_Number";
            this.vNumberDataGridViewTextBoxColumn.HeaderText = "V_Number";
            this.vNumberDataGridViewTextBoxColumn.Name = "vNumberDataGridViewTextBoxColumn";
            this.vNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmSearchVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(884, 447);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMaintain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvClientSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSearchVehicle";
            this.Text = "FrmSearchVehicle";
            this.Load += new System.EventHandler(this.FrmSearchVehicle_Load);
            this.Leave += new System.EventHandler(this.FrmSearchVehicle_Leave);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientSearch)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.sPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleStatusBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.sPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.sPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvClientSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchSale;
        //private SPDataSet sPDataSet;
        private System.Windows.Forms.BindingSource vehicleStatusBindingSource;
        //private SPDataSetTableAdapters.Vehicle_StatusTableAdapter vehicle_StatusTableAdapter;
        //private SPDataSet1 sPDataSet1;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        //private SPDataSet1TableAdapters.VehicleTableAdapter vehicleTableAdapter;
        //private SPDataSet2 sPDataSet2;
        private System.Windows.Forms.BindingSource vehicleBindingSource1;
        //private SPDataSet2TableAdapters.VehicleTableAdapter vehicleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegistrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastServicedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNumberDataGridViewTextBoxColumn;
    }
}