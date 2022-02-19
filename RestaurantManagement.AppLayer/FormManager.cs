using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurentManagement.Entity;
using RestaurantManagement.Repo;

namespace RestaurantManagementSystem
{
    public partial class frmManager : Form
    {

        private Manager mgr { get; set; }
        private static User Usr { get; set; }

        private ManagerRepo mRepo {get;set;}
        public frmManager(User usr)
        {
            InitializeComponent();
            ManagerRepo mRepo = new ManagerRepo();
            Usr = usr;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Are you sure You want to leave this Form ", "Leave Page", MessageBoxButtons.YesNo);
             if (result == DialogResult.Yes)
             {
                 this.Visible = false;
                
                 frmHome fh = new frmHome();
                 fh.Visible = true;
             }
        }

        private void btnCangePass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure You want to Change Your Password ", " Change PAssword", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;

                frmChangePassword cp = new frmChangePassword(Usr);
                cp.Visible = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //MessageBox.Show("are you sure to leave this page");
            frmLogin fl = new frmLogin();
            fl.Visible = true;
        }

        private void btnEmplyeemng_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEmployeeDetail ed = new frmEmployeeDetail(Usr);
            ed.Visible = true;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTable ft = new frmTable(Usr);
            ft.Visible = true;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmFoodItem fi = new frmFoodItem(Usr);
            fi.Visible = true;
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmOrderDetail od = new frmOrderDetail(Usr);
            od.Visible = true;
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
          this.ManagerInfo();
            string path="E:\\c2\\RestaurantManagementsln\\icone\\info.png";
            this.pictureBox1.Image=Image.FromFile(path);
        }
       private void ManagerInfo()
        {
            Manager mgr = new Manager();
            ManagerRepo mgrRepo = new ManagerRepo(); 
            mgr = mgrRepo.UserDetail(Usr.userid);
            //MessageBox.Show(mgr.managerid);
           this.lvlManagerId.Text =mgr.managerid.ToString();
           this.lvlManagerName.Text =mgr.name.ToString();
           this.lvlManagerPhoneNum.Text = mgr.phonenum.ToString();
           this.lvlManagerAddress.Text = mgr.address.ToString();
           this.lvlManagerSalary.Text = mgr.sal.ToString();

        }

       private void btnFoodType_Click(object sender, EventArgs e)
       {
           this.Visible = false;
           FormFoodType fd = new FormFoodType(Usr);
           fd.Visible = true;
       }

     

    }
}
