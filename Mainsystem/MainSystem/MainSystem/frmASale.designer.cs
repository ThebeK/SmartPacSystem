namespace MainSystem
{
    partial class frmASale
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVATPercentage = new System.Windows.Forms.Label();
            this.lblSaleIncludVAT = new System.Windows.Forms.Label();
            this.lblSaleExludedVAT = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.cbxProductDesc = new System.Windows.Forms.ComboBox();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 49);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(851, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(798, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 12;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(309, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Make Sale";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 444);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVATPercentage);
            this.groupBox2.Controls.Add(this.lblSaleIncludVAT);
            this.groupBox2.Controls.Add(this.lblSaleExludedVAT);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(0, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Information";
            // 
            // lblVATPercentage
            // 
            this.lblVATPercentage.AutoSize = true;
            this.lblVATPercentage.Location = new System.Drawing.Point(30, 146);
            this.lblVATPercentage.Name = "lblVATPercentage";
            this.lblVATPercentage.Size = new System.Drawing.Size(99, 16);
            this.lblVATPercentage.TabIndex = 2;
            this.lblVATPercentage.Text = "VAT (15%): R";
            // 
            // lblSaleIncludVAT
            // 
            this.lblSaleIncludVAT.AutoSize = true;
            this.lblSaleIncludVAT.Location = new System.Drawing.Point(21, 101);
            this.lblSaleIncludVAT.Name = "lblSaleIncludVAT";
            this.lblSaleIncludVAT.Size = new System.Drawing.Size(181, 16);
            this.lblSaleIncludVAT.TabIndex = 1;
            this.lblSaleIncludVAT.Text = "Total (Including VAT) :R";
            // 
            // lblSaleExludedVAT
            // 
            this.lblSaleExludedVAT.AutoSize = true;
            this.lblSaleExludedVAT.Location = new System.Drawing.Point(18, 51);
            this.lblSaleExludedVAT.Name = "lblSaleExludedVAT";
            this.lblSaleExludedVAT.Size = new System.Drawing.Size(184, 16);
            this.lblSaleExludedVAT.TabIndex = 0;
            this.lblSaleExludedVAT.Text = "Total (excluding VAT) :R";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.btnAddSale);
            this.groupBox1.Controls.Add(this.txtProdID);
            this.groupBox1.Controls.Add(this.cbxProductDesc);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtSaleID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(159, 175);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(123, 27);
            this.txtQuantity.TabIndex = 11;
            // 
            // btnAddSale
            // 
            this.btnAddSale.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddSale.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddSale.Location = new System.Drawing.Point(315, 179);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(75, 27);
            this.btnAddSale.TabIndex = 10;
            this.btnAddSale.Text = "Add";
            this.btnAddSale.UseVisualStyleBackColor = false;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(159, 101);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(123, 27);
            this.txtProdID.TabIndex = 8;
            // 
            // cbxProductDesc
            // 
            this.cbxProductDesc.DataSource = this.productBindingSource1;
            this.cbxProductDesc.DisplayMember = "Product_Description";
            this.cbxProductDesc.FormattingEnabled = true;
            this.cbxProductDesc.Location = new System.Drawing.Point(159, 59);
            this.cbxProductDesc.Name = "cbxProductDesc";
            this.cbxProductDesc.Size = new System.Drawing.Size(192, 24);
            this.cbxProductDesc.TabIndex = 7;
            this.cbxProductDesc.ValueMember = "Product_ID";
            this.cbxProductDesc.SelectedIndexChanged += new System.EventHandler(this.cbxProductDesc_SelectedIndexChanged);
            this.cbxProductDesc.TextChanged += new System.EventHandler(this.cbxProductDesc_TextChanged);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(MainSystem.Product);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(159, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 27);
            this.txtPrice.TabIndex = 6;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Location = new System.Drawing.Point(159, 24);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(123, 27);
            this.txtSaleID.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(40, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(35, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sale Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(33, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "ProductID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(30, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Select Products";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(33, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "SaleID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(MainSystem.Product);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.dgvSale);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(401, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 444);
            this.panel3.TabIndex = 2;
            // 
            // dgvSale
            // 
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSale.Location = new System.Drawing.Point(0, 0);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.Size = new System.Drawing.Size(504, 217);
            this.dgvSale.TabIndex = 0;
            this.dgvSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnPrintInvoice);
            this.panel4.Controls.Add(this.btnConfirm);
            this.panel4.Controls.Add(this.txtCash);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 227);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Location = new System.Drawing.Point(41, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteSale_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrintInvoice.Location = new System.Drawing.Point(170, 181);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(111, 34);
            this.btnPrintInvoice.TabIndex = 10;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConfirm.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnConfirm.Location = new System.Drawing.Point(304, 181);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 34);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(244, 44);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(155, 56);
            this.txtCash.TabIndex = 6;
            this.txtCash.Text = "";
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(192, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Please enter a valid amount";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(192, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cash";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmASale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 493);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmASale";
            this.Text = "frmASale";
            this.Load += new System.EventHandler(this.frmASale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtCash;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.ComboBox cbxProductDesc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVATPercentage;
        private System.Windows.Forms.Label lblSaleIncludVAT;
        private System.Windows.Forms.Label lblSaleExludedVAT;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
       // private SPDataSet5 sPDataSet5;
        //private SPDataSet5TableAdapters.ProductTableAdapter productTableAdapter;
        //private SPDataSet6 sPDataSet6;
       // private SPDataSet6TableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
    }
}