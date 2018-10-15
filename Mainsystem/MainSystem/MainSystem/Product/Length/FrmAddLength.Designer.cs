namespace MainSystem.Products.Length
{
    partial class FrmAddLength
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtMeasurement = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLengthDescription = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(309, 64);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(243, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(190, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 29;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 31);
            this.label3.TabIndex = 39;
            this.label3.Text = "Add Length";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUnit);
            this.panel2.Controls.Add(this.lblLength);
            this.panel2.Controls.Add(this.txtMeasurement);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtLengthDescription);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 180);
            this.panel2.TabIndex = 1;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUnit.ForeColor = System.Drawing.Color.Red;
            this.lblUnit.Location = new System.Drawing.Point(76, 99);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(182, 16);
            this.lblUnit.TabIndex = 47;
            this.lblUnit.Text = "Please enter a valid unit";
            this.lblUnit.Visible = false;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLength.ForeColor = System.Drawing.Color.Red;
            this.lblLength.Location = new System.Drawing.Point(76, 51);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(186, 16);
            this.lblLength.TabIndex = 46;
            this.lblLength.Text = "Please enter valid length";
            this.lblLength.Visible = false;
            // 
            // txtMeasurement
            // 
            this.txtMeasurement.Location = new System.Drawing.Point(76, 70);
            this.txtMeasurement.Name = "txtMeasurement";
            this.txtMeasurement.Size = new System.Drawing.Size(82, 22);
            this.txtMeasurement.TabIndex = 45;
            this.txtMeasurement.Text = "";
            this.txtMeasurement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeasurement_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Unit";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.Location = new System.Drawing.Point(160, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 41);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Length";
            // 
            // txtLengthDescription
            // 
            this.txtLengthDescription.Location = new System.Drawing.Point(79, 23);
            this.txtLengthDescription.Name = "txtLengthDescription";
            this.txtLengthDescription.Size = new System.Drawing.Size(82, 22);
            this.txtLengthDescription.TabIndex = 41;
            this.txtLengthDescription.Text = "";
            this.txtLengthDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLengthDescription_KeyPress);
            // 
            // FrmAddLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(309, 244);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddLength";
            this.Text = "FrmAddLength";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.RichTextBox txtMeasurement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtLengthDescription;
    }
}