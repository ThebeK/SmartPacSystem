namespace MainSystem.Admin
{
    partial class frmPunblblishSms
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColRight = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSend = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(519, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(519, 169);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 35);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientTelephoneDataGridViewTextBoxColumn,
            this.ColSelect});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 175);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ColRight});
            this.dataGridView2.DataSource = this.clientBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(684, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(445, 175);
            this.dataGridView2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 244);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(960, 122);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 382);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 28);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Message in the SMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Publish SMS Notification";
            // 
            // ColSelect
            // 
            this.ColSelect.HeaderText = "Select";
            this.ColSelect.Name = "ColSelect";
            // 
            // ColRight
            // 
            this.ColRight.HeaderText = "Select";
            this.ColRight.Name = "ColRight";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1058, 371);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(71, 41);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send SMS";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client_ID";
            this.Client.HeaderText = "Client ID";
            this.Client.Name = "Client";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Client_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Client Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Client_Telephone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Client Telephone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataSource = typeof(MainSystem.Client);
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientTelephoneDataGridViewTextBoxColumn
            // 
            this.clientTelephoneDataGridViewTextBoxColumn.DataPropertyName = "Client_Telephone";
            this.clientTelephoneDataGridViewTextBoxColumn.HeaderText = "Client Telephone";
            this.clientTelephoneDataGridViewTextBoxColumn.Name = "clientTelephoneDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(MainSystem.Client);
            // 
            // frmPunblblishSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 422);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmPunblblishSms";
            this.Text = "frmPunblblishSms";
            this.Load += new System.EventHandler(this.frmPunblblishSms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColRight;
        private System.Windows.Forms.Button btnSend;
    }
}