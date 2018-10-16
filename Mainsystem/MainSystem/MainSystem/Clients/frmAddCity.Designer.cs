namespace MainSystem
{
    partial class frmAddCity
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
            this.txtctyName = new System.Windows.Forms.TextBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.btnAddCty = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtctyName
            // 
            this.txtctyName.Location = new System.Drawing.Point(171, 86);
            this.txtctyName.Multiline = true;
            this.txtctyName.Name = "txtctyName";
            this.txtctyName.Size = new System.Drawing.Size(191, 32);
            this.txtctyName.TabIndex = 14;
            // 
            // cbProvince
            // 
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(171, 48);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(191, 21);
            this.cbProvince.TabIndex = 13;
            // 
            // btnAddCty
            // 
            this.btnAddCty.Location = new System.Drawing.Point(283, 135);
            this.btnAddCty.Name = "btnAddCty";
            this.btnAddCty.Size = new System.Drawing.Size(79, 35);
            this.btnAddCty.TabIndex = 12;
            this.btnAddCty.Text = "Add City";
            this.btnAddCty.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "City Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Province";
            // 
            // frmAddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 184);
            this.Controls.Add(this.txtctyName);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.btnAddCty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddCity";
            this.Text = "frmAddCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtctyName;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.Button btnAddCty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}