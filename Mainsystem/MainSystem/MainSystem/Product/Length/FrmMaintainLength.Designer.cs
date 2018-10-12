namespace MainSystem.Products.Length
{
    partial class FrmMaintainLength
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 54);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(58, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 31);
            this.label3.TabIndex = 31;
            this.label3.Text = "Maintain Length";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(362, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(309, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 31;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUnit.ForeColor = System.Drawing.Color.Red;
            this.lblUnit.Location = new System.Drawing.Point(222, 108);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(182, 16);
            this.lblUnit.TabIndex = 40;
            this.lblUnit.Text = "Please enter a valid unit";
            this.lblUnit.Visible = false;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLength.ForeColor = System.Drawing.Color.Red;
            this.lblLength.Location = new System.Drawing.Point(17, 108);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(199, 16);
            this.lblLength.TabIndex = 39;
            this.lblLength.Text = "Please enter a valid length";
            this.lblLength.Visible = false;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(266, 75);
            this.txtUnit.Multiline = true;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(55, 22);
            this.txtUnit.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(220, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Unit";
            // 
            // btnDeletePT
            // 
            this.btnDeletePT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeletePT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeletePT.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeletePT.Location = new System.Drawing.Point(236, 142);
            this.btnDeletePT.Name = "btnDeletePT";
            this.btnDeletePT.Size = new System.Drawing.Size(101, 56);
            this.btnDeletePT.TabIndex = 36;
            this.btnDeletePT.Text = "Delete Products Length";
            this.btnDeletePT.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePT
            // 
            this.btnUpdatePT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdatePT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePT.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdatePT.Location = new System.Drawing.Point(95, 142);
            this.btnUpdatePT.Name = "btnUpdatePT";
            this.btnUpdatePT.Size = new System.Drawing.Size(94, 56);
            this.btnUpdatePT.TabIndex = 35;
            this.btnUpdatePT.Text = "Update Products Length";
            this.btnUpdatePT.UseVisualStyleBackColor = false;
            // 
            // txtWidthDesc
            // 
            this.txtWidthDesc.Location = new System.Drawing.Point(73, 75);
            this.txtWidthDesc.Multiline = true;
            this.txtWidthDesc.Name = "txtWidthDesc";
            this.txtWidthDesc.Size = new System.Drawing.Size(55, 22);
            this.txtWidthDesc.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(17, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Length";
            // 
            // FrmMaintainLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(418, 222);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeletePT);
            this.Controls.Add(this.btnUpdatePT);
            this.Controls.Add(this.txtWidthDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMaintainLength";
            this.Text = "FrmMaintainLength";
            this.Load += new System.EventHandler(this.FrmMaintainLength_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeletePT;
        private System.Windows.Forms.Button btnUpdatePT;
        private System.Windows.Forms.TextBox txtWidthDesc;
        private System.Windows.Forms.Label label1;
    }
}