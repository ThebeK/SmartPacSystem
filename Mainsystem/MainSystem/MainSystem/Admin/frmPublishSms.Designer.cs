namespace MainSystem.Admin
{
    partial class frmPublishSms
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btnSendSms = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SelectRemove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTelephoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(386, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 35);
            this.label5.TabIndex = 22;
            this.label5.Text = "Publish SMS Notification";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientTelephoneDataGridViewTextBoxColumn,
            this.Select});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 190);
            this.dataGridView1.TabIndex = 23;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.clientNameDataGridViewTextBoxColumn1,
            this.clientTelephoneDataGridViewTextBoxColumn1,
            this.SelectRemove});
            this.dataGridView2.DataSource = this.clientBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(674, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(443, 190);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txt_message
            // 
            this.txt_message.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.txt_message.Location = new System.Drawing.Point(172, 292);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_message.Size = new System.Drawing.Size(957, 110);
            this.txt_message.TabIndex = 27;
            // 
            // btnSendSms
            // 
            this.btnSendSms.Location = new System.Drawing.Point(1034, 425);
            this.btnSendSms.Name = "btnSendSms";
            this.btnSendSms.Size = new System.Drawing.Size(95, 31);
            this.btnSendSms.TabIndex = 28;
            this.btnSendSms.Text = "Send SMS";
            this.btnSendSms.UseVisualStyleBackColor = true;
            this.btnSendSms.Click += new System.EventHandler(this.btnSendSms_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Selected Message";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(519, 93);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 31;
            this.BtnAdd.Text = "Add to list";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(519, 168);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 41);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "Remove from list";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // SelectRemove
            // 
            this.SelectRemove.HeaderText = "Select";
            this.SelectRemove.Name = "SelectRemove";
            this.SelectRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Recipients";
            this.label1.Visible = false;
            // 
            // txt_to
            // 
            this.txt_to.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.txt_to.Location = new System.Drawing.Point(15, 405);
            this.txt_to.Name = "txt_to";
            this.txt_to.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_to.Size = new System.Drawing.Size(30, 32);
            this.txt_to.TabIndex = 26;
            this.txt_to.Visible = false;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client_ID";
            this.Client.HeaderText = "Client ID";
            this.Client.Name = "Client";
            // 
            // clientNameDataGridViewTextBoxColumn1
            // 
            this.clientNameDataGridViewTextBoxColumn1.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn1.HeaderText = "Client Name";
            this.clientNameDataGridViewTextBoxColumn1.Name = "clientNameDataGridViewTextBoxColumn1";
            // 
            // clientTelephoneDataGridViewTextBoxColumn1
            // 
            this.clientTelephoneDataGridViewTextBoxColumn1.DataPropertyName = "Client_Telephone";
            this.clientTelephoneDataGridViewTextBoxColumn1.HeaderText = "Client Telephone";
            this.clientTelephoneDataGridViewTextBoxColumn1.Name = "clientTelephoneDataGridViewTextBoxColumn1";
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
            // frmPublishSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 468);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendSms);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Name = "frmPublishSms";
            this.Text = "frmPublishSms";
            this.Load += new System.EventHandler(this.frmPublishSms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btnSendSms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTelephoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectRemove;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_to;
    }
}