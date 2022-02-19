using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagement.Repo;
using RestaurentManagement.Entity;
using RestaurentManagement.Framework;

namespace RestaurantManagementSystem
{
    public partial class frmChangePassword : Form
    {
        private static User Usr { get; set; }
        public frmChangePassword(User usr)
        {
            InitializeComponent();
            Usr = usr;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure You want to leave this page ", "Leave Page", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                frmHome fh = new frmHome();
                fh.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Usr.designation == "Employee")
            {
                this.Visible = false;
                frmEmployee fe = new frmEmployee(Usr);
                fe.Visible = true;
            }
            else {
                this.Visible = false;
                frmManager fm = new  frmManager(Usr);
                fm.Visible = true;
            }
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            this.txtNewPass.Text = "";
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (this.IsValidToChangePass() == true)
            {
                UserRepo urRepo = new UserRepo();
                bool d =urRepo.UpdatePass(this.txtNewPass.Text,Usr.userid);
                if (d == true)
                {
                    MessageBox.Show("Password Changed");
                    MessageBox.Show("Login Sesson Faild Please Login With Your New PassWord!!");
                    this.Visible = false;
                    frmLogin fl = new frmLogin();
                    fl.Visible = true;
                }
                else
                    MessageBox.Show("Can Not Change Password Missing some Data!!");
   
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            this.txtUserId.Text = Usr.userid;
            this.txtCurrentPAss.Text = Usr.pass;

        }
        private bool IsValidToChangePass()
        {
            if (Validation.IsStringValid(this.txtUserId.Text) && Validation.IsStringValid(this.txtCurrentPAss.Text) &&
                 Validation.IsStringValid(this.txtNewPass.Text))
            {
                if ((this.txtUserId.Text != "") && (this.txtCurrentPAss.Text != "") && (this.txtNewPass.Text != ""))
                { return true; }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
