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

namespace RestaurantManagementSystem
{
    public partial class frmLogin : Form
    {
        private UserRepo uRepo {get;set;}
        private User ur  {get;set;}
       
        public frmLogin()
        {
            InitializeComponent();
            uRepo=new UserRepo();
            this.ur = new User();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHome fh = new frmHome();
            fh.Visible = true;
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtPassword.Text = "";
        }

        
        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            this.btnHome.BackColor = Color.Gray;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            this.btnHome.BackColor = Color.Black;
        }

        private void btnRefreash_MouseHover(object sender, EventArgs e)
        {
            this.btnRefreash.BackColor = Color.Gray;
        }

        private void btnRefreash_MouseLeave(object sender, EventArgs e)
        {
            this.btnRefreash.BackColor = Color.Black;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.Gray;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.Black;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserRepo usrRepo = new UserRepo();
            User usr = new User();
            usr=usrRepo.UserValid(this.txtId.Text,this.txtPassword.Text);
            if (usr != null)
            {
                if (usr.designation.Equals("Manager   "))
                {
                    this.Visible = false;
                    frmManager fm = new frmManager(usr);
                    fm.Visible = true;

                }
                else if (usr.designation == "Employee  ")
                {
                    this.Visible = false;
                    frmEmployee fe = new frmEmployee(usr);
                    fe.Visible = true;

                }
            }
            else
                MessageBox.Show("You have Entered a Invalid Id or Password!!");

          
        }
    }
}
