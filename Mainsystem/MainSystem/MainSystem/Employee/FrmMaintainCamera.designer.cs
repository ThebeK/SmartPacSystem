namespace MainSystem
{
    partial class FrmMaintainCamera
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pbpicture = new System.Windows.Forms.PictureBox();
            this.pi = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbpicture);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 416);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStop.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.Aqua;
            this.btnStop.Location = new System.Drawing.Point(604, 529);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 41);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Capture";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 467);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(675, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // pbStart
            // 
            this.pbStart.Image = global::MainSystem.Properties.Resources.Power;
            this.pbStart.Location = new System.Drawing.Point(27, 520);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(47, 50);
            this.pbStart.TabIndex = 13;
            this.pbStart.TabStop = false;
            this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
            // 
            // pbpicture
            // 
            this.pbpicture.Location = new System.Drawing.Point(12, 22);
            this.pbpicture.Name = "pbpicture";
            this.pbpicture.Size = new System.Drawing.Size(663, 394);
            this.pbpicture.TabIndex = 0;
            this.pbpicture.TabStop = false;
            // 
            // pi
            // 
            this.pi.Image = global::MainSystem.Properties.Resources.Close;
            this.pi.Location = new System.Drawing.Point(695, 1);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(51, 43);
            this.pi.TabIndex = 14;
            this.pi.TabStop = false;
            this.pi.Click += new System.EventHandler(this.pi_Click);
            // 
            // FrmMaintainCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(748, 591);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmMaintainCamera";
            this.Text = "FrmMaintainCamera";
            this.Load += new System.EventHandler(this.FrmMaintainCamera_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbpicture;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pi;
    }
}