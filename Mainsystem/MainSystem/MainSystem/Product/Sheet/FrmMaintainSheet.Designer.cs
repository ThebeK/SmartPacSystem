namespace MainSystem.Product.Sheet
{
    partial class FrmMaintainSheet
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblSheet = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 60);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(349, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(296, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 33;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(63, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Maintain Sheet";
            // 
            // lblSheet
            // 
            this.lblSheet.AutoSize = true;
            this.lblSheet.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSheet.ForeColor = System.Drawing.Color.Red;
            this.lblSheet.Location = new System.Drawing.Point(23, 126);
            this.lblSheet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSheet.Name = "lblSheet";
            this.lblSheet.Size = new System.Drawing.Size(251, 16);
            this.lblSheet.TabIndex = 27;
            this.lblSheet.Text = "Please enter a valid sheet number";
            this.lblSheet.Visible = false;
            // 
            // btnDeletePT
            // 
            this.btnDeletePT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeletePT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeletePT.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeletePT.Location = new System.Drawing.Point(192, 161);
            this.btnDeletePT.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePT.Name = "btnDeletePT";
            this.btnDeletePT.Size = new System.Drawing.Size(116, 51);
            this.btnDeletePT.TabIndex = 26;
            this.btnDeletePT.Text = "Delete Sheet Number";
            this.btnDeletePT.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePT
            // 
            this.btnUpdatePT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdatePT.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePT.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdatePT.Location = new System.Drawing.Point(40, 161);
            this.btnUpdatePT.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePT.Name = "btnUpdatePT";
            this.btnUpdatePT.Size = new System.Drawing.Size(114, 51);
            this.btnUpdatePT.TabIndex = 25;
            this.btnUpdatePT.Text = "Update Sheet Number\r\n";
            this.btnUpdatePT.UseVisualStyleBackColor = false;
            // 
            // txtProductTypeDesc
            // 
            this.txtProductTypeDesc.Location = new System.Drawing.Point(192, 92);
            this.txtProductTypeDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductTypeDesc.Multiline = true;
            this.txtProductTypeDesc.Name = "txtProductTypeDesc";
            this.txtProductTypeDesc.Size = new System.Drawing.Size(85, 30);
            this.txtProductTypeDesc.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product Sheet Number";
            // 
            // FrmMaintainSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(413, 226);
            this.Controls.Add(this.lblSheet);
            this.Controls.Add(this.btnDeletePT);
            this.Controls.Add(this.btnUpdatePT);
            this.Controls.Add(this.txtProductTypeDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMaintainSheet";
            this.Text = "FrmMaintainSheet";
            this.Load += new System.EventHandler(this.FrmMaintainSheet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblSheet;
        private System.Windows.Forms.Button btnDeletePT;
        private System.Windows.Forms.Button btnUpdatePT;
        private System.Windows.Forms.TextBox txtProductTypeDesc;
        private System.Windows.Forms.Label label1;
    }
}