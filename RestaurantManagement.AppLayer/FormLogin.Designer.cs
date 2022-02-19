namespace RestaurantManagementSystem
{
    partial class frmLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lvlUserId = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lvlPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRefreash = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlLogin.Controls.Add(this.lvlUserId);
            this.pnlLogin.Controls.Add(this.btnHome);
            this.pnlLogin.Controls.Add(this.lvlPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnRefreash);
            this.pnlLogin.Controls.Add(this.txtId);
            this.pnlLogin.Location = new System.Drawing.Point(12, 1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(770, 467);
            this.pnlLogin.TabIndex = 8;
            // 
            // lvlUserId
            // 
            this.lvlUserId.AutoSize = true;
            this.lvlUserId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlUserId.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlUserId.ForeColor = System.Drawing.Color.Yellow;
            this.lvlUserId.Location = new System.Drawing.Point(233, 151);
            this.lvlUserId.Name = "lvlUserId";
            this.lvlUserId.Size = new System.Drawing.Size(62, 20);
            this.lvlUserId.TabIndex = 4;
            this.lvlUserId.Text = "User Id :";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnHome.Location = new System.Drawing.Point(668, 11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 33);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // lvlPassword
            // 
            this.lvlPassword.AutoSize = true;
            this.lvlPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvlPassword.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlPassword.ForeColor = System.Drawing.Color.Yellow;
            this.lvlPassword.Location = new System.Drawing.Point(216, 206);
            this.lvlPassword.Name = "lvlPassword";
            this.lvlPassword.Size = new System.Drawing.Size(79, 20);
            this.lvlPassword.TabIndex = 5;
            this.lvlPassword.Text = "Password :";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Yellow;
            this.btnLogin.Location = new System.Drawing.Point(428, 369);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 60);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(363, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRefreash
            // 
            this.btnRefreash.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreash.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreash.ForeColor = System.Drawing.Color.Yellow;
            this.btnRefreash.Location = new System.Drawing.Point(140, 369);
            this.btnRefreash.Name = "btnRefreash";
            this.btnRefreash.Size = new System.Drawing.Size(180, 60);
            this.btnRefreash.TabIndex = 1;
            this.btnRefreash.Text = "Refresh";
            this.btnRefreash.UseVisualStyleBackColor = false;
            this.btnRefreash.Click += new System.EventHandler(this.btnRefreash_Click);
            this.btnRefreash.MouseLeave += new System.EventHandler(this.btnRefreash_MouseLeave);
            this.btnRefreash.MouseHover += new System.EventHandler(this.btnRefreash_MouseHover);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(363, 151);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(164, 26);
            this.txtId.TabIndex = 2;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lvlUserId;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lvlPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRefreash;
        private System.Windows.Forms.TextBox txtId;
    }
}

