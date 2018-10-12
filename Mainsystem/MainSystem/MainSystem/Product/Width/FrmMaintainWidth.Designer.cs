namespace MainSystem.Product.Width
{
    partial class FrmMaintainWidth
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeletePT = new System.Windows.Forms.Button();
            this.btnUpdatePT = new System.Windows.Forms.Button();
            this.txtWidthDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 61);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(532, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(479, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 64;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 34);
            this.label3.TabIndex = 61;
            this.label3.Text = "Maintain Width";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnBack.Location = new System.Drawing.Point(67, 198);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 47);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUnit.ForeColor = System.Drawing.Color.Red;
            this.lblUnit.Location = new System.Drawing.Point(336, 141);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(182, 16);
            this.lblUnit.TabIndex = 60;
            this.lblUnit.Text = "Please enter a valid unit";
            this.lblUnit.Visible = false;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblWidth.ForeColor = System.Drawing.Color.Red;
            this.lblWidth.Location = new System.Drawing.Point(93, 138);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(193, 16);
            this.lblWidth.TabIndex = 59;
            this.lblWidth.Text = "Please enter a valid width";
            this.lblWidth.Visible = false;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(382, 113);
            this.txtUnit.Multiline = true;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(55, 22);
            this.txtUnit.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(335, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Unit";
            // 
            // btnDeletePT
            // 
            this.btnDeletePT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeletePT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeletePT.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeletePT.Location = new System.Drawing.Point(382, 198);
            this.btnDeletePT.Name = "btnDeletePT";
            this.btnDeletePT.Size = new System.Drawing.Size(138, 47);
            this.btnDeletePT.TabIndex = 56;
            this.btnDeletePT.Text = "Delete Product Width";
            this.btnDeletePT.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePT
            // 
            this.btnUpdatePT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdatePT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePT.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdatePT.Location = new System.Drawing.Point(221, 198);
            this.btnUpdatePT.Name = "btnUpdatePT";
            this.btnUpdatePT.Size = new System.Drawing.Size(141, 47);
            this.btnUpdatePT.TabIndex = 55;
            this.btnUpdatePT.Text = "Update Product Width";
            this.btnUpdatePT.UseVisualStyleBackColor = false;
            // 
            // txtWidthDesc
            // 
            this.txtWidthDesc.Location = new System.Drawing.Point(156, 113);
            this.txtWidthDesc.Multiline = true;
            this.txtWidthDesc.Name = "txtWidthDesc";
            this.txtWidthDesc.Size = new System.Drawing.Size(55, 22);
            this.txtWidthDesc.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(103, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Width";
            // 
            // FrmMaintainWidth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(586, 285);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeletePT);
            this.Controls.Add(this.btnUpdatePT);
            this.Controls.Add(this.txtWidthDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMaintainWidth";
            this.Text = "FrmMaintainWidth";
            this.Load += new System.EventHandler(this.FrmMaintainWidth_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeletePT;
        private System.Windows.Forms.Button btnUpdatePT;
        private System.Windows.Forms.TextBox txtWidthDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
    }
}