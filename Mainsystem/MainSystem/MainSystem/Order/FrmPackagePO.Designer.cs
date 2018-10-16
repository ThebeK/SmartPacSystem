namespace MainSystem.Order
{
    partial class FrmPackagePO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPackagePO));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvPackaged = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadPurchaseOrder1ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pONumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackaged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPurchaseOrder1ResultBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(791, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Location = new System.Drawing.Point(684, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 31;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package Of Purchase Order";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 384);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.btnContinue);
            this.tabPage1.Controls.Add(this.btnGenerateQR);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Placed Orders";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnContinue.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnContinue.Location = new System.Drawing.Point(643, 249);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(104, 55);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Continue>>";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGenerateQR.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGenerateQR.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerateQR.Location = new System.Drawing.Point(475, 249);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(143, 55);
            this.btnGenerateQR.TabIndex = 8;
            this.btnGenerateQR.Text = "Generate QR Codes";
            this.btnGenerateQR.UseVisualStyleBackColor = false;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pONumberDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn,
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn,
            this.sONumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loadPurchaseOrder1ResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dgvPackaged);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Packaged Orders";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Location = new System.Drawing.Point(652, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Done";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Location = new System.Drawing.Point(480, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 47);
            this.button4.TabIndex = 2;
            this.button4.Text = "Scan QR Code";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvPackaged
            // 
            this.dgvPackaged.AllowUserToAddRows = false;
            this.dgvPackaged.AllowUserToDeleteRows = false;
            this.dgvPackaged.AllowUserToResizeColumns = false;
            this.dgvPackaged.AllowUserToResizeRows = false;
            this.dgvPackaged.AutoGenerateColumns = false;
            this.dgvPackaged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackaged.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pONumberDataGridViewTextBoxColumn1,
            this.clientNameDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn1,
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn1,
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn1,
            this.sONumberDataGridViewTextBoxColumn1});
            this.dgvPackaged.DataSource = this.loadPurchaseOrder1ResultBindingSource;
            this.dgvPackaged.Location = new System.Drawing.Point(7, 6);
            this.dgvPackaged.Name = "dgvPackaged";
            this.dgvPackaged.Size = new System.Drawing.Size(757, 221);
            this.dgvPackaged.TabIndex = 1;
            this.dgvPackaged.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackaged_CellClick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(737, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 43);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pONumberDataGridViewTextBoxColumn
            // 
            this.pONumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pONumberDataGridViewTextBoxColumn.DataPropertyName = "PO_Number";
            this.pONumberDataGridViewTextBoxColumn.HeaderText = "PO Number";
            this.pONumberDataGridViewTextBoxColumn.Name = "pONumberDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Clients Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "Order_Date";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // purchaseOrderStatusDescriptionDataGridViewTextBoxColumn
            // 
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Order_Status_Description";
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn.HeaderText = "Status";
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn.Name = "purchaseOrderStatusDescriptionDataGridViewTextBoxColumn";
            // 
            // dispatchTypeDescriptionDataGridViewTextBoxColumn
            // 
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Dispatch_Type_Description";
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "Dispatch Type";
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn.Name = "dispatchTypeDescriptionDataGridViewTextBoxColumn";
            // 
            // sONumberDataGridViewTextBoxColumn
            // 
            this.sONumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sONumberDataGridViewTextBoxColumn.DataPropertyName = "SO_Number";
            this.sONumberDataGridViewTextBoxColumn.HeaderText = "SO Number";
            this.sONumberDataGridViewTextBoxColumn.Name = "sONumberDataGridViewTextBoxColumn";
            // 
            // loadPurchaseOrder1ResultBindingSource
            // 
            this.loadPurchaseOrder1ResultBindingSource.DataSource = typeof(MainSystem.Load_Purchase_Order_1_Result);
            // 
            // pONumberDataGridViewTextBoxColumn1
            // 
            this.pONumberDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pONumberDataGridViewTextBoxColumn1.DataPropertyName = "PO_Number";
            this.pONumberDataGridViewTextBoxColumn1.HeaderText = "PO Number";
            this.pONumberDataGridViewTextBoxColumn1.Name = "pONumberDataGridViewTextBoxColumn1";
            // 
            // clientNameDataGridViewTextBoxColumn1
            // 
            this.clientNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientNameDataGridViewTextBoxColumn1.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn1.HeaderText = "Clients Name";
            this.clientNameDataGridViewTextBoxColumn1.Name = "clientNameDataGridViewTextBoxColumn1";
            // 
            // orderDateDataGridViewTextBoxColumn1
            // 
            this.orderDateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "Order_Date";
            this.orderDateDataGridViewTextBoxColumn1.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
            // 
            // purchaseOrderStatusDescriptionDataGridViewTextBoxColumn1
            // 
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Purchase_Order_Status_Description";
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn1.Name = "purchaseOrderStatusDescriptionDataGridViewTextBoxColumn1";
            // 
            // dispatchTypeDescriptionDataGridViewTextBoxColumn1
            // 
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Dispatch_Type_Description";
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn1.HeaderText = "Dispatch Type";
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn1.Name = "dispatchTypeDescriptionDataGridViewTextBoxColumn1";
            // 
            // sONumberDataGridViewTextBoxColumn1
            // 
            this.sONumberDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sONumberDataGridViewTextBoxColumn1.DataPropertyName = "SO_Number";
            this.sONumberDataGridViewTextBoxColumn1.HeaderText = "SO Number";
            this.sONumberDataGridViewTextBoxColumn1.Name = "sONumberDataGridViewTextBoxColumn1";
            // 
            // FrmPackagePO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(791, 501);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPackagePO";
            this.Text = "FrmPackagePO";
            this.Load += new System.EventHandler(this.FrmPackagePO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackaged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPurchaseOrder1ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvPackaged;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnGenerateQR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderStatusDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatchTypeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loadPurchaseOrder1ResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderStatusDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatchTypeDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONumberDataGridViewTextBoxColumn1;
    }
}