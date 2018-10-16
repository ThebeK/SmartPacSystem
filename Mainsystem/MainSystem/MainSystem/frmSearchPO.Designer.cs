namespace MainSystem.Order
{
    partial class frmSearchPO
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTermDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadPurchaseOrder1ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPurchaseOrder1ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 348);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 39);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Purchase Order Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pONumberDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.grossAmountDataGridViewTextBoxColumn,
            this.paymentTermDescriptionDataGridViewTextBoxColumn,
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn,
            this.sONumberDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn,
            this.dPNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loadPurchaseOrder1ResultBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(865, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(778, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Continue>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pONumberDataGridViewTextBoxColumn
            // 
            this.pONumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pONumberDataGridViewTextBoxColumn.DataPropertyName = "PO_Number";
            this.pONumberDataGridViewTextBoxColumn.HeaderText = "PO Number";
            this.pONumberDataGridViewTextBoxColumn.Name = "pONumberDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "Order_Date";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // grossAmountDataGridViewTextBoxColumn
            // 
            this.grossAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grossAmountDataGridViewTextBoxColumn.DataPropertyName = "Gross_Amount";
            this.grossAmountDataGridViewTextBoxColumn.HeaderText = "Gross Amount";
            this.grossAmountDataGridViewTextBoxColumn.Name = "grossAmountDataGridViewTextBoxColumn";
            // 
            // paymentTermDescriptionDataGridViewTextBoxColumn
            // 
            this.paymentTermDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paymentTermDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Payment_Term_Description";
            this.paymentTermDescriptionDataGridViewTextBoxColumn.HeaderText = "Payment Term";
            this.paymentTermDescriptionDataGridViewTextBoxColumn.Name = "paymentTermDescriptionDataGridViewTextBoxColumn";
            // 
            // purchaseOrderStatusDescriptionDataGridViewTextBoxColumn
            // 
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Order_Status_Description";
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn.HeaderText = "Status";
            this.purchaseOrderStatusDescriptionDataGridViewTextBoxColumn.Name = "purchaseOrderStatusDescriptionDataGridViewTextBoxColumn";
            // 
            // sONumberDataGridViewTextBoxColumn
            // 
            this.sONumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sONumberDataGridViewTextBoxColumn.DataPropertyName = "SO_Number";
            this.sONumberDataGridViewTextBoxColumn.HeaderText = "SO Number";
            this.sONumberDataGridViewTextBoxColumn.Name = "sONumberDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Clients Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // dispatchTypeDescriptionDataGridViewTextBoxColumn
            // 
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Dispatch_Type_Description";
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "Dispatch Type";
            this.dispatchTypeDescriptionDataGridViewTextBoxColumn.Name = "dispatchTypeDescriptionDataGridViewTextBoxColumn";
            // 
            // dPNumberDataGridViewTextBoxColumn
            // 
            this.dPNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dPNumberDataGridViewTextBoxColumn.DataPropertyName = "DP_Number";
            this.dPNumberDataGridViewTextBoxColumn.HeaderText = "DP Number";
            this.dPNumberDataGridViewTextBoxColumn.Name = "dPNumberDataGridViewTextBoxColumn";
            // 
            // loadPurchaseOrder1ResultBindingSource
            // 
            this.loadPurchaseOrder1ResultBindingSource.DataSource = typeof(MainSystem.Load_Purchase_Order_1_Result);
            // 
            // frmSearchPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "frmSearchPO";
            this.Text = "frmSearchPO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPurchaseOrder1ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource loadPurchaseOrder1ResultBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTermDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderStatusDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatchTypeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}