namespace RestaurantManagementSystem
{
    partial class frmTable
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
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTableManagement = new System.Windows.Forms.Panel();
            this.cmsTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvlSearch = new System.Windows.Forms.Label();
            this.cmbNumOfChair = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.lvlAvailability = new System.Windows.Forms.Label();
            this.lvlNoOfChairs = new System.Windows.Forms.Label();
            this.lvlTableName = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfChair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTableManagement.SuspendLayout();
            this.cmsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnHome.Location = new System.Drawing.Point(707, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 29);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTableManagement
            // 
            this.pnlTableManagement.BackColor = System.Drawing.Color.Black;
            this.pnlTableManagement.ContextMenuStrip = this.cmsTable;
            this.pnlTableManagement.Controls.Add(this.lvlSearch);
            this.pnlTableManagement.Controls.Add(this.cmbNumOfChair);
            this.pnlTableManagement.Controls.Add(this.cmbStatus);
            this.pnlTableManagement.Controls.Add(this.txtSearch);
            this.pnlTableManagement.Controls.Add(this.dgvTable);
            this.pnlTableManagement.Controls.Add(this.btnHome);
            this.pnlTableManagement.Controls.Add(this.lvlAvailability);
            this.pnlTableManagement.Controls.Add(this.lvlNoOfChairs);
            this.pnlTableManagement.Controls.Add(this.lvlTableName);
            this.pnlTableManagement.Controls.Add(this.txtTableName);
            this.pnlTableManagement.Controls.Add(this.btnRefresh);
            this.pnlTableManagement.Controls.Add(this.btnBack);
            this.pnlTableManagement.Controls.Add(this.btnRemove);
            this.pnlTableManagement.Controls.Add(this.btnSave);
            this.pnlTableManagement.Location = new System.Drawing.Point(0, 1);
            this.pnlTableManagement.Name = "pnlTableManagement";
            this.pnlTableManagement.Size = new System.Drawing.Size(785, 459);
            this.pnlTableManagement.TabIndex = 17;
            this.pnlTableManagement.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTableManagement_Paint);
            // 
            // cmsTable
            // 
            this.cmsTable.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.cmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreashToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.cmsTable.Name = "cms";
            this.cmsTable.Size = new System.Drawing.Size(118, 70);
            // 
            // refreashToolStripMenuItem
            // 
            this.refreashToolStripMenuItem.Name = "refreashToolStripMenuItem";
            this.refreashToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.refreashToolStripMenuItem.Text = "Refresh";
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
            // lvlSearch
            // 
            this.lvlSearch.AutoSize = true;
            this.lvlSearch.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lvlSearch.Location = new System.Drawing.Point(12, 13);
            this.lvlSearch.Name = "lvlSearch";
            this.lvlSearch.Size = new System.Drawing.Size(61, 20);
            this.lvlSearch.TabIndex = 21;
            this.lvlSearch.Text = "Search :";
            // 
            // cmbNumOfChair
            // 
            this.cmbNumOfChair.FormattingEnabled = true;
            this.cmbNumOfChair.Items.AddRange(new object[] {
            "2",
            "3",
            "5"});
            this.cmbNumOfChair.Location = new System.Drawing.Point(588, 188);
            this.cmbNumOfChair.Name = "cmbNumOfChair";
            this.cmbNumOfChair.Size = new System.Drawing.Size(150, 21);
            this.cmbNumOfChair.TabIndex = 20;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Booked",
            "Not Booked"});
            this.cmbStatus.Location = new System.Drawing.Point(588, 246);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 21);
            this.cmbStatus.TabIndex = 19;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(87, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(278, 26);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.numOfChair,
            this.status});
            this.dgvTable.ContextMenuStrip = this.cmsTable;
            this.dgvTable.Location = new System.Drawing.Point(4, 46);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(445, 402);
            this.dgvTable.TabIndex = 17;
            this.dgvTable.DoubleClick += new System.EventHandler(this.dgvTable_DoubleClick);
            // 
            // lvlAvailability
            // 
            this.lvlAvailability.AutoSize = true;
            this.lvlAvailability.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlAvailability.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAvailability.ForeColor = System.Drawing.Color.Yellow;
            this.lvlAvailability.Location = new System.Drawing.Point(505, 247);
            this.lvlAvailability.Name = "lvlAvailability";
            this.lvlAvailability.Size = new System.Drawing.Size(57, 20);
            this.lvlAvailability.TabIndex = 11;
            this.lvlAvailability.Text = "Status :";
            // 
            // lvlNoOfChairs
            // 
            this.lvlNoOfChairs.AutoSize = true;
            this.lvlNoOfChairs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlNoOfChairs.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNoOfChairs.ForeColor = System.Drawing.Color.Yellow;
            this.lvlNoOfChairs.Location = new System.Drawing.Point(455, 189);
            this.lvlNoOfChairs.Name = "lvlNoOfChairs";
            this.lvlNoOfChairs.Size = new System.Drawing.Size(107, 20);
            this.lvlNoOfChairs.TabIndex = 9;
            this.lvlNoOfChairs.Text = "Num Of Chairs :";
            // 
            // lvlTableName
            // 
            this.lvlTableName.AutoSize = true;
            this.lvlTableName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlTableName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlTableName.ForeColor = System.Drawing.Color.Yellow;
            this.lvlTableName.Location = new System.Drawing.Point(473, 124);
            this.lvlTableName.Name = "lvlTableName";
            this.lvlTableName.Size = new System.Drawing.Size(89, 20);
            this.lvlTableName.TabIndex = 7;
            this.lvlTableName.Text = "Table Name :";
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(588, 122);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(150, 26);
            this.txtTableName.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Yellow;
            this.btnRefresh.Location = new System.Drawing.Point(588, 339);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(608, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 29);
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
            this.btnRemove.Location = new System.Drawing.Point(644, 375);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 30);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove table";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Yellow;
            this.btnSave.Location = new System.Drawing.Point(523, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Table Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // numOfChair
            // 
            this.numOfChair.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numOfChair.DataPropertyName = "numOfChair";
            this.numOfChair.HeaderText = "Num Of Chair";
            this.numOfChair.Name = "numOfChair";
            this.numOfChair.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlTableManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.pnlTableManagement.ResumeLayout(false);
            this.pnlTableManagement.PerformLayout();
            this.cmsTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlTableManagement;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label lvlAvailability;
        private System.Windows.Forms.Label lvlNoOfChairs;
        private System.Windows.Forms.Label lvlTableName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip cmsTable;
        private System.Windows.Forms.ToolStripMenuItem refreashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbNumOfChair;
        private System.Windows.Forms.Label lvlSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfChair;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}