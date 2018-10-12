namespace MainSystem.StartUp
{
    partial class FrmFirstTimeStartup
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
            this.lblStepTwoResponse = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.llCreateDB = new System.Windows.Forms.LinkLabel();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStepTwoResponse
            // 
            this.lblStepTwoResponse.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepTwoResponse.Location = new System.Drawing.Point(6, 153);
            this.lblStepTwoResponse.Name = "lblStepTwoResponse";
            this.lblStepTwoResponse.Size = new System.Drawing.Size(375, 107);
            this.lblStepTwoResponse.TabIndex = 161;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 334);
            this.tabControl1.TabIndex = 151;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lblStepTwoResponse);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database Installation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.llCreateDB);
            this.groupBox1.Controls.Add(this.lbPercentage);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Location = new System.Drawing.Point(378, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 221);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 166;
            this.label2.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 167;
            this.label4.Text = "Database";
            // 
            // llCreateDB
            // 
            this.llCreateDB.AutoSize = true;
            this.llCreateDB.Location = new System.Drawing.Point(45, 191);
            this.llCreateDB.Name = "llCreateDB";
            this.llCreateDB.Size = new System.Drawing.Size(110, 16);
            this.llCreateDB.TabIndex = 7;
            this.llCreateDB.TabStop = true;
            this.llCreateDB.Text = "Create Database";
            this.llCreateDB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCreateDB_LinkClicked);
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.ForeColor = System.Drawing.Color.Black;
            this.lbPercentage.Location = new System.Drawing.Point(212, 167);
            this.lbPercentage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(25, 16);
            this.lbPercentage.TabIndex = 163;
            this.lbPercentage.Text = "0%";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(140, 67);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(8);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(77, 27);
            this.txtDatabase.TabIndex = 165;
            this.txtDatabase.Text = "SP";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar1.ForeColor = System.Drawing.Color.Turquoise;
            this.progressBar1.Location = new System.Drawing.Point(48, 110);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(8);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(275, 39);
            this.progressBar1.TabIndex = 162;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(140, 23);
            this.txtServer.Margin = new System.Windows.Forms.Padding(8);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(79, 27);
            this.txtServer.TabIndex = 164;
            this.txtServer.Text = ".";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Location = new System.Drawing.Point(159, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 55);
            this.button4.TabIndex = 9;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(35, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Step 1: Check SQL Database";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Location = new System.Drawing.Point(39, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 55);
            this.button3.TabIndex = 5;
            this.button3.Text = "Check";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(744, 55);
            this.panel2.TabIndex = 152;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(340, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 55);
            this.button5.TabIndex = 10;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmFirstTimeStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(744, 392);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFirstTimeStartup";
            this.Text = "FrmFirstTimeStartup";
            this.Load += new System.EventHandler(this.FrmFirstTimeStartup_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStepTwoResponse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llCreateDB;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
    }
}