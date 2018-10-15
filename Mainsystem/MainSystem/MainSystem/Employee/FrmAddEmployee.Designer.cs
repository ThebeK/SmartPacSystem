namespace MainSystem.Employees
{
    partial class FrmAddEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pi = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTaxN = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblidentityNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTaxumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.txtESurname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnTakePicture = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployeetype = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.cbxTitle = new System.Windows.Forms.ComboBox();
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cbxEmployeeType = new System.Windows.Forms.ComboBox();
            this.employeeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pi)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pi);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pi
            // 
            this.pi.Image = global::MainSystem.Properties.Resources.Close;
            this.pi.Location = new System.Drawing.Point(1081, 7);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(51, 43);
            this.pi.TabIndex = 13;
            this.pi.TabStop = false;
            this.pi.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(1028, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 14;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Employees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 567);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTaxN);
            this.groupBox1.Controls.Add(this.lblAccountNumber);
            this.groupBox1.Controls.Add(this.lblidentityNumber);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtTaxumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAccountNum);
            this.groupBox1.Controls.Add(this.txtESurname);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtEName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(533, 549);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTaxN
            // 
            this.lblTaxN.AutoSize = true;
            this.lblTaxN.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxN.ForeColor = System.Drawing.Color.Red;
            this.lblTaxN.Location = new System.Drawing.Point(189, 413);
            this.lblTaxN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxN.Name = "lblTaxN";
            this.lblTaxN.Size = new System.Drawing.Size(240, 16);
            this.lblTaxN.TabIndex = 33;
            this.lblTaxN.Text = "Please enter a valid Tax Number";
            this.lblTaxN.Visible = false;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.Red;
            this.lblAccountNumber.Location = new System.Drawing.Point(147, 356);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(273, 16);
            this.lblAccountNumber.TabIndex = 29;
            this.lblAccountNumber.Text = "Please enter a valid Account Number";
            this.lblAccountNumber.Visible = false;
            // 
            // lblidentityNumber
            // 
            this.lblidentityNumber.AutoSize = true;
            this.lblidentityNumber.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentityNumber.ForeColor = System.Drawing.Color.Red;
            this.lblidentityNumber.Location = new System.Drawing.Point(189, 294);
            this.lblidentityNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidentityNumber.Name = "lblidentityNumber";
            this.lblidentityNumber.Size = new System.Drawing.Size(270, 16);
            this.lblidentityNumber.TabIndex = 28;
            this.lblidentityNumber.Text = "Please enter a valid Identity Number";
            this.lblidentityNumber.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Red;
            this.lblAddress.Location = new System.Drawing.Point(160, 220);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(211, 16);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Please enter a valid Address";
            this.lblAddress.Visible = false;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Red;
            this.lblSurname.Location = new System.Drawing.Point(172, 115);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(214, 16);
            this.lblSurname.TabIndex = 26;
            this.lblSurname.Text = "Please enter a valid Surname";
            this.lblSurname.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(180, 66);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(191, 16);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Please enter a valid name";
            this.lblName.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(73, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(150, 144);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(365, 73);
            this.txtAddress.TabIndex = 23;
            // 
            // txtTaxumber
            // 
            this.txtTaxumber.ForeColor = System.Drawing.Color.Black;
            this.txtTaxumber.Location = new System.Drawing.Point(150, 384);
            this.txtTaxumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTaxumber.MaxLength = 10;
            this.txtTaxumber.Name = "txtTaxumber";
            this.txtTaxumber.Size = new System.Drawing.Size(365, 27);
            this.txtTaxumber.TabIndex = 18;
            this.txtTaxumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(17, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tax Number";
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNum.Location = new System.Drawing.Point(150, 326);
            this.txtAccountNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAccountNum.MaxLength = 13;
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(365, 27);
            this.txtAccountNum.TabIndex = 11;
            this.txtAccountNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNum_KeyPress);
            // 
            // txtESurname
            // 
            this.txtESurname.ForeColor = System.Drawing.Color.Black;
            this.txtESurname.Location = new System.Drawing.Point(150, 85);
            this.txtESurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtESurname.Name = "txtESurname";
            this.txtESurname.Size = new System.Drawing.Size(365, 27);
            this.txtESurname.TabIndex = 10;
            this.txtESurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtESurname_KeyPress);
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(150, 264);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.MaxLength = 13;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(365, 27);
            this.txtID.TabIndex = 9;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtEName
            // 
            this.txtEName.ForeColor = System.Drawing.Color.Black;
            this.txtEName.Location = new System.Drawing.Point(150, 36);
            this.txtEName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(365, 27);
            this.txtEName.TabIndex = 8;
            this.txtEName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(8, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(17, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Identity Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(73, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(88, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(553, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 567);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblPicture);
            this.groupBox2.Controls.Add(this.btnAddEmployee);
            this.groupBox2.Controls.Add(this.btnTakePicture);
            this.groupBox2.Controls.Add(this.lblTitle);
            this.groupBox2.Controls.Add(this.lblEmployeetype);
            this.groupBox2.Controls.Add(this.lblEmailAddress);
            this.groupBox2.Controls.Add(this.lblContact);
            this.groupBox2.Controls.Add(this.cbxTitle);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbxEmployeeType);
            this.groupBox2.Controls.Add(this.txtEmailAddress);
            this.groupBox2.Controls.Add(this.txtContactNumber);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(9, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(530, 538);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(208, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.ForeColor = System.Drawing.Color.Red;
            this.lblPicture.Location = new System.Drawing.Point(17, 445);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(61, 16);
            this.lblPicture.TabIndex = 41;
            this.lblPicture.Text = "label12";
            this.lblPicture.Visible = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddEmployee.Location = new System.Drawing.Point(354, 477);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(128, 29);
            this.btnAddEmployee.TabIndex = 40;
            this.btnAddEmployee.Text = "Add Employees";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTakePicture.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnTakePicture.Location = new System.Drawing.Point(62, 280);
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.Size = new System.Drawing.Size(112, 29);
            this.btnTakePicture.TabIndex = 39;
            this.btnTakePicture.Text = "Take Picture";
            this.btnTakePicture.UseVisualStyleBackColor = false;
            this.btnTakePicture.Click += new System.EventHandler(this.btnTakePic_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(149, 246);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 16);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Please select a valid Title";
            this.lblTitle.Visible = false;
            // 
            // lblEmployeetype
            // 
            this.lblEmployeetype.AutoSize = true;
            this.lblEmployeetype.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeetype.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeetype.Location = new System.Drawing.Point(149, 54);
            this.lblEmployeetype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeetype.Name = "lblEmployeetype";
            this.lblEmployeetype.Size = new System.Drawing.Size(274, 16);
            this.lblEmployeetype.TabIndex = 35;
            this.lblEmployeetype.Text = "Please select a valid Employees Type";
            this.lblEmployeetype.Visible = false;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.ForeColor = System.Drawing.Color.Red;
            this.lblEmailAddress.Location = new System.Drawing.Point(174, 185);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(255, 16);
            this.lblEmailAddress.TabIndex = 34;
            this.lblEmailAddress.Text = "Please enter a valid Email Address";
            this.lblEmailAddress.Visible = false;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Red;
            this.lblContact.Location = new System.Drawing.Point(145, 128);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(270, 16);
            this.lblContact.TabIndex = 33;
            this.lblContact.Text = "Please enter a valid Contact Number";
            this.lblContact.Visible = false;
            // 
            // cbxTitle
            // 
            this.cbxTitle.DataSource = this.titleBindingSource;
            this.cbxTitle.DisplayMember = "Title_Description";
            this.cbxTitle.FormattingEnabled = true;
            this.cbxTitle.Location = new System.Drawing.Point(143, 215);
            this.cbxTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(140, 24);
            this.cbxTitle.TabIndex = 32;
            this.cbxTitle.ValueMember = "Title_Id";
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataMember = "Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(96, 216);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Title";
            // 
            // cbxEmployeeType
            // 
            this.cbxEmployeeType.DataSource = this.employeeTypeBindingSource;
            this.cbxEmployeeType.DisplayMember = "Employees_Type_Description";
            this.cbxEmployeeType.ForeColor = System.Drawing.Color.Black;
            this.cbxEmployeeType.FormattingEnabled = true;
            this.cbxEmployeeType.Location = new System.Drawing.Point(140, 27);
            this.cbxEmployeeType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxEmployeeType.Name = "cbxEmployeeType";
            this.cbxEmployeeType.Size = new System.Drawing.Size(342, 24);
            this.cbxEmployeeType.TabIndex = 28;
            this.cbxEmployeeType.ValueMember = "Employee_Type_ID";
            // 
            // employeeTypeBindingSource
            // 
            this.employeeTypeBindingSource.DataMember = "Employee_Type";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.txtEmailAddress.Location = new System.Drawing.Point(145, 155);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(337, 27);
            this.txtEmailAddress.TabIndex = 26;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.ForeColor = System.Drawing.Color.Black;
            this.txtContactNumber.Location = new System.Drawing.Point(143, 98);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContactNumber.MaxLength = 10;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(339, 27);
            this.txtContactNumber.TabIndex = 27;
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(27, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(10, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Contact Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(17, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Employees Type";
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1144, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddEmployee";
            this.Text = "FrmAddEmployee";
            this.Load += new System.EventHandler(this.FrmAddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pi;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTaxN;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblidentityNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTaxumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.TextBox txtESurname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTakePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployeetype;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.ComboBox cbxTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxEmployeeType;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ToolTip toolTip1;
        //private SPDataSet3 sPDataSet3;
        private System.Windows.Forms.BindingSource titleBindingSource;
        //private SPDataSet3TableAdapters.TitleTableAdapter titleTableAdapter;
        //private SPDataSet4 sPDataSet4;
        private System.Windows.Forms.BindingSource employeeTypeBindingSource;
        //private SPDataSet4TableAdapters.Employee_TypeTableAdapter employee_TypeTableAdapter;
        private System.Windows.Forms.Label lblPicture;
    }
}