namespace MainSystem.Products
{
    partial class FrmMaintainProductType
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
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProdType = new System.Windows.Forms.Label();
            this.btnDeletePT = new System.Windows.Forms.Button();
            this.btnUpdatePT = new System.Windows.Forms.Button();
            this.txtProductTypeDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 54);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(387, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 62;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(27, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 34);
            this.label2.TabIndex = 59;
            this.label2.Text = "Maintain Products Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(440, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblProdType
            // 
            this.lblProdType.AutoSize = true;
            this.lblProdType.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProdType.ForeColor = System.Drawing.Color.Red;
            this.lblProdType.Location = new System.Drawing.Point(51, 141);
            this.lblProdType.Name = "lblProdType";
            this.lblProdType.Size = new System.Drawing.Size(332, 16);
            this.lblProdType.TabIndex = 60;
            this.lblProdType.Text = "Please enter a valid product type description";
            this.lblProdType.Visible = false;
            // 
            // btnDeletePT
            // 
            this.btnDeletePT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeletePT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeletePT.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeletePT.Location = new System.Drawing.Point(239, 195);
            this.btnDeletePT.Name = "btnDeletePT";
            this.btnDeletePT.Size = new System.Drawing.Size(83, 61);
            this.btnDeletePT.TabIndex = 58;
            this.btnDeletePT.Text = "Delete Products Type";
            this.btnDeletePT.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePT
            // 
            this.btnUpdatePT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdatePT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePT.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdatePT.Location = new System.Drawing.Point(89, 195);
            this.btnUpdatePT.Name = "btnUpdatePT";
            this.btnUpdatePT.Size = new System.Drawing.Size(90, 61);
            this.btnUpdatePT.TabIndex = 57;
            this.btnUpdatePT.Text = "Update Products Type";
            this.btnUpdatePT.UseVisualStyleBackColor = false;
            // 
            // txtProductTypeDesc
            // 
            this.txtProductTypeDesc.Location = new System.Drawing.Point(54, 95);
            this.txtProductTypeDesc.Multiline = true;
            this.txtProductTypeDesc.Name = "txtProductTypeDesc";
            this.txtProductTypeDesc.Size = new System.Drawing.Size(283, 43);
            this.txtProductTypeDesc.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Products type description";
            // 
            // FrmMaintainProductType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(499, 292);
            this.Controls.Add(this.lblProdType);
            this.Controls.Add(this.btnDeletePT);
            this.Controls.Add(this.btnUpdatePT);
            this.Controls.Add(this.txtProductTypeDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMaintainProductType";
            this.Text = "FrmMaintainProductType";
            this.Load += new System.EventHandler(this.FrmMaintainProductType_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProdType;
        private System.Windows.Forms.Button btnDeletePT;
        private System.Windows.Forms.Button btnUpdatePT;
        private System.Windows.Forms.TextBox txtProductTypeDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}