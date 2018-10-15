namespace MainSystem
{
    partial class frmCamera
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
            this.pbpicture = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbpicture);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 422);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera";
            // 
            // pbpicture
            // 
            this.pbpicture.Location = new System.Drawing.Point(6, 22);
            this.pbpicture.Name = "pbpicture";
            this.pbpicture.Size = new System.Drawing.Size(663, 394);
            this.pbpicture.TabIndex = 0;
            this.pbpicture.TabStop = false;
            this.pbpicture.Click += new System.EventHandler(this.pbpicture_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStop.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.Aqua;
            this.btnStop.Location = new System.Drawing.Point(596, 477);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 41);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Capture";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 443);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(675, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // pbStart
            // 
            this.pbStart.Image = global::MainSystem.Properties.Resources.Power;
            this.pbStart.Location = new System.Drawing.Point(13, 484);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(47, 50);
            this.pbStart.TabIndex = 9;
            this.pbStart.TabStop = false;
            this.pbStart.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(722, 546);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmCamera";
            this.Text = "frmCamera";
            this.Load += new System.EventHandler(this.frmCamera_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbpicture;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbStart;
    }
}