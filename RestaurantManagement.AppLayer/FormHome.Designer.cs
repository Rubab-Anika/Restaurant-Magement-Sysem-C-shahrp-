namespace RestaurantManagementSystem
{
    partial class frmHome
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.PnlHome = new System.Windows.Forms.Panel();
            this.pnlHomeImage = new System.Windows.Forms.Panel();
            this.PnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Yellow;
            this.btnLogin.Location = new System.Drawing.Point(328, 394);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 29);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // PnlHome
            // 
            this.PnlHome.Controls.Add(this.pnlHomeImage);
            this.PnlHome.Controls.Add(this.btnLogin);
            this.PnlHome.Location = new System.Drawing.Point(2, 10);
            this.PnlHome.Name = "PnlHome";
            this.PnlHome.Size = new System.Drawing.Size(780, 441);
            this.PnlHome.TabIndex = 6;
            // 
            // pnlHomeImage
            // 
            this.pnlHomeImage.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.WhatsApp_Image_2020_04_03_at_10_54_25_PM;
            this.pnlHomeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHomeImage.Location = new System.Drawing.Point(10, 13);
            this.pnlHomeImage.Name = "pnlHomeImage";
            this.pnlHomeImage.Size = new System.Drawing.Size(760, 355);
            this.pnlHomeImage.TabIndex = 1;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PnlHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch & Supper";
            this.PnlHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel PnlHome;
        private System.Windows.Forms.Panel pnlHomeImage;
    }
}