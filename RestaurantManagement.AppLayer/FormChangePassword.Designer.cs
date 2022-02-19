namespace RestaurantManagementSystem
{
    partial class frmChangePassword
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
            this.txtCurrentPAss = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lvlNewPass = new System.Windows.Forms.Label();
            this.lvlCurrentPass = new System.Windows.Forms.Label();
            this.lvlUserID = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnRefreash = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlChangePass = new System.Windows.Forms.Panel();
            this.pnlChangePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurrentPAss
            // 
            this.txtCurrentPAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPAss.Location = new System.Drawing.Point(332, 183);
            this.txtCurrentPAss.Name = "txtCurrentPAss";
            this.txtCurrentPAss.ReadOnly = true;
            this.txtCurrentPAss.Size = new System.Drawing.Size(161, 26);
            this.txtCurrentPAss.TabIndex = 9;
            this.txtCurrentPAss.UseSystemPasswordChar = true;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnHome.Location = new System.Drawing.Point(693, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 32);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(332, 222);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(161, 26);
            this.txtNewPass.TabIndex = 8;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(332, 140);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(161, 26);
            this.txtUserId.TabIndex = 7;
            // 
            // lvlNewPass
            // 
            this.lvlNewPass.AutoSize = true;
            this.lvlNewPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlNewPass.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNewPass.ForeColor = System.Drawing.Color.Yellow;
            this.lvlNewPass.Location = new System.Drawing.Point(206, 224);
            this.lvlNewPass.Name = "lvlNewPass";
            this.lvlNewPass.Size = new System.Drawing.Size(112, 20);
            this.lvlNewPass.TabIndex = 6;
            this.lvlNewPass.Text = "New password : ";
            // 
            // lvlCurrentPass
            // 
            this.lvlCurrentPass.AutoSize = true;
            this.lvlCurrentPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlCurrentPass.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlCurrentPass.ForeColor = System.Drawing.Color.Yellow;
            this.lvlCurrentPass.Location = new System.Drawing.Point(183, 185);
            this.lvlCurrentPass.Name = "lvlCurrentPass";
            this.lvlCurrentPass.Size = new System.Drawing.Size(135, 20);
            this.lvlCurrentPass.TabIndex = 5;
            this.lvlCurrentPass.Text = "Current Password : ";
            // 
            // lvlUserID
            // 
            this.lvlUserID.AutoSize = true;
            this.lvlUserID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlUserID.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlUserID.ForeColor = System.Drawing.Color.Yellow;
            this.lvlUserID.Location = new System.Drawing.Point(252, 142);
            this.lvlUserID.Name = "lvlUserID";
            this.lvlUserID.Size = new System.Drawing.Size(66, 20);
            this.lvlUserID.TabIndex = 4;
            this.lvlUserID.Text = "User ID : ";
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangePass.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Yellow;
            this.btnChangePass.Location = new System.Drawing.Point(294, 349);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(160, 50);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "Change password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnRefreash
            // 
            this.btnRefreash.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreash.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreash.ForeColor = System.Drawing.Color.Yellow;
            this.btnRefreash.Location = new System.Drawing.Point(516, 349);
            this.btnRefreash.Name = "btnRefreash";
            this.btnRefreash.Size = new System.Drawing.Size(160, 50);
            this.btnRefreash.TabIndex = 2;
            this.btnRefreash.Text = "Refresh";
            this.btnRefreash.UseVisualStyleBackColor = false;
            this.btnRefreash.Click += new System.EventHandler(this.btnRefreash_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(73, 349);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlChangePass
            // 
            this.pnlChangePass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlChangePass.Controls.Add(this.txtCurrentPAss);
            this.pnlChangePass.Controls.Add(this.btnHome);
            this.pnlChangePass.Controls.Add(this.txtNewPass);
            this.pnlChangePass.Controls.Add(this.txtUserId);
            this.pnlChangePass.Controls.Add(this.lvlNewPass);
            this.pnlChangePass.Controls.Add(this.lvlCurrentPass);
            this.pnlChangePass.Controls.Add(this.lvlUserID);
            this.pnlChangePass.Controls.Add(this.btnChangePass);
            this.pnlChangePass.Controls.Add(this.btnRefreash);
            this.pnlChangePass.Controls.Add(this.btnBack);
            this.pnlChangePass.Location = new System.Drawing.Point(4, 4);
            this.pnlChangePass.Name = "pnlChangePass";
            this.pnlChangePass.Size = new System.Drawing.Size(776, 453);
            this.pnlChangePass.TabIndex = 11;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlChangePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.pnlChangePass.ResumeLayout(false);
            this.pnlChangePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentPAss;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lvlNewPass;
        private System.Windows.Forms.Label lvlCurrentPass;
        private System.Windows.Forms.Label lvlUserID;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnRefreash;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlChangePass;
    }
}