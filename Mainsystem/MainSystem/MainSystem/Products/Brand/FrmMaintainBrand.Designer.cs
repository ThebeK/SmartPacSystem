namespace MainSystem.Products.Brand
{
    partial class FrmMaintainBrand
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePT = new System.Windows.Forms.Button();
            this.btnDeletePT = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBrandDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(90, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Product Brand Description";
            // 
            // btnUpdatePT
            // 
            this.btnUpdatePT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdatePT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePT.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdatePT.Location = new System.Drawing.Point(93, 180);
            this.btnUpdatePT.Name = "btnUpdatePT";
            this.btnUpdatePT.Size = new System.Drawing.Size(91, 61);
            this.btnUpdatePT.TabIndex = 57;
            this.btnUpdatePT.Text = "Update Product Brand";
            this.btnUpdatePT.UseVisualStyleBackColor = false;
            // 
            // btnDeletePT
            // 
            this.btnDeletePT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeletePT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeletePT.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeletePT.Location = new System.Drawing.Point(274, 180);
            this.btnDeletePT.Name = "btnDeletePT";
            this.btnDeletePT.Size = new System.Drawing.Size(106, 61);
            this.btnDeletePT.TabIndex = 58;
            this.btnDeletePT.Text = "Delete Product Brand";
            this.btnDeletePT.UseVisualStyleBackColor = false;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.Red;
            this.lblBrand.Location = new System.Drawing.Point(107, 138);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(181, 16);
            this.lblBrand.TabIndex = 59;
            this.lblBrand.Text = "Please enter valid brand";
            this.lblBrand.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBrand);
            this.panel2.Controls.Add(this.btnDeletePT);
            this.panel2.Controls.Add(this.btnUpdatePT);
            this.panel2.Controls.Add(this.txtBrandDesc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 268);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtBrandDesc
            // 
            this.txtBrandDesc.Location = new System.Drawing.Point(93, 50);
            this.txtBrandDesc.Multiline = true;
            this.txtBrandDesc.Name = "txtBrandDesc";
            this.txtBrandDesc.Size = new System.Drawing.Size(287, 85);
            this.txtBrandDesc.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(103, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 34);
            this.label2.TabIndex = 60;
            this.label2.Text = "Maintain Brand";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 44);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(420, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(370, -2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 61;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmMaintainBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(472, 312);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMaintainBrand";
            this.Text = "FrmMaintainBrand";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatePT;
        private System.Windows.Forms.Button btnDeletePT;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBrandDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
    }
}