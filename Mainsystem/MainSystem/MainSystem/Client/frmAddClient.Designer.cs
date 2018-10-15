namespace MainSystem
{
    partial class frmAddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddClient));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPhysicalAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVatRegNum = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFaxNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnViewCreditApproval = new System.Windows.Forms.Button();
            this.txtCreditAmount = new System.Windows.Forms.TextBox();
            this.cbxAccountStatus = new System.Windows.Forms.ComboBox();
            this.clientAccountStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtDateTimeDateOfCommencement = new System.Windows.Forms.DateTimePicker();
            this.cbxCreditStatus = new System.Windows.Forms.ComboBox();
            this.creditStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountStatusBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 570);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.cbxCity);
            this.groupBox4.Controls.Add(this.cbxProvince);
            this.groupBox4.Controls.Add(this.txtPhysicalAdd);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox4.Location = new System.Drawing.Point(12, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(638, 196);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Place Of Business";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(548, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 32);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbxCity
            // 
            this.cbxCity.DataSource = this.cityBindingSource;
            this.cbxCity.DisplayMember = "City_Name";
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(360, 121);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(174, 21);
            this.cbxCity.TabIndex = 19;
            this.cbxCity.ValueMember = "City_Id";
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.txtCity_SelectedIndexChanged);
            // 
            // cbxProvince
            // 
            this.cbxProvince.DataSource = this.provinceBindingSource;
            this.cbxProvince.DisplayMember = "Province_Name";
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(91, 121);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(174, 21);
            this.cbxProvince.TabIndex = 17;
            this.cbxProvince.ValueMember = "Province_Id";
            this.cbxProvince.SelectedIndexChanged += new System.EventHandler(this.txtProvince_SelectedIndexChanged);
            // 
            // txtPhysicalAdd
            // 
            this.txtPhysicalAdd.Location = new System.Drawing.Point(142, 26);
            this.txtPhysicalAdd.Multiline = true;
            this.txtPhysicalAdd.Name = "txtPhysicalAdd";
            this.txtPhysicalAdd.Size = new System.Drawing.Size(447, 85);
            this.txtPhysicalAdd.TabIndex = 14;
            this.txtPhysicalAdd.TextChanged += new System.EventHandler(this.txtPhysicalAdd_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(11, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Physical Address:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(312, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "City:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(11, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Province:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtVatRegNum);
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 55);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 20);
            this.txtName.MaxLength = 32;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(255, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "VAT Registration Number:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtVatRegNum
            // 
            this.txtVatRegNum.Location = new System.Drawing.Point(447, 21);
            this.txtVatRegNum.MaxLength = 10;
            this.txtVatRegNum.Name = "txtVatRegNum";
            this.txtVatRegNum.Size = new System.Drawing.Size(174, 20);
            this.txtVatRegNum.TabIndex = 1;
            this.txtVatRegNum.Text = " ";
            this.txtVatRegNum.TextChanged += new System.EventHandler(this.txtVatRegNum_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTelephone);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtFaxNumber);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtEmailAdd);
            this.groupBox3.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox3.Location = new System.Drawing.Point(12, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 114);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "+27";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email Address:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(142, 18);
            this.txtTelephone.MaxLength = 10;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(174, 20);
            this.txtTelephone.TabIndex = 2;
            this.txtTelephone.TextChanged += new System.EventHandler(this.txtTelephone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(324, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fax Number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtFaxNumber
            // 
            this.txtFaxNumber.Location = new System.Drawing.Point(429, 18);
            this.txtFaxNumber.MaxLength = 10;
            this.txtFaxNumber.Name = "txtFaxNumber";
            this.txtFaxNumber.Size = new System.Drawing.Size(174, 20);
            this.txtFaxNumber.TabIndex = 3;
            this.txtFaxNumber.TextChanged += new System.EventHandler(this.txtFaxNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Location = new System.Drawing.Point(127, 65);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(174, 20);
            this.txtEmailAdd.TabIndex = 4;
            this.txtEmailAdd.TextChanged += new System.EventHandler(this.txtEmailAdd_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(600, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 34);
            this.label9.TabIndex = 23;
            this.label9.Text = "Add Client";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 55);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(1213, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(1160, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 25;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCreditAmount);
            this.groupBox5.Controls.Add(this.cbxAccountStatus);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.txtDateTimeDateOfCommencement);
            this.groupBox5.Controls.Add(this.cbxCreditStatus);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox5.Location = new System.Drawing.Point(663, 65);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(613, 389);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Credit Approval Information";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // btnViewCreditApproval
            // 
            this.btnViewCreditApproval.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewCreditApproval.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewCreditApproval.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCreditApproval.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewCreditApproval.Location = new System.Drawing.Point(913, 461);
            this.btnViewCreditApproval.Name = "btnViewCreditApproval";
            this.btnViewCreditApproval.Size = new System.Drawing.Size(207, 41);
            this.btnViewCreditApproval.TabIndex = 17;
            this.btnViewCreditApproval.Text = "View Credit Approval";
            this.btnViewCreditApproval.UseVisualStyleBackColor = false;
            this.btnViewCreditApproval.Click += new System.EventHandler(this.btnViewCreditApproval_Click);
            // 
            // txtCreditAmount
            // 
            this.txtCreditAmount.Location = new System.Drawing.Point(238, 39);
            this.txtCreditAmount.Name = "txtCreditAmount";
            this.txtCreditAmount.Size = new System.Drawing.Size(186, 27);
            this.txtCreditAmount.TabIndex = 24;
            this.txtCreditAmount.TextChanged += new System.EventHandler(this.txtCreditAmount_TextChanged);
            // 
            // cbxAccountStatus
            // 
            this.cbxAccountStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxAccountStatus.DataSource = this.clientAccountStatusBindingSource;
            this.cbxAccountStatus.DisplayMember = "Account_Status_Description";
            this.cbxAccountStatus.FormattingEnabled = true;
            this.cbxAccountStatus.Location = new System.Drawing.Point(238, 170);
            this.cbxAccountStatus.Name = "cbxAccountStatus";
            this.cbxAccountStatus.Size = new System.Drawing.Size(196, 24);
            this.cbxAccountStatus.TabIndex = 23;
            this.cbxAccountStatus.ValueMember = "Account_Status_ID";
            this.cbxAccountStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(45, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Account Status";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.btnBrowse);
            this.groupBox6.Controls.Add(this.txtFilePath);
            this.groupBox6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox6.Location = new System.Drawing.Point(31, 230);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(452, 98);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Upload Credit Approval Form";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(14, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "File Path:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBrowse.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnBrowse.Location = new System.Drawing.Point(338, 65);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(99, 27);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilePath.Location = new System.Drawing.Point(118, 26);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(319, 27);
            this.txtFilePath.TabIndex = 7;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // txtDateTimeDateOfCommencement
            // 
            this.txtDateTimeDateOfCommencement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateTimeDateOfCommencement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateTimeDateOfCommencement.Location = new System.Drawing.Point(238, 119);
            this.txtDateTimeDateOfCommencement.Name = "txtDateTimeDateOfCommencement";
            this.txtDateTimeDateOfCommencement.Size = new System.Drawing.Size(186, 27);
            this.txtDateTimeDateOfCommencement.TabIndex = 19;
            this.txtDateTimeDateOfCommencement.ValueChanged += new System.EventHandler(this.txtDateTimeDateOfCommencement_ValueChanged);
            // 
            // cbxCreditStatus
            // 
            this.cbxCreditStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxCreditStatus.DataSource = this.creditStatusBindingSource;
            this.cbxCreditStatus.DisplayMember = "Credit_Status_Description";
            this.cbxCreditStatus.FormattingEnabled = true;
            this.cbxCreditStatus.Location = new System.Drawing.Point(238, 72);
            this.cbxCreditStatus.Name = "cbxCreditStatus";
            this.cbxCreditStatus.Size = new System.Drawing.Size(186, 24);
            this.cbxCreditStatus.TabIndex = 18;
            this.cbxCreditStatus.ValueMember = "Credit_Status_ID";
            this.cbxCreditStatus.SelectedIndexChanged += new System.EventHandler(this.txtCreditSta_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(45, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Date of Commencement:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(45, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Credit Status:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(45, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Credit Approval Amount:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddClient.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddClient.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddClient.Location = new System.Drawing.Point(732, 461);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(145, 41);
            this.btnAddClient.TabIndex = 18;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1276, 625);
            this.Controls.Add(this.btnViewCreditApproval);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddClient";
            this.Text = "frmAddClient";
            this.Load += new System.EventHandler(this.frmAddClient_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountStatusBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.TextBox txtPhysicalAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVatRegNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFaxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCreditAmount;
        private System.Windows.Forms.ComboBox cbxAccountStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.DateTimePicker txtDateTimeDateOfCommencement;
        private System.Windows.Forms.ComboBox cbxCreditStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnViewCreditApproval;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.BindingSource clientAccountStatusBindingSource;
        private System.Windows.Forms.BindingSource creditStatusBindingSource;
    }
}