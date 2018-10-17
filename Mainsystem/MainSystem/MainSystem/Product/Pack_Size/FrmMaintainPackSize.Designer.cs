namespace MainSystem.Products.Pack_Size
{
    partial class FrmMaintainPackSize
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
            this.lblPackSi = new System.Windows.Forms.Label();
            this.btnDeleteSheet = new System.Windows.Forms.Button();
            this.btnUpdateSheet = new System.Windows.Forms.Button();
            this.txtProductSheetDesc = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(433, 58);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 34);
            this.label3.TabIndex = 32;
            this.label3.Text = "Maintain Pack Size";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(379, 3);
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
            this.button5.Location = new System.Drawing.Point(326, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 31;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblPackSi
            // 
            this.lblPackSi.AutoSize = true;
            this.lblPackSi.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPackSi.ForeColor = System.Drawing.Color.Red;
            this.lblPackSi.Location = new System.Drawing.Point(62, 100);
            this.lblPackSi.Name = "lblPackSi";
            this.lblPackSi.Size = new System.Drawing.Size(220, 16);
            this.lblPackSi.TabIndex = 23;
            this.lblPackSi.Text = "Please enter a valid Pack Size";
            this.lblPackSi.Visible = false;
            // 
            // btnDeleteSheet
            // 
            this.btnDeleteSheet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeleteSheet.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSheet.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteSheet.Location = new System.Drawing.Point(222, 128);
            this.btnDeleteSheet.Name = "btnDeleteSheet";
            this.btnDeleteSheet.Size = new System.Drawing.Size(77, 62);
            this.btnDeleteSheet.TabIndex = 22;
            this.btnDeleteSheet.Text = "Delete Pack Size";
            this.btnDeleteSheet.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSheet
            // 
            this.btnUpdateSheet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdateSheet.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateSheet.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateSheet.Location = new System.Drawing.Point(131, 128);
            this.btnUpdateSheet.Name = "btnUpdateSheet";
            this.btnUpdateSheet.Size = new System.Drawing.Size(76, 62);
            this.btnUpdateSheet.TabIndex = 21;
            this.btnUpdateSheet.Text = "Update Pack SIze";
            this.btnUpdateSheet.UseVisualStyleBackColor = false;
            // 
            // txtProductSheetDesc
            // 
            this.txtProductSheetDesc.Location = new System.Drawing.Point(191, 72);
            this.txtProductSheetDesc.Multiline = true;
            this.txtProductSheetDesc.Name = "txtProductSheetDesc";
            this.txtProductSheetDesc.Size = new System.Drawing.Size(78, 25);
            this.txtProductSheetDesc.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(54, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Products Pack Size ";
            // 
            // FrmMaintainPackSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(433, 208);
            this.Controls.Add(this.lblPackSi);
            this.Controls.Add(this.btnDeleteSheet);
            this.Controls.Add(this.btnUpdateSheet);
            this.Controls.Add(this.txtProductSheetDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMaintainPackSize";
            this.Text = "FrmMaintainPackSize";
            this.Load += new System.EventHandler(this.FrmMaintainPackSize_Load);
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
        private System.Windows.Forms.Label lblPackSi;
        private System.Windows.Forms.Button btnDeleteSheet;
        private System.Windows.Forms.Button btnUpdateSheet;
        private System.Windows.Forms.TextBox txtProductSheetDesc;
        private System.Windows.Forms.Label label1;
    }
}