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
    public partial class frmEmployee : Form
    {
        private static User Usr { get; set; }
        public frmEmployee(User usr)
        {
            InitializeComponent();
            Usr = usr;
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
            frmLogin fl = new frmLogin();
            fl.Visible = true;

        }
        

        private void btnHome_Click_1(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Are you sure You want to leave this page ", "Leave Page", MessageBoxButtons.YesNo);
             if (result == DialogResult.Yes)
             {
                 this.Visible = false;
                 frmHome fh = new frmHome();
                 fh.Visible = true;
             }
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmOrderCart fo = new frmOrderCart(Usr);
            fo.Visible = true;
        }
        private void EmployeeInfo()
        {
            Employee emp = new Employee();
            EmployeeRepo empRepo = new EmployeeRepo();
            emp = empRepo.UserDetail(Usr.userid);
            //MessageBox.Show(emp.empid);
            this.lvlEmployeeId.Text = emp.empid.ToString();
            this.lvlEmployeeName.Text = emp.name.ToString();
            this.lvlEmployeePhoneNum.Text = emp.phonenum.ToString();
            this.lvlEmployeeAddress.Text = emp.address.ToString();
            this.lvlEmployeeSalary.Text = emp.sal.ToString();

        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            this.EmployeeInfo();
            
            string path = "E:\\c2\\RestaurantManagementsln\\icone\\info.png";
            this.pictureBox1.Image = Image.FromFile(path);
        }


    }
}
