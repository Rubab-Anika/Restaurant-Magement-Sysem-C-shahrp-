namespace RestaurantManagementSystem
{
    partial class frmFoodItem
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
            this.cmsFoodItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveFood = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.lvlFoodId = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lvlFoodName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lvlPrice = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvFoodItem = new System.Windows.Forms.DataGridView();
            this.lvlType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlFoodItem = new System.Windows.Forms.Panel();
            this.lvlSearch = new System.Windows.Forms.Label();
            this.foodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsFoodItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodItem)).BeginInit();
            this.pnlFoodItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsFoodItem
            // 
            this.cmsFoodItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.cmsFoodItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreashToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.cmsFoodItem.Name = "cms";
            this.cmsFoodItem.Size = new System.Drawing.Size(118, 70);
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Yellow;
            this.btnSave.Location = new System.Drawing.Point(627, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveFood
            // 
            this.btnRemoveFood.BackColor = System.Drawing.Color.Black;
            this.btnRemoveFood.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFood.ForeColor = System.Drawing.Color.Yellow;
            this.btnRemoveFood.Location = new System.Drawing.Point(503, 347);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(115, 30);
            this.btnRemoveFood.TabIndex = 14;
            this.btnRemoveFood.Text = "Remove ";
            this.btnRemoveFood.UseVisualStyleBackColor = false;
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(616, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 28);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtFoodId
            // 
            this.txtFoodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodId.Location = new System.Drawing.Point(576, 87);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.ReadOnly = true;
            this.txtFoodId.Size = new System.Drawing.Size(150, 26);
            this.txtFoodId.TabIndex = 19;
            // 
            // lvlFoodId
            // 
            this.lvlFoodId.AutoSize = true;
            this.lvlFoodId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlFoodId.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlFoodId.ForeColor = System.Drawing.Color.Yellow;
            this.lvlFoodId.Location = new System.Drawing.Point(495, 90);
            this.lvlFoodId.Name = "lvlFoodId";
            this.lvlFoodId.Size = new System.Drawing.Size(62, 20);
            this.lvlFoodId.TabIndex = 20;
            this.lvlFoodId.Text = "Food ID :";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.Location = new System.Drawing.Point(576, 187);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(150, 26);
            this.txtFoodName.TabIndex = 21;
            // 
            // lvlFoodName
            // 
            this.lvlFoodName.AutoSize = true;
            this.lvlFoodName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlFoodName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlFoodName.ForeColor = System.Drawing.Color.Yellow;
            this.lvlFoodName.Location = new System.Drawing.Point(472, 187);
            this.lvlFoodName.Name = "lvlFoodName";
            this.lvlFoodName.Size = new System.Drawing.Size(85, 20);
            this.lvlFoodName.TabIndex = 22;
            this.lvlFoodName.Text = "Food Name :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(576, 240);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 26);
            this.txtPrice.TabIndex = 23;
            // 
            // lvlPrice
            // 
            this.lvlPrice.AutoSize = true;
            this.lvlPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlPrice.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lvlPrice.Location = new System.Drawing.Point(508, 240);
            this.lvlPrice.Name = "lvlPrice";
            this.lvlPrice.Size = new System.Drawing.Size(49, 20);
            this.lvlPrice.TabIndex = 24;
            this.lvlPrice.Text = "Price :";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnHome.Location = new System.Drawing.Point(688, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 29);
            this.btnHome.TabIndex = 31;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Yellow;
            this.btnRefresh.Location = new System.Drawing.Point(567, 311);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 30);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvFoodItem
            // 
            this.dgvFoodItem.AllowUserToAddRows = false;
            this.dgvFoodItem.AllowUserToDeleteRows = false;
            this.dgvFoodItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodid,
            this.name,
            this.type,
            this.price});
            this.dgvFoodItem.Location = new System.Drawing.Point(3, 51);
            this.dgvFoodItem.Name = "dgvFoodItem";
            this.dgvFoodItem.ReadOnly = true;
            this.dgvFoodItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodItem.Size = new System.Drawing.Size(449, 386);
            this.dgvFoodItem.TabIndex = 33;
            this.dgvFoodItem.DoubleClick += new System.EventHandler(this.dgvFoodItem_DoubleClick);
            // 
            // lvlType
            // 
            this.lvlType.AutoSize = true;
            this.lvlType.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlType.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlType.ForeColor = System.Drawing.Color.Yellow;
            this.lvlType.Location = new System.Drawing.Point(506, 134);
            this.lvlType.Name = "lvlType";
            this.lvlType.Size = new System.Drawing.Size(45, 20);
            this.lvlType.TabIndex = 34;
            this.lvlType.Text = "Type :";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(576, 136);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(150, 28);
            this.cmbType.TabIndex = 35;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(70, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(267, 26);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlFoodItem
            // 
            this.pnlFoodItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFoodItem.ContextMenuStrip = this.cmsFoodItem;
            this.pnlFoodItem.Controls.Add(this.lvlSearch);
            this.pnlFoodItem.Controls.Add(this.txtSearch);
            this.pnlFoodItem.Controls.Add(this.cmbType);
            this.pnlFoodItem.Controls.Add(this.lvlType);
            this.pnlFoodItem.Controls.Add(this.dgvFoodItem);
            this.pnlFoodItem.Controls.Add(this.btnRefresh);
            this.pnlFoodItem.Controls.Add(this.btnHome);
            this.pnlFoodItem.Controls.Add(this.lvlPrice);
            this.pnlFoodItem.Controls.Add(this.txtPrice);
            this.pnlFoodItem.Controls.Add(this.lvlFoodName);
            this.pnlFoodItem.Controls.Add(this.txtFoodName);
            this.pnlFoodItem.Controls.Add(this.lvlFoodId);
            this.pnlFoodItem.Controls.Add(this.txtFoodId);
            this.pnlFoodItem.Controls.Add(this.btnBack);
            this.pnlFoodItem.Controls.Add(this.btnRemoveFood);
            this.pnlFoodItem.Controls.Add(this.btnSave);
            this.pnlFoodItem.Location = new System.Drawing.Point(9, 5);
            this.pnlFoodItem.Name = "pnlFoodItem";
            this.pnlFoodItem.Size = new System.Drawing.Size(766, 444);
            this.pnlFoodItem.TabIndex = 33;
            // 
            // lvlSearch
            // 
            this.lvlSearch.AutoSize = true;
            this.lvlSearch.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lvlSearch.Location = new System.Drawing.Point(3, 12);
            this.lvlSearch.Name = "lvlSearch";
            this.lvlSearch.Size = new System.Drawing.Size(61, 20);
            this.lvlSearch.TabIndex = 37;
            this.lvlSearch.Text = "Search :";
            // 
            // foodid
            // 
            this.foodid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.foodid.DataPropertyName = "foodid";
            this.foodid.HeaderText = "Food ID";
            this.foodid.Name = "foodid";
            this.foodid.ReadOnly = true;
            this.foodid.Width = 70;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 56;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 56;
            // 
            // frmFoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlFoodItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFoodItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodItem";
            this.Load += new System.EventHandler(this.frmFoodItem_Load);
            this.cmsFoodItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodItem)).EndInit();
            this.pnlFoodItem.ResumeLayout(false);
            this.pnlFoodItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsFoodItem;
        private System.Windows.Forms.ToolStripMenuItem refreashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveFood;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.Label lvlFoodId;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lvlFoodName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lvlPrice;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvFoodItem;
        private System.Windows.Forms.Label lvlType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlFoodItem;
        private System.Windows.Forms.Label lvlSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}