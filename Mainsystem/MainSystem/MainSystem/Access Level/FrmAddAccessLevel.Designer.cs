﻿namespace MainSystem.AccessLevel
{
    partial class FrmAddAccessLevel
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtErrorName = new System.Windows.Forms.Label();
            this.txtAccessName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxClient = new System.Windows.Forms.CheckBox();
            this.cbWebsite = new System.Windows.Forms.CheckBox();
            this.cbxReportsScreen = new System.Windows.Forms.CheckBox();
            this.cbxProductScreen = new System.Windows.Forms.CheckBox();
            this.cbxVehicleScreen = new System.Windows.Forms.CheckBox();
            this.cbxSaleScreen = new System.Windows.Forms.CheckBox();
            this.cbxAdminScreen = new System.Windows.Forms.CheckBox();
            this.cbxPurchaseOrderScreen = new System.Windows.Forms.CheckBox();
            this.cbxSupplierOrderScreen = new System.Windows.Forms.CheckBox();
            this.cbxEmployeeScreen = new System.Windows.Forms.CheckBox();
            this.cbxUserAccessLevelScreen = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Location = new System.Drawing.Point(14, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1065, 451);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtErrorName);
            this.groupBox2.Controls.Add(this.txtAccessName);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(43, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(998, 371);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users Access Level";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.Location = new System.Drawing.Point(841, 332);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtErrorName
            // 
            this.txtErrorName.AutoSize = true;
            this.txtErrorName.ForeColor = System.Drawing.Color.Red;
            this.txtErrorName.Location = new System.Drawing.Point(388, 57);
            this.txtErrorName.Name = "txtErrorName";
            this.txtErrorName.Size = new System.Drawing.Size(180, 16);
            this.txtErrorName.TabIndex = 28;
            this.txtErrorName.Text = "Enter access level name";
            this.txtErrorName.Visible = false;
            // 
            // txtAccessName
            // 
            this.txtAccessName.Location = new System.Drawing.Point(191, 51);
            this.txtAccessName.Name = "txtAccessName";
            this.txtAccessName.Size = new System.Drawing.Size(188, 27);
            this.txtAccessName.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Controls.Add(this.cbxClient);
            this.groupBox3.Controls.Add(this.cbWebsite);
            this.groupBox3.Controls.Add(this.cbxReportsScreen);
            this.groupBox3.Controls.Add(this.cbxProductScreen);
            this.groupBox3.Controls.Add(this.cbxVehicleScreen);
            this.groupBox3.Controls.Add(this.cbxSaleScreen);
            this.groupBox3.Controls.Add(this.cbxAdminScreen);
            this.groupBox3.Controls.Add(this.cbxPurchaseOrderScreen);
            this.groupBox3.Controls.Add(this.cbxSupplierOrderScreen);
            this.groupBox3.Controls.Add(this.cbxEmployeeScreen);
            this.groupBox3.Controls.Add(this.cbxUserAccessLevelScreen);
            this.groupBox3.Location = new System.Drawing.Point(26, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(965, 209);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Access Levels";
            // 
            // cbxClient
            // 
            this.cbxClient.AutoSize = true;
            this.cbxClient.ForeColor = System.Drawing.Color.Silver;
            this.cbxClient.Location = new System.Drawing.Point(15, 121);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(70, 20);
            this.cbxClient.TabIndex = 32;
            this.cbxClient.Text = "Clients";
            this.cbxClient.UseVisualStyleBackColor = true;
            // 
            // cbWebsite
            // 
            this.cbWebsite.AutoSize = true;
            this.cbWebsite.ForeColor = System.Drawing.Color.Silver;
            this.cbWebsite.Location = new System.Drawing.Point(660, 22);
            this.cbWebsite.Name = "cbWebsite";
            this.cbWebsite.Size = new System.Drawing.Size(83, 20);
            this.cbWebsite.TabIndex = 25;
            this.cbWebsite.Text = "Website";
            this.cbWebsite.UseVisualStyleBackColor = true;
            // 
            // cbxReportsScreen
            // 
            this.cbxReportsScreen.AutoSize = true;
            this.cbxReportsScreen.ForeColor = System.Drawing.Color.Silver;
            this.cbxReportsScreen.Location = new System.Drawing.Point(660, 75);
            this.cbxReportsScreen.Name = "cbxReportsScreen";
            this.cbxReportsScreen.Size = new System.Drawing.Size(82, 20);
            this.cbxReportsScreen.TabIndex = 28;
            this.cbxReportsScreen.Text = "Reports";
            this.cbxReportsScreen.UseVisualStyleBackColor = true;
            // 
            // cbxProductScreen
            // 
            this.cbxProductScreen.AutoSize = true;
            this.cbxProductScreen.ForeColor = System.Drawing.Color.Silver;
            this.cbxProductScreen.Location = new System.Drawing.Point(456, 75);
            this.cbxProductScreen.Name = "cbxProductScreen";
            this.cbxProductScreen.Size = new System.Drawing.Size(82, 20);
            this.cbxProductScreen.TabIndex = 21;
            this.cbxProductScreen.Text = "Products";
            this.cbxProductScreen.UseVisualStyleBackColor = true;
            // 
            // cbxVehicleScreen
            // 
            this.cbxVehicleScreen.AutoSize = true;
            this.cbxVehicleScreen.ForeColor = System.Drawing.Color.Silver;
            this.cbxVehicleScreen.Location = new System.Drawing.Point(847, 22);
            this.cbxVehicleScreen.Name = "cbxVehicleScreen";
            this.cbxVehicleScreen.Size = new System.Drawing.Size(80, 20);
            this.cbxVehicleScreen.TabIndex = 21;
            this.cbxVehicleScreen.Text = "Vehicles";
            this.cbxVehicleScreen.UseVisualStyleBackColor = true;
            // 
            // cbxSaleScreen
            // 
            this.cbxSaleScreen.AutoSize = true;
            this.cbxSaleScreen.ForeColor = System.Drawing.Color.Silver;
            this.cbxSaleScreen.Location = new System.Drawing.Point(847, 75);
            this.cbxSaleScreen.Name = "cbxSaleScreen";
            this.cbxSaleScreen.Size = new System.Drawing.Size(56, 20);
            this.cbxSaleScreen.TabIndex = 27;
            this.cbxSaleScreen.Text = "Sale";
            this.cbxSaleScreen.UseVisualStyleBackColor = true;
            // 
            // cbxAdminScreen
            // 
            this.cbxAdminScreen.AutoSize = true;
            this.cbxAdminScreen.ForeColor = System.Drawing.Color.Silver;
            this.cbxAdminScreen.Location = new System.Drawing.Point(12, 22);
            this.cbxAdminScreen.Name = "cbxAdminScreen";
            this.cbxAdminScreen.Size = new System.Drawing.Size(73, 20);
            this.cbxAdminScreen.TabIndex = 22;
            this.cbxAdminScreen.Text = "Admin";
            this.cbxAdminScreen.UseVisualStyleBackColor = true;
            // 
            // cbxPurchaseOrderScreen
            // 
            this.cbxPurchaseOrderScreen.AutoSize = true;
            this.cbxPurchaseOrderScreen.ForeColor = System.Drawing.Color.Silver;
            this.cbxPurchaseOrderScreen.Location = new System.Drawing.Point(227, 75);
            this.cbxPurchaseOrderScreen.Name = "cbxPurchaseOrderScreen";
            this.cbxPurchaseOrderScreen.Size = new System.Drawing.Size(136, 20);
            this.cbxPurchaseOrderScreen.TabIndex = 24;
            this.cbxPurchaseOrderScreen.Text = "Purchase Order";
            this.cbxPurchaseOrderScreen.UseVisualStyleBackColor = true;
            // 
            // cbxSupplierOrderScreen
            // 
            this.cbxSupplierOrderScreen.AutoSize = true;
            this.cbxSupplierOrderScreen.ForeColor = System.Drawing.Color.Silver;
            this.cbxSupplierOrderScreen.Location = new System.Drawing.Point(12, 75);
            this.cbxSupplierOrderScreen.Name = "cbxSupplierOrderScreen";
            this.cbxSupplierOrderScreen.Size = new System.Drawing.Size(131, 20);
            this.cbxSupplierOrderScreen.TabIndex = 25;
            this.cbxSupplierOrderScreen.Text = "Supplier Order";
            this.cbxSupplierOrderScreen.UseVisualStyleBackColor = true;
            // 
            // cbxEmployeeScreen
            // 
            this.cbxEmployeeScreen.AutoSize = true;
            this.cbxEmployeeScreen.ForeColor = System.Drawing.Color.Silver;
            this.cbxEmployeeScreen.Location = new System.Drawing.Point(456, 22);
            this.cbxEmployeeScreen.Name = "cbxEmployeeScreen";
            this.cbxEmployeeScreen.Size = new System.Drawing.Size(95, 20);
            this.cbxEmployeeScreen.TabIndex = 26;
            this.cbxEmployeeScreen.Text = "Employees";
            this.cbxEmployeeScreen.UseVisualStyleBackColor = true;
            // 
            // cbxUserAccessLevelScreen
            // 
            this.cbxUserAccessLevelScreen.AutoSize = true;
            this.cbxUserAccessLevelScreen.ForeColor = System.Drawing.Color.Silver;
            this.cbxUserAccessLevelScreen.Location = new System.Drawing.Point(227, 22);
            this.cbxUserAccessLevelScreen.Name = "cbxUserAccessLevelScreen";
            this.cbxUserAccessLevelScreen.Size = new System.Drawing.Size(156, 20);
            this.cbxUserAccessLevelScreen.TabIndex = 23;
            this.cbxUserAccessLevelScreen.Text = "Users Access Level";
            this.cbxUserAccessLevelScreen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(35, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Access Level Name:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 451);
            this.splitter1.TabIndex = 33;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 51);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(1038, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(985, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 14;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(344, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Access Level";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // FrmAddAccessLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1092, 536);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddAccessLevel";
            this.Text = "FrmAddAccessLevel";
            this.Load += new System.EventHandler(this.FrmAddAccessLevel_Load);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label txtErrorName;
        private System.Windows.Forms.TextBox txtAccessName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbxClient;
        private System.Windows.Forms.CheckBox cbWebsite;
        private System.Windows.Forms.CheckBox cbxReportsScreen;
        private System.Windows.Forms.CheckBox cbxProductScreen;
        private System.Windows.Forms.CheckBox cbxVehicleScreen;
        private System.Windows.Forms.CheckBox cbxSaleScreen;
        private System.Windows.Forms.CheckBox cbxAdminScreen;
        private System.Windows.Forms.CheckBox cbxPurchaseOrderScreen;
        private System.Windows.Forms.CheckBox cbxSupplierOrderScreen;
        private System.Windows.Forms.CheckBox cbxEmployeeScreen;
        private System.Windows.Forms.CheckBox cbxUserAccessLevelScreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}