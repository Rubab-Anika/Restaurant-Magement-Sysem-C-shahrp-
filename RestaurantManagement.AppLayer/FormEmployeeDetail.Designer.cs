namespace RestaurantManagementSystem
{
    partial class frmEmployeeDetail
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.lvlEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlEmployeeDetail = new System.Windows.Forms.Panel();
            this.cmsEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvlmanager = new System.Windows.Forms.Label();
            this.lvlEmployee = new System.Windows.Forms.Label();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.lvlDesignation = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.lvlSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvlAddress = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lvlSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lvlPhoneNum = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lvlEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgrname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgrAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgrphoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgrsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.pnlEmployeeDetail.SuspendLayout();
            this.cmsEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empid,
            this.name,
            this.address,
            this.phonenum,
            this.sal});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 70);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(450, 166);
            this.dgvEmployee.TabIndex = 17;
            this.dgvEmployee.DoubleClick += new System.EventHandler(this.dgvEmployee_DoubleClick);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnHome.Location = new System.Drawing.Point(707, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 32);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // lvlEmployeeId
            // 
            this.lvlEmployeeId.AutoSize = true;
            this.lvlEmployeeId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlEmployeeId.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlEmployeeId.ForeColor = System.Drawing.Color.Yellow;
            this.lvlEmployeeId.Location = new System.Drawing.Point(489, 70);
            this.lvlEmployeeId.Name = "lvlEmployeeId";
            this.lvlEmployeeId.Size = new System.Drawing.Size(94, 20);
            this.lvlEmployeeId.TabIndex = 7;
            this.lvlEmployeeId.Text = "Employee ID :";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(595, 66);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.Size = new System.Drawing.Size(150, 26);
            this.txtEmployeeId.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Yellow;
            this.btnRefresh.Location = new System.Drawing.Point(581, 357);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(628, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 27);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Yellow;
            this.btnRemove.Location = new System.Drawing.Point(637, 393);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 30);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlEmployeeDetail
            // 
            this.pnlEmployeeDetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlEmployeeDetail.ContextMenuStrip = this.cmsEmployee;
            this.pnlEmployeeDetail.Controls.Add(this.lvlmanager);
            this.pnlEmployeeDetail.Controls.Add(this.lvlEmployee);
            this.pnlEmployeeDetail.Controls.Add(this.dgvManager);
            this.pnlEmployeeDetail.Controls.Add(this.lvlDesignation);
            this.pnlEmployeeDetail.Controls.Add(this.cmbDesignation);
            this.pnlEmployeeDetail.Controls.Add(this.lvlSearch);
            this.pnlEmployeeDetail.Controls.Add(this.txtSearch);
            this.pnlEmployeeDetail.Controls.Add(this.lvlAddress);
            this.pnlEmployeeDetail.Controls.Add(this.txtaddress);
            this.pnlEmployeeDetail.Controls.Add(this.lvlSalary);
            this.pnlEmployeeDetail.Controls.Add(this.txtSalary);
            this.pnlEmployeeDetail.Controls.Add(this.lvlPhoneNum);
            this.pnlEmployeeDetail.Controls.Add(this.txtPhoneNum);
            this.pnlEmployeeDetail.Controls.Add(this.lvlEmployeeName);
            this.pnlEmployeeDetail.Controls.Add(this.txtEmployeeName);
            this.pnlEmployeeDetail.Controls.Add(this.dgvEmployee);
            this.pnlEmployeeDetail.Controls.Add(this.btnHome);
            this.pnlEmployeeDetail.Controls.Add(this.lvlEmployeeId);
            this.pnlEmployeeDetail.Controls.Add(this.txtEmployeeId);
            this.pnlEmployeeDetail.Controls.Add(this.btnRefresh);
            this.pnlEmployeeDetail.Controls.Add(this.btnBack);
            this.pnlEmployeeDetail.Controls.Add(this.btnRemove);
            this.pnlEmployeeDetail.Controls.Add(this.btnAddEmployee);
            this.pnlEmployeeDetail.Location = new System.Drawing.Point(0, 1);
            this.pnlEmployeeDetail.Name = "pnlEmployeeDetail";
            this.pnlEmployeeDetail.Size = new System.Drawing.Size(785, 459);
            this.pnlEmployeeDetail.TabIndex = 18;
            // 
            // cmsEmployee
            // 
            this.cmsEmployee.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.cmsEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreashToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.cmsEmployee.Name = "cms";
            this.cmsEmployee.Size = new System.Drawing.Size(118, 70);
            // 
            // refreashToolStripMenuItem
            // 
            this.refreashToolStripMenuItem.Name = "refreashToolStripMenuItem";
            this.refreashToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.refreashToolStripMenuItem.Text = "Refresh";
            this.refreashToolStripMenuItem.Click += new System.EventHandler(this.refreashToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // lvlmanager
            // 
            this.lvlmanager.AutoSize = true;
            this.lvlmanager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlmanager.ForeColor = System.Drawing.Color.Yellow;
            this.lvlmanager.Location = new System.Drawing.Point(151, 245);
            this.lvlmanager.Name = "lvlmanager";
            this.lvlmanager.Size = new System.Drawing.Size(128, 20);
            this.lvlmanager.TabIndex = 32;
            this.lvlmanager.Text = "Table Manager";
            // 
            // lvlEmployee
            // 
            this.lvlEmployee.AutoSize = true;
            this.lvlEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlEmployee.ForeColor = System.Drawing.Color.Yellow;
            this.lvlEmployee.Location = new System.Drawing.Point(151, 47);
            this.lvlEmployee.Name = "lvlEmployee";
            this.lvlEmployee.Size = new System.Drawing.Size(136, 20);
            this.lvlEmployee.TabIndex = 31;
            this.lvlEmployee.Text = "Table Employee";
            // 
            // dgvManager
            // 
            this.dgvManager.AllowUserToAddRows = false;
            this.dgvManager.AllowUserToDeleteRows = false;
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mgrname,
            this.mgrAddress,
            this.mgrphoneNum,
            this.mgrsal});
            this.dgvManager.Location = new System.Drawing.Point(12, 268);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.ReadOnly = true;
            this.dgvManager.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManager.Size = new System.Drawing.Size(450, 180);
            this.dgvManager.TabIndex = 30;
            this.dgvManager.DoubleClick += new System.EventHandler(this.dgvManager_DoubleClick);
            // 
            // lvlDesignation
            // 
            this.lvlDesignation.AutoSize = true;
            this.lvlDesignation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlDesignation.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlDesignation.ForeColor = System.Drawing.Color.Yellow;
            this.lvlDesignation.Location = new System.Drawing.Point(489, 304);
            this.lvlDesignation.Name = "lvlDesignation";
            this.lvlDesignation.Size = new System.Drawing.Size(93, 20);
            this.lvlDesignation.TabIndex = 29;
            this.lvlDesignation.Text = "Designation :";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Manager",
            "Employee"});
            this.cmbDesignation.Location = new System.Drawing.Point(595, 302);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(150, 28);
            this.cmbDesignation.TabIndex = 28;
            // 
            // lvlSearch
            // 
            this.lvlSearch.AutoSize = true;
            this.lvlSearch.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lvlSearch.Location = new System.Drawing.Point(8, 15);
            this.lvlSearch.Name = "lvlSearch";
            this.lvlSearch.Size = new System.Drawing.Size(61, 20);
            this.lvlSearch.TabIndex = 27;
            this.lvlSearch.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(75, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 26);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lvlAddress
            // 
            this.lvlAddress.AutoSize = true;
            this.lvlAddress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlAddress.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAddress.ForeColor = System.Drawing.Color.Yellow;
            this.lvlAddress.Location = new System.Drawing.Point(515, 212);
            this.lvlAddress.Name = "lvlAddress";
            this.lvlAddress.Size = new System.Drawing.Size(68, 20);
            this.lvlAddress.TabIndex = 25;
            this.lvlAddress.Text = "Address :";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(595, 210);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(150, 26);
            this.txtaddress.TabIndex = 24;
            // 
            // lvlSalary
            // 
            this.lvlSalary.AutoSize = true;
            this.lvlSalary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlSalary.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSalary.ForeColor = System.Drawing.Color.Yellow;
            this.lvlSalary.Location = new System.Drawing.Point(527, 259);
            this.lvlSalary.Name = "lvlSalary";
            this.lvlSalary.Size = new System.Drawing.Size(56, 20);
            this.lvlSalary.TabIndex = 23;
            this.lvlSalary.Text = "Salary :";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(595, 255);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(150, 26);
            this.txtSalary.TabIndex = 22;
            // 
            // lvlPhoneNum
            // 
            this.lvlPhoneNum.AutoSize = true;
            this.lvlPhoneNum.BackColor = System.Drawing.Color.Black;
            this.lvlPhoneNum.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlPhoneNum.ForeColor = System.Drawing.Color.Yellow;
            this.lvlPhoneNum.Location = new System.Drawing.Point(473, 165);
            this.lvlPhoneNum.Name = "lvlPhoneNum";
            this.lvlPhoneNum.Size = new System.Drawing.Size(109, 20);
            this.lvlPhoneNum.TabIndex = 21;
            this.lvlPhoneNum.Text = "Phone Number :";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(594, 163);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(150, 26);
            this.txtPhoneNum.TabIndex = 20;
            // 
            // lvlEmployeeName
            // 
            this.lvlEmployeeName.AutoSize = true;
            this.lvlEmployeeName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlEmployeeName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlEmployeeName.ForeColor = System.Drawing.Color.Yellow;
            this.lvlEmployeeName.Location = new System.Drawing.Point(466, 116);
            this.lvlEmployeeName.Name = "lvlEmployeeName";
            this.lvlEmployeeName.Size = new System.Drawing.Size(117, 20);
            this.lvlEmployeeName.TabIndex = 19;
            this.lvlEmployeeName.Text = "Employee Name :";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(595, 114);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(150, 26);
            this.txtEmployeeName.TabIndex = 18;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEmployee.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddEmployee.Location = new System.Drawing.Point(497, 393);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(135, 30);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Save";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // empid
            // 
            this.empid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empid.DataPropertyName = "empid";
            this.empid.HeaderText = "Id";
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phonenum
            // 
            this.phonenum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phonenum.DataPropertyName = "phonenum";
            this.phonenum.HeaderText = "Phone Num";
            this.phonenum.Name = "phonenum";
            this.phonenum.ReadOnly = true;
            // 
            // sal
            // 
            this.sal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sal.DataPropertyName = "sal";
            this.sal.HeaderText = "Salary";
            this.sal.Name = "sal";
            this.sal.ReadOnly = true;
            this.sal.Width = 61;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "managerid";
            this.id.HeaderText = "Manager Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 79;
            // 
            // mgrname
            // 
            this.mgrname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mgrname.DataPropertyName = "name";
            this.mgrname.HeaderText = "Name";
            this.mgrname.Name = "mgrname";
            this.mgrname.ReadOnly = true;
            // 
            // mgrAddress
            // 
            this.mgrAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mgrAddress.DataPropertyName = "address";
            this.mgrAddress.HeaderText = "Address";
            this.mgrAddress.Name = "mgrAddress";
            this.mgrAddress.ReadOnly = true;
            // 
            // mgrphoneNum
            // 
            this.mgrphoneNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mgrphoneNum.DataPropertyName = "phoneNum";
            this.mgrphoneNum.HeaderText = "Phone Number";
            this.mgrphoneNum.Name = "mgrphoneNum";
            this.mgrphoneNum.ReadOnly = true;
            // 
            // mgrsal
            // 
            this.mgrsal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mgrsal.DataPropertyName = "sal";
            this.mgrsal.HeaderText = "Salary";
            this.mgrsal.Name = "mgrsal";
            this.mgrsal.ReadOnly = true;
            // 
            // frmEmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlEmployeeDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEmployeeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDetail";
            this.Load += new System.EventHandler(this.frmEmployeeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.pnlEmployeeDetail.ResumeLayout(false);
            this.pnlEmployeeDetail.PerformLayout();
            this.cmsEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lvlEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlEmployeeDetail;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lvlPhoneNum;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lvlEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lvlSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lvlAddress;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.ContextMenuStrip cmsEmployee;
        private System.Windows.Forms.ToolStripMenuItem refreashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Label lvlSearch;
        private System.Windows.Forms.Label lvlDesignation;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label lvlmanager;
        private System.Windows.Forms.Label lvlEmployee;
        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn sal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgrname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgrAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgrphoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgrsal;
    }
}