namespace RestaurantManagementSystem
{
    partial class frmOrderDetail
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lvlToDate = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrderDetail = new System.Windows.Forms.Panel();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lvlFromDate = new System.Windows.Forms.Label();
            this.lvlSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvlMsg = new System.Windows.Forms.Label();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnDays = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlOrderDetail.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(626, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 30);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Yellow;
            this.btnRefresh.Location = new System.Drawing.Point(642, 79);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 33);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // lvlToDate
            // 
            this.lvlToDate.AutoSize = true;
            this.lvlToDate.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlToDate.ForeColor = System.Drawing.Color.Yellow;
            this.lvlToDate.Location = new System.Drawing.Point(175, 54);
            this.lvlToDate.Name = "lvlToDate";
            this.lvlToDate.Size = new System.Drawing.Size(30, 20);
            this.lvlToDate.TabIndex = 11;
            this.lvlToDate.Text = "To :";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnHome.Location = new System.Drawing.Point(697, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 30);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Yellow;
            this.btnSearch.Location = new System.Drawing.Point(334, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 30);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search Order";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.tableName,
            this.empId,
            this.date,
            this.totalBill});
            this.dgvOrder.Location = new System.Drawing.Point(12, 154);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(760, 294);
            this.dgvOrder.TabIndex = 17;
            // 
            // orderId
            // 
            this.orderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderId.DataPropertyName = "orderId";
            this.orderId.HeaderText = "Id";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // tableName
            // 
            this.tableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableName.DataPropertyName = "tableName";
            this.tableName.HeaderText = "Table Name";
            this.tableName.Name = "tableName";
            this.tableName.ReadOnly = true;
            // 
            // empId
            // 
            this.empId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empId.DataPropertyName = "empId";
            this.empId.HeaderText = "Employee ID";
            this.empId.Name = "empId";
            this.empId.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // totalBill
            // 
            this.totalBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalBill.DataPropertyName = "totalBill";
            this.totalBill.HeaderText = "Total Amount";
            this.totalBill.Name = "totalBill";
            this.totalBill.ReadOnly = true;
            // 
            // pnlOrderDetail
            // 
            this.pnlOrderDetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlOrderDetail.Controls.Add(this.btnDays);
            this.pnlOrderDetail.Controls.Add(this.btnWeek);
            this.pnlOrderDetail.Controls.Add(this.btnMonth);
            this.pnlOrderDetail.Controls.Add(this.pnlDate);
            this.pnlOrderDetail.Controls.Add(this.lvlSearch);
            this.pnlOrderDetail.Controls.Add(this.txtSearch);
            this.pnlOrderDetail.Controls.Add(this.dgvOrder);
            this.pnlOrderDetail.Controls.Add(this.btnHome);
            this.pnlOrderDetail.Controls.Add(this.btnRefresh);
            this.pnlOrderDetail.Controls.Add(this.btnBack);
            this.pnlOrderDetail.Location = new System.Drawing.Point(0, 1);
            this.pnlOrderDetail.Name = "pnlOrderDetail";
            this.pnlOrderDetail.Size = new System.Drawing.Size(785, 459);
            this.pnlOrderDetail.TabIndex = 18;
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDate.Controls.Add(this.lvlMsg);
            this.pnlDate.Controls.Add(this.dtpToDate);
            this.pnlDate.Controls.Add(this.dtpFromDate);
            this.pnlDate.Controls.Add(this.lvlToDate);
            this.pnlDate.Controls.Add(this.lvlFromDate);
            this.pnlDate.Controls.Add(this.btnSearch);
            this.pnlDate.Location = new System.Drawing.Point(12, 47);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(438, 98);
            this.pnlDate.TabIndex = 29;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.CustomFormat = "yyyy/MM/dd";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(211, 50);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(103, 26);
            this.dtpToDate.TabIndex = 24;
            this.dtpToDate.Value = new System.DateTime(2020, 4, 2, 23, 36, 23, 0);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.CustomFormat = "yyyy/MM/dd";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(66, 50);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(103, 26);
            this.dtpFromDate.TabIndex = 28;
            this.dtpFromDate.Value = new System.DateTime(2020, 4, 2, 23, 36, 23, 0);
            // 
            // lvlFromDate
            // 
            this.lvlFromDate.AutoSize = true;
            this.lvlFromDate.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlFromDate.ForeColor = System.Drawing.Color.Yellow;
            this.lvlFromDate.Location = new System.Drawing.Point(13, 54);
            this.lvlFromDate.Name = "lvlFromDate";
            this.lvlFromDate.Size = new System.Drawing.Size(47, 20);
            this.lvlFromDate.TabIndex = 27;
            this.lvlFromDate.Text = "From :";
            // 
            // lvlSearch
            // 
            this.lvlSearch.AutoSize = true;
            this.lvlSearch.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lvlSearch.Location = new System.Drawing.Point(21, 17);
            this.lvlSearch.Name = "lvlSearch";
            this.lvlSearch.Size = new System.Drawing.Size(61, 20);
            this.lvlSearch.TabIndex = 26;
            this.lvlSearch.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(96, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(349, 26);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lvlMsg
            // 
            this.lvlMsg.AutoSize = true;
            this.lvlMsg.Font = new System.Drawing.Font("Imprint MT Shadow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlMsg.ForeColor = System.Drawing.Color.Lime;
            this.lvlMsg.Location = new System.Drawing.Point(12, 12);
            this.lvlMsg.Name = "lvlMsg";
            this.lvlMsg.Size = new System.Drawing.Size(160, 25);
            this.lvlMsg.TabIndex = 29;
            this.lvlMsg.Text = "Search By Date";
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMonth.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.ForeColor = System.Drawing.Color.Yellow;
            this.btnMonth.Location = new System.Drawing.Point(469, 46);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(167, 30);
            this.btnMonth.TabIndex = 30;
            this.btnMonth.Text = "Last Month";
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWeek.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeek.ForeColor = System.Drawing.Color.Yellow;
            this.btnWeek.Location = new System.Drawing.Point(469, 118);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(167, 30);
            this.btnWeek.TabIndex = 31;
            this.btnWeek.Text = "Last Week";
            this.btnWeek.UseVisualStyleBackColor = false;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnDays
            // 
            this.btnDays.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDays.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDays.ForeColor = System.Drawing.Color.Yellow;
            this.btnDays.Location = new System.Drawing.Point(469, 82);
            this.btnDays.Name = "btnDays";
            this.btnDays.Size = new System.Drawing.Size(167, 30);
            this.btnDays.TabIndex = 32;
            this.btnDays.Text = "Last 15 Days";
            this.btnDays.UseVisualStyleBackColor = false;
            this.btnDays.Click += new System.EventHandler(this.btnDays_Click);
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlOrderDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetail";
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnlOrderDetail.ResumeLayout(false);
            this.pnlOrderDetail.PerformLayout();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lvlToDate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Panel pnlOrderDetail;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lvlSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empId;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBill;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lvlFromDate;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Button btnDays;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Label lvlMsg;

    }
}