namespace RestaurantManagementSystem
{
    partial class frmOrderCart
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
            this.lvlMsg = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lvlPrice = new System.Windows.Forms.Label();
            this.lvlQuantity = new System.Windows.Forms.Label();
            this.cmbFoodName = new System.Windows.Forms.ComboBox();
            this.lvlFoodNAme = new System.Windows.Forms.Label();
            this.cmbFoodType = new System.Windows.Forms.ComboBox();
            this.lvlFoodType = new System.Windows.Forms.Label();
            this.cmbSelectTable = new System.Windows.Forms.ComboBox();
            this.lvlSelectTable = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.foodtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lvlMsg
            // 
            this.lvlMsg.AutoSize = true;
            this.lvlMsg.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlMsg.ForeColor = System.Drawing.Color.Yellow;
            this.lvlMsg.Location = new System.Drawing.Point(572, 41);
            this.lvlMsg.Name = "lvlMsg";
            this.lvlMsg.Size = new System.Drawing.Size(180, 23);
            this.lvlMsg.TabIndex = 0;
            this.lvlMsg.Text = "Place Your Order Here";
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlOrder.Controls.Add(this.dgvCart);
            this.pnlOrder.Controls.Add(this.btnRemove);
            this.pnlOrder.Controls.Add(this.btnAddtoCart);
            this.pnlOrder.Controls.Add(this.txtPrice);
            this.pnlOrder.Controls.Add(this.lvlPrice);
            this.pnlOrder.Controls.Add(this.lvlQuantity);
            this.pnlOrder.Controls.Add(this.cmbFoodName);
            this.pnlOrder.Controls.Add(this.lvlFoodNAme);
            this.pnlOrder.Controls.Add(this.cmbFoodType);
            this.pnlOrder.Controls.Add(this.lvlFoodType);
            this.pnlOrder.Controls.Add(this.cmbSelectTable);
            this.pnlOrder.Controls.Add(this.lvlSelectTable);
            this.pnlOrder.Controls.Add(this.nudQuantity);
            this.pnlOrder.Controls.Add(this.btnHome);
            this.pnlOrder.Controls.Add(this.btnBack);
            this.pnlOrder.Controls.Add(this.btnConfirmOrder);
            this.pnlOrder.Controls.Add(this.lvlMsg);
            this.pnlOrder.Location = new System.Drawing.Point(4, 3);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(781, 450);
            this.pnlOrder.TabIndex = 1;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodtype,
            this.foodName,
            this.quantity,
            this.price});
            this.dgvCart.Location = new System.Drawing.Point(3, 41);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(515, 397);
            this.dgvCart.TabIndex = 16;
            this.dgvCart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellDoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Yellow;
            this.btnRemove.Location = new System.Drawing.Point(535, 350);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 32);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove ";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddtoCart.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddtoCart.Location = new System.Drawing.Point(655, 350);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(113, 32);
            this.btnAddtoCart.TabIndex = 14;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(628, 308);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 20);
            this.txtPrice.TabIndex = 13;
            // 
            // lvlPrice
            // 
            this.lvlPrice.AutoSize = true;
            this.lvlPrice.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lvlPrice.Location = new System.Drawing.Point(560, 305);
            this.lvlPrice.Name = "lvlPrice";
            this.lvlPrice.Size = new System.Drawing.Size(49, 20);
            this.lvlPrice.TabIndex = 12;
            this.lvlPrice.Text = "Price :";
            // 
            // lvlQuantity
            // 
            this.lvlQuantity.AutoSize = true;
            this.lvlQuantity.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlQuantity.ForeColor = System.Drawing.Color.Yellow;
            this.lvlQuantity.Location = new System.Drawing.Point(540, 266);
            this.lvlQuantity.Name = "lvlQuantity";
            this.lvlQuantity.Size = new System.Drawing.Size(69, 20);
            this.lvlQuantity.TabIndex = 11;
            this.lvlQuantity.Text = "Quantity :";
            // 
            // cmbFoodName
            // 
            this.cmbFoodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoodName.FormattingEnabled = true;
            this.cmbFoodName.Location = new System.Drawing.Point(628, 222);
            this.cmbFoodName.MaxDropDownItems = 15;
            this.cmbFoodName.Name = "cmbFoodName";
            this.cmbFoodName.Size = new System.Drawing.Size(140, 21);
            this.cmbFoodName.TabIndex = 10;
            this.cmbFoodName.SelectedIndexChanged += new System.EventHandler(this.cmbFoodName_SelectedIndexChanged);
            // 
            // lvlFoodNAme
            // 
            this.lvlFoodNAme.AutoSize = true;
            this.lvlFoodNAme.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlFoodNAme.ForeColor = System.Drawing.Color.Yellow;
            this.lvlFoodNAme.Location = new System.Drawing.Point(524, 222);
            this.lvlFoodNAme.Name = "lvlFoodNAme";
            this.lvlFoodNAme.Size = new System.Drawing.Size(85, 20);
            this.lvlFoodNAme.TabIndex = 9;
            this.lvlFoodNAme.Text = "Food Name :";
            // 
            // cmbFoodType
            // 
            this.cmbFoodType.FormattingEnabled = true;
            this.cmbFoodType.Location = new System.Drawing.Point(628, 176);
            this.cmbFoodType.MaxDropDownItems = 15;
            this.cmbFoodType.Name = "cmbFoodType";
            this.cmbFoodType.Size = new System.Drawing.Size(140, 21);
            this.cmbFoodType.TabIndex = 8;
            this.cmbFoodType.Text = "Select Food Type";
            this.cmbFoodType.SelectedIndexChanged += new System.EventHandler(this.cmbFoodType_SelectedIndexChanged);
            // 
            // lvlFoodType
            // 
            this.lvlFoodType.AutoSize = true;
            this.lvlFoodType.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlFoodType.ForeColor = System.Drawing.Color.Yellow;
            this.lvlFoodType.Location = new System.Drawing.Point(531, 177);
            this.lvlFoodType.Name = "lvlFoodType";
            this.lvlFoodType.Size = new System.Drawing.Size(78, 20);
            this.lvlFoodType.TabIndex = 7;
            this.lvlFoodType.Text = "Food Type :";
            // 
            // cmbSelectTable
            // 
            this.cmbSelectTable.BackColor = System.Drawing.Color.White;
            this.cmbSelectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectTable.FormattingEnabled = true;
            this.cmbSelectTable.Location = new System.Drawing.Point(628, 128);
            this.cmbSelectTable.MaxDropDownItems = 15;
            this.cmbSelectTable.Name = "cmbSelectTable";
            this.cmbSelectTable.Size = new System.Drawing.Size(140, 21);
            this.cmbSelectTable.TabIndex = 6;
            // 
            // lvlSelectTable
            // 
            this.lvlSelectTable.AutoSize = true;
            this.lvlSelectTable.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSelectTable.ForeColor = System.Drawing.Color.Yellow;
            this.lvlSelectTable.Location = new System.Drawing.Point(560, 128);
            this.lvlSelectTable.Name = "lvlSelectTable";
            this.lvlSelectTable.Size = new System.Drawing.Size(49, 20);
            this.lvlSelectTable.TabIndex = 5;
            this.lvlSelectTable.Text = "Table :";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(628, 266);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(47, 20);
            this.nudQuantity.TabIndex = 4;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnHome.Location = new System.Drawing.Point(693, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 28);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(8, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.Yellow;
            this.btnConfirmOrder.Location = new System.Drawing.Point(576, 388);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(154, 50);
            this.btnConfirmOrder.TabIndex = 1;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // foodtype
            // 
            this.foodtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodtype.HeaderText = "FoodType";
            this.foodtype.Name = "foodtype";
            this.foodtype.ReadOnly = true;
            // 
            // foodName
            // 
            this.foodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodName.HeaderText = "FoodName";
            this.foodName.Name = "foodName";
            this.foodName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 71;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 56;
            // 
            // frmOrderCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOrderCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lvlMsg;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lvlPrice;
        private System.Windows.Forms.Label lvlQuantity;
        private System.Windows.Forms.ComboBox cmbFoodName;
        private System.Windows.Forms.Label lvlFoodNAme;
        private System.Windows.Forms.ComboBox cmbFoodType;
        private System.Windows.Forms.Label lvlFoodType;
        private System.Windows.Forms.ComboBox cmbSelectTable;
        private System.Windows.Forms.Label lvlSelectTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}