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
using RestaurentManagement.Framework;

namespace RestaurantManagementSystem
{
    public partial class frmOrderDetail : Form
    {
        private OrderDetailRepo oRepo { get; set; }
        private static User Usr { get; set; }

        private OrderDetail o {get;set;}


        public frmOrderDetail(User usr)
        {
            InitializeComponent();
            this.oRepo = new OrderDetailRepo();
            this.o = new OrderDetail();
            Usr = usr;
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

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateGridView();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmManager fm = new frmManager(Usr);
            fm.Visible = true;
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        private void PopulateGridView()
        {
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.DataSource = oRepo.GetAll().ToList();
            this.dgvOrder.ClearSelection();
        }


        private void ClearAll()
        {
            this.dtpToDate.ResetText();
            this.dtpFromDate.ResetText();
            //this.txtTotalBill.Clear();
        }

        private bool IsValidToSearch()
        {
            if (Validation.IsDateValid(this.dtpFromDate.Text)|| Validation.IsDateValid(this.dtpToDate.Text)) 
           
            
                    return true;
               
           
            else
                return false;

        }

      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string frmDate = this.dtpFromDate.Text;
            string toDate = this.dtpToDate.Text;
            this.dgvOrder.DataSource = oRepo.SearchDateToDate(frmDate, toDate).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var txt = this.txtSearch.Text;
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.DataSource = oRepo.Search(txt).ToList();
            this.dgvOrder.ClearSelection();

        }

        private void btnDays_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            string frmDate = d.AddDays(-15).ToString();
            this.dgvOrder.DataSource = oRepo.SearchDateToDate(frmDate, d.ToString()).ToList();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            string frmDate = d.AddMonths(-1).ToString();
            this.dgvOrder.DataSource = oRepo.SearchByMonth( frmDate,d.ToString()).ToList();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            string frmDate = d.AddDays(-7).ToString();
            this.dgvOrder.DataSource = oRepo.SearchDateToDate(frmDate, d.ToString()).ToList();
        }

   

        
    }
}
