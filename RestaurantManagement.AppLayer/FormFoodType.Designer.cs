namespace RestaurantManagementSystem
{
    partial class FormFoodType
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
            this.dgvFoodType = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtFoodType = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemoveFood = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFoodItem = new System.Windows.Forms.Panel();
            this.lvlType = new System.Windows.Forms.Label();
            this.typeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodType)).BeginInit();
            this.pnlFoodItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFoodType
            // 
            this.dgvFoodType.AllowUserToAddRows = false;
            this.dgvFoodType.AllowUserToDeleteRows = false;
            this.dgvFoodType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeId,
            this.typeName});
            this.dgvFoodType.Location = new System.Drawing.Point(21, 39);
            this.dgvFoodType.Name = "dgvFoodType";
            this.dgvFoodType.ReadOnly = true;
            this.dgvFoodType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodType.Size = new System.Drawing.Size(251, 272);
            this.dgvFoodType.TabIndex = 33;
            this.dgvFoodType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodItem_CellContentClick);
            this.dgvFoodType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodType_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Yellow;
            this.btnRefresh.Location = new System.Drawing.Point(77, 407);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 30);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnHome.Location = new System.Drawing.Point(215, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 29);
            this.btnHome.TabIndex = 31;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtFoodType
            // 
            this.txtFoodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodType.Location = new System.Drawing.Point(96, 336);
            this.txtFoodType.Name = "txtFoodType";
            this.txtFoodType.Size = new System.Drawing.Size(170, 26);
            this.txtFoodType.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(7, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 28);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemoveFood
            // 
            this.btnRemoveFood.BackColor = System.Drawing.Color.Black;
            this.btnRemoveFood.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFood.ForeColor = System.Drawing.Color.Yellow;
            this.btnRemoveFood.Location = new System.Drawing.Point(150, 368);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(122, 30);
            this.btnRemoveFood.TabIndex = 14;
            this.btnRemoveFood.Text = "Remove ";
            this.btnRemoveFood.UseVisualStyleBackColor = false;
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Yellow;
            this.btnSave.Location = new System.Drawing.Point(14, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFoodItem
            // 
            this.pnlFoodItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFoodItem.Controls.Add(this.dgvFoodType);
            this.pnlFoodItem.Controls.Add(this.btnRefresh);
            this.pnlFoodItem.Controls.Add(this.btnHome);
            this.pnlFoodItem.Controls.Add(this.lvlType);
            this.pnlFoodItem.Controls.Add(this.txtFoodType);
            this.pnlFoodItem.Controls.Add(this.btnBack);
            this.pnlFoodItem.Controls.Add(this.btnRemoveFood);
            this.pnlFoodItem.Controls.Add(this.btnSave);
            this.pnlFoodItem.Location = new System.Drawing.Point(9, 8);
            this.pnlFoodItem.Name = "pnlFoodItem";
            this.pnlFoodItem.Size = new System.Drawing.Size(293, 457);
            this.pnlFoodItem.TabIndex = 34;
            // 
            // lvlType
            // 
            this.lvlType.AutoSize = true;
            this.lvlType.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlType.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlType.ForeColor = System.Drawing.Color.Yellow;
            this.lvlType.Location = new System.Drawing.Point(12, 338);
            this.lvlType.Name = "lvlType";
            this.lvlType.Size = new System.Drawing.Size(78, 20);
            this.lvlType.TabIndex = 20;
            this.lvlType.Text = "Food Type :";
            // 
            // typeId
            // 
            this.typeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeId.DataPropertyName = "typeId";
            this.typeId.HeaderText = "Id";
            this.typeId.Name = "typeId";
            this.typeId.ReadOnly = true;
            // 
            // typeName
            // 
            this.typeName.DataPropertyName = "typeName";
            this.typeName.HeaderText = "Name";
            this.typeName.Name = "typeName";
            this.typeName.ReadOnly = true;
            // 
            // FormFoodType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 463);
            this.Controls.Add(this.pnlFoodItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFoodType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFoodType";
            this.Load += new System.EventHandler(this.FormFoodType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodType)).EndInit();
            this.pnlFoodItem.ResumeLayout(false);
            this.pnlFoodItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFoodType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtFoodType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemoveFood;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlFoodItem;
        private System.Windows.Forms.Label lvlType;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;

    }
}