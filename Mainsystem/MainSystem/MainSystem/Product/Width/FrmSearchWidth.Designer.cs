namespace MainSystem.Products.Width
{
    partial class FrmSearchWidth
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
            this.lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.txtSearchWidth = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvWidth = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWidth)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(525, 48);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(451, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(398, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 67;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 34);
            this.label1.TabIndex = 53;
            this.label1.Text = "Search Width ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 300);
            this.panel2.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.Silver;
            this.lbl.Location = new System.Drawing.Point(3, 76);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(156, 16);
            this.lbl.TabIndex = 59;
            this.lbl.Text = "Please Specify Width";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblWidth);
            this.panel3.Controls.Add(this.btnMaintain);
            this.panel3.Controls.Add(this.txtSearchWidth);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.dgvWidth);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(157, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 300);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblWidth.ForeColor = System.Drawing.Color.Red;
            this.lblWidth.Location = new System.Drawing.Point(3, 238);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(246, 16);
            this.lblWidth.TabIndex = 60;
            this.lblWidth.Text = "Please enter a valid a valid width";
            this.lblWidth.Visible = false;
            // 
            // btnMaintain
            // 
            this.btnMaintain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMaintain.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMaintain.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnMaintain.Location = new System.Drawing.Point(253, 258);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(84, 31);
            this.btnMaintain.TabIndex = 58;
            this.btnMaintain.Text = "Maintain";
            this.btnMaintain.UseVisualStyleBackColor = false;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // txtSearchWidth
            // 
            this.txtSearchWidth.Location = new System.Drawing.Point(11, 69);
            this.txtSearchWidth.Name = "txtSearchWidth";
            this.txtSearchWidth.Size = new System.Drawing.Size(58, 20);
            this.txtSearchWidth.TabIndex = 56;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(75, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvWidth
            // 
            this.dgvWidth.AllowUserToAddRows = false;
            this.dgvWidth.AllowUserToDeleteRows = false;
            this.dgvWidth.AllowUserToResizeColumns = false;
            this.dgvWidth.AllowUserToResizeRows = false;
            this.dgvWidth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWidth.Location = new System.Drawing.Point(0, 98);
            this.dgvWidth.Name = "dgvWidth";
            this.dgvWidth.Size = new System.Drawing.Size(323, 126);
            this.dgvWidth.TabIndex = 55;
            // 
            // FrmSearchWidth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(525, 348);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSearchWidth";
            this.Text = "FrmSearchWidth";
            this.Leave += new System.EventHandler(this.FrmSearchWidth_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.TextBox txtSearchWidth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvWidth;
    }
}