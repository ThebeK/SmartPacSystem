namespace MainSystem.Products.Length
{
    partial class FrmSearchLength
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchLength = new System.Windows.Forms.TextBox();
            this.dgvLength = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLength)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 54);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(470, 3);
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
            this.button5.Location = new System.Drawing.Point(417, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 29;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "Search Length";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.btnMaintain);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearchLength);
            this.panel2.Controls.Add(this.dgvLength);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 257);
            this.panel2.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.Red;
            this.lblSearch.Location = new System.Drawing.Point(176, 42);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(186, 16);
            this.lblSearch.TabIndex = 63;
            this.lblSearch.Text = "Please enter valid length";
            this.lblSearch.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.Silver;
            this.lbl.Location = new System.Drawing.Point(9, 16);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(164, 16);
            this.lbl.TabIndex = 62;
            this.lbl.Text = "Please Specify Length";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // btnMaintain
            // 
            this.btnMaintain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMaintain.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMaintain.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnMaintain.Location = new System.Drawing.Point(348, 203);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(80, 33);
            this.btnMaintain.TabIndex = 61;
            this.btnMaintain.Text = "Maintain";
            this.btnMaintain.UseVisualStyleBackColor = false;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(353, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchLength
            // 
            this.txtSearchLength.Location = new System.Drawing.Point(179, 19);
            this.txtSearchLength.Name = "txtSearchLength";
            this.txtSearchLength.Size = new System.Drawing.Size(168, 27);
            this.txtSearchLength.TabIndex = 59;
            this.txtSearchLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchLength_KeyPress);
            // 
            // dgvLength
            // 
            this.dgvLength.AllowUserToAddRows = false;
            this.dgvLength.AllowUserToDeleteRows = false;
            this.dgvLength.AllowUserToResizeColumns = false;
            this.dgvLength.AllowUserToResizeRows = false;
            this.dgvLength.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLength.Location = new System.Drawing.Point(105, 71);
            this.dgvLength.Name = "dgvLength";
            this.dgvLength.Size = new System.Drawing.Size(323, 126);
            this.dgvLength.TabIndex = 58;
            // 
            // FrmSearchLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(524, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearchLength";
            this.Text = "FrmSearchLength";
            this.Load += new System.EventHandler(this.FrmSearchLength_Load);
            this.Leave += new System.EventHandler(this.FrmSearchLength_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchLength;
        private System.Windows.Forms.DataGridView dgvLength;
    }
}