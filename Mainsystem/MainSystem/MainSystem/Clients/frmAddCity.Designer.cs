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
            this.components = new System.ComponentModel.Container();
            this.txtctyName = new System.Windows.Forms.TextBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddCty = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtctyName
            // 
            this.txtctyName.Location = new System.Drawing.Point(171, 108);
            this.txtctyName.Multiline = true;
            this.txtctyName.Name = "txtctyName";
            this.txtctyName.Size = new System.Drawing.Size(191, 32);
            this.txtctyName.TabIndex = 14;
            // 
            // cbProvince
            // 
            this.cbProvince.DataSource = this.provinceBindingSource;
            this.cbProvince.DisplayMember = "Province_Name";
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(171, 70);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(191, 21);
            this.cbProvince.TabIndex = 13;
            this.cbProvince.ValueMember = "Province_Id";
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(MainSystem.Province);
            // 
            // btnAddCty
            // 
            this.btnAddCty.Location = new System.Drawing.Point(283, 146);
            this.btnAddCty.Name = "btnAddCty";
            this.btnAddCty.Size = new System.Drawing.Size(79, 35);
            this.btnAddCty.TabIndex = 12;
            this.btnAddCty.Text = "Add City";
            this.btnAddCty.UseVisualStyleBackColor = true;
            this.btnAddCty.Click += new System.EventHandler(this.btnAddCty_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "City Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Province";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Add City";
            // 
            // frmAddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 191);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtctyName);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.btnAddCty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddCity";
            this.Text = "frmAddCity";
            this.Load += new System.EventHandler(this.frmAddCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtctyName;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.Button btnAddCty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.Label label3;
    }
}