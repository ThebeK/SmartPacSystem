namespace MainSystem.Products.Brand
{
    partial class FrmSearchBrand
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.txtSearchBrand = new System.Windows.Forms.TextBox();
            this.lblSearchBrand = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBrand = new System.Windows.Forms.DataGridView();
            this.productBrandIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBrandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPDataSet = new MainSystem.SPDataSet();
           // this.product_BrandTableAdapter = new MainSystem.SPDataSetTableAdapters.Product_BrandTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDataSet)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(533, 59);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(470, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(420, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 63;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 34);
            this.label1.TabIndex = 61;
            this.label1.Text = "Search Brand";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 287);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.Silver;
            this.lbl.Location = new System.Drawing.Point(42, 41);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(155, 16);
            this.lbl.TabIndex = 59;
            this.lbl.Text = "Please Specify Brand";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMaintain);
            this.panel3.Controls.Add(this.txtSearchBrand);
            this.panel3.Controls.Add(this.lblSearchBrand);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.dgvBrand);
            this.panel3.Location = new System.Drawing.Point(206, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 287);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnMaintain
            // 
            this.btnMaintain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMaintain.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMaintain.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnMaintain.Location = new System.Drawing.Point(181, 244);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(102, 40);
            this.btnMaintain.TabIndex = 58;
            this.btnMaintain.Text = "Maintain";
            this.btnMaintain.UseVisualStyleBackColor = false;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // txtSearchBrand
            // 
            this.txtSearchBrand.Location = new System.Drawing.Point(3, 38);
            this.txtSearchBrand.Name = "txtSearchBrand";
            this.txtSearchBrand.Size = new System.Drawing.Size(199, 27);
            this.txtSearchBrand.TabIndex = 56;
            this.txtSearchBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBrand_KeyPress);
            // 
            // lblSearchBrand
            // 
            this.lblSearchBrand.AutoSize = true;
            this.lblSearchBrand.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSearchBrand.ForeColor = System.Drawing.Color.Red;
            this.lblSearchBrand.Location = new System.Drawing.Point(41, 74);
            this.lblSearchBrand.Name = "lblSearchBrand";
            this.lblSearchBrand.Size = new System.Drawing.Size(181, 16);
            this.lblSearchBrand.TabIndex = 60;
            this.lblSearchBrand.Text = "Please enter valid brand";
            this.lblSearchBrand.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(208, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBrand
            // 
            this.dgvBrand.AllowUserToAddRows = false;
            this.dgvBrand.AllowUserToDeleteRows = false;
            this.dgvBrand.AllowUserToResizeColumns = false;
            this.dgvBrand.AllowUserToResizeRows = false;
            this.dgvBrand.AutoGenerateColumns = false;
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productBrandIDDataGridViewTextBoxColumn,
            this.productBrandNameDataGridViewTextBoxColumn});
            this.dgvBrand.DataSource = this.productBrandBindingSource;
            this.dgvBrand.Location = new System.Drawing.Point(21, 96);
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.Size = new System.Drawing.Size(240, 126);
            this.dgvBrand.TabIndex = 55;
            // 
            // productBrandIDDataGridViewTextBoxColumn
            // 
            this.productBrandIDDataGridViewTextBoxColumn.DataPropertyName = "Product_Brand_ID";
            this.productBrandIDDataGridViewTextBoxColumn.HeaderText = "Product_Brand_ID";
            this.productBrandIDDataGridViewTextBoxColumn.Name = "productBrandIDDataGridViewTextBoxColumn";
            this.productBrandIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBrandNameDataGridViewTextBoxColumn
            // 
            this.productBrandNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Brand_Name";
            this.productBrandNameDataGridViewTextBoxColumn.HeaderText = "Product_Brand_Name";
            this.productBrandNameDataGridViewTextBoxColumn.Name = "productBrandNameDataGridViewTextBoxColumn";
            // 
            // productBrandBindingSource
            // 
            this.productBrandBindingSource.DataMember = "Product_Brand";
            this.productBrandBindingSource.DataSource = this.sPDataSet;
            // 
            // sPDataSet
            // 
            this.sPDataSet.DataSetName = "SPDataSet";
            this.sPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_BrandTableAdapter
            // 
          //  this.product_BrandTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSearchBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(533, 353);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearchBrand";
            this.Text = "FrmSearchBrand";
            this.Load += new System.EventHandler(this.FrmSearchBrand_Load);
            this.Leave += new System.EventHandler(this.FrmSearchBrand_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.TextBox txtSearchBrand;
        private System.Windows.Forms.Label lblSearchBrand;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBrand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private SPDataSet sPDataSet;
        private System.Windows.Forms.BindingSource productBrandBindingSource;
        //private SPDataSetTableAdapters.Product_BrandTableAdapter product_BrandTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBrandIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBrandNameDataGridViewTextBoxColumn;
    }
}