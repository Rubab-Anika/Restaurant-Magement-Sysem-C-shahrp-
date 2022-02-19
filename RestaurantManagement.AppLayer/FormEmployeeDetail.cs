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
    public partial class frmEmployeeDetail : Form
    {
        private ManagerRepo mRepo { get; set; }
        private EmployeeRepo eRepo { get; set; }
        private static  User Usr { get; set; }
        private Employee E { get; set; }
        private Manager M { get; set; }
        private UserRepo uRepo { get; set; }

        public frmEmployeeDetail(User usr)
        {
            InitializeComponent();
            this.eRepo = new EmployeeRepo();
            this.mRepo = new ManagerRepo();
            this.M = new Manager();
            this.E = new Employee();
            this.uRepo = new UserRepo();
           
           Usr = usr;
           
        }


        private void LoadAutoEmployeeId()
        {
            int serial = eRepo.AutoIDValue();
            eRepo.EmpID = (++serial).ToString("d4");
            this.txtEmployeeId.Text = eRepo.EmpID;
        }
        private void LoadAutoManagerId()
        {
            int serial = mRepo.AutoIDValue();
            mRepo.MgrId = (++serial).ToString("d4");
            this.txtEmployeeId.Text = mRepo.MgrId;
        }


       private void btnRefresh_Click(object sender, EventArgs e)
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


        private void frmEmployeeDetail_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }


        private void PopulateGridView()
        {
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = eRepo.GetAll().ToList();
            this.dgvManager.AutoGenerateColumns = false;
            this.dgvManager.DataSource = mRepo.GetAll().ToList();
           
            this.dgvEmployee.ClearSelection();
            this.dgvManager.ClearSelection();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var txt = this.txtSearch.Text;
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = eRepo.Search(txt).ToList();
            this.dgvEmployee.ClearSelection();
            this.dgvManager.AutoGenerateColumns = false;
            this.dgvManager.DataSource = mRepo.Search(txt).ToList();
            this.dgvManager.ClearSelection();
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (this.cmbDesignation.Text == "Employee")
            {
                if (this.FillEntityForEmployee() == true)
                {
                    bool d = eRepo.Save(E);//, this.cmbDesignation.Text);
                    if (d == true)
                    {
                        MessageBox.Show("Insert Done ");
  
                    }
                    else
                        MessageBox.Show("Insert Not Done");
                    // this.dg();
                    this.ClearAll();
                    this.PopulateGridView();
                }
                else
                    MessageBox.Show("missing some data!!");
            }
            else 
            {
                if (this.FillEntityForManager() == true)
                {
                    bool d = mRepo.Save(M);
                    if (d == true)
                    {
                        MessageBox.Show("Insert Done ");
                        
                    }
                    else
                        MessageBox.Show("Insert Not Done");
                    // this.dg();
                    this.ClearAll();
                    this.PopulateGridView();
                }
                else
                    MessageBox.Show("missing some data!!");
            }

        }


        private bool FillEntityForEmployee()
        {
              {
                  if (this.txtEmployeeId.Text == "")
                  {
                      this.LoadAutoEmployeeId();
                      if (!IsValidToSave())
                          return false;


                      else
                      {
                          E.empid = this.txtEmployeeId.Text;
                          E.name = this.txtEmployeeName.Text;
                          E.address = this.txtaddress.Text;
                          E.phonenum = this.txtPhoneNum.Text;
                          E.sal = Convert.ToDouble(this.txtSalary.Text);
                          uRepo.Save(this.txtEmployeeId.Text, this.txtEmployeeName.Text, this.cmbDesignation.Text);
                          MessageBox.Show("New User Password is ' " + this.txtEmployeeName.Text + " ' please Change Your PassWord After First Login  ");

                          return true;
                      }

                  }
                  else
                  {
                      if (!IsValidToSave())
                          return false;
                      else
                      {
                          E.empid = this.txtEmployeeId.Text;
                          E.name = this.txtEmployeeName.Text;
                          E.address = this.txtaddress.Text;
                          E.phonenum = this.txtPhoneNum.Text;
                          E.sal = Convert.ToDouble(this.txtSalary.Text);

                          return true;
                      }
                  }
            }
        }

        private bool FillEntityForManager()
        {
            {
                if (this.txtEmployeeId.Text == "")
                {
                    this.LoadAutoManagerId();
                    if (!IsValidToSave())
                        return false;
                    else
                    {
                        M.managerid = this.txtEmployeeId.Text;
                        M.name = this.txtEmployeeName.Text;
                        M.address = this.txtaddress.Text;
                        M.phonenum = this.txtPhoneNum.Text;
                        M.sal = Convert.ToDouble(this.txtSalary.Text);

                        uRepo.Save(this.txtEmployeeId.Text, this.txtEmployeeName.Text, this.cmbDesignation.Text);
                        MessageBox.Show("New User Your Id =" + this.txtEmployeeId.Text + " Password is = ' " + this.txtEmployeeName.Text + " ' please Change Your PassWord After First Login  ");
                        return true;
                    }

                }
                else
                {
                    if (!IsValidToSave())
                        return false;
                    else
                    {
                        M.managerid = this.txtEmployeeId.Text;
                        M.name = this.txtEmployeeName.Text;
                        M.address = this.txtaddress.Text;
                        M.phonenum = this.txtPhoneNum.Text;
                        M.sal = Convert.ToDouble(this.txtSalary.Text);

                        return true;
                    }
                }
            }
        }
        private bool IsValidToSave()
        {
            if (Validation.IsStringValid(this.txtEmployeeId.Text) && Validation.IsStringValid(this.txtEmployeeName.Text) && Validation.IsStringValid(this.txtaddress.Text) && Validation.IsStringValid(this.txtPhoneNum.Text) &&
                 Validation.IsFloatValid(this.txtSalary.Text))
            {
                if ((this.txtEmployeeName.Text != "") && (this.txtPhoneNum.Text != "") && (this.txtaddress.Text != "") && (this.txtSalary.Text != ""))
                    return true;
                else return false;
            }
            else
                return false;
        }
       
        private bool IsValidToDeleteEmployee()
        {
            if ((this.txtEmployeeId.Text != "")||(dgvEmployee.SelectedRows.Count==1))
                return true;
            else return false;
        }
        private bool IsValidToDeleteManager()
        {
            if ((this.txtEmployeeId.Text != "") || (dgvManager.SelectedRows.Count == 1))
                return true;
            else return false;
        }
        private void ClearAll()
        {

            this.txtEmployeeId.Clear();
            this.txtEmployeeName.Clear();
            this.txtaddress.Clear();
            this.txtPhoneNum.Clear();
            this.txtSalary.Clear();
            this.cmbDesignation.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            bool a = this.IsValidToDeleteEmployee();
            if (a == true)
            {
                bool d = eRepo.Delete(this.dgvEmployee.CurrentRow.Cells[1].Value.ToString());
                if (d == true)
                 MessageBox.Show("Deleted Employee Information"); 
                else
                    MessageBox.Show("Could not Delete Employee Information the item Name you inserted is invalid!!  ");
                // this.dg();
                this.ClearAll();
                this.PopulateGridView();
            }
            else if (this.IsValidToDeleteManager() == true)
            {
                bool d = mRepo.Delete(this.dgvManager.CurrentRow.Cells[1].Value.ToString());
                if (d == true)
                    MessageBox.Show("Deleted Manager Information");
                else
                    MessageBox.Show("Could not Delete Manager Information the item Name you inserted is invalid!!  ");
                // this.dg();
                this.ClearAll();
                this.PopulateGridView();
 
            }
            else 
            MessageBox.Show("Not deleted Yet");
        }

        private void refreashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateGridView();
        }


        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool a = this.IsValidToDeleteEmployee();
            if (a == true)
            {
                bool d = eRepo.Delete(this.dgvEmployee.CurrentRow.Cells[1].Value.ToString());
                if (d == true)
                    MessageBox.Show("Deleted");
                else
                    MessageBox.Show("Could not Delete the item Name you inserted is invalid!!  ");
                // this.dg();
                this.ClearAll();
                this.PopulateGridView();
            }
            else if (this.IsValidToDeleteManager() == true)
            {
                bool d = mRepo.Delete(this.dgvManager.CurrentRow.Cells[1].Value.ToString());
                if (d == true)
                    MessageBox.Show("Deleted Manager Information");
                else
                    MessageBox.Show("Could not Delete Manager Information the item Name you inserted is invalid!!  ");
                // this.dg();
                this.ClearAll();
                this.PopulateGridView();

            }
            else MessageBox.Show("Can Not Delete the item");
        }



        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.txtEmployeeId.Text = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            this.txtEmployeeName.Text = this.dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            this.txtaddress.Text = this.dgvEmployee.CurrentRow.Cells[2].Value.ToString();
            this.txtPhoneNum.Text = this.dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            this.txtSalary.Text = this.dgvEmployee.CurrentRow.Cells[4].Value.ToString();
            this.cmbDesignation.Text = "Employee";
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (this.cmbDesignation.Text == "Employee")
            {
                if (this.FillEntityForEmployee() == true)
                {
                    bool d = eRepo.Save(E);
                    if (d == true)
                    {
                        MessageBox.Show("Insert Done ");
                        //uRepo.Save(E.empid, E.name, this.cmbDesignation.Text);
                        //MessageBox.Show("New User Password is ' " + this.E.name + " ' please Change Your PassWord After First Login  ");
                    }
                    else
                        MessageBox.Show("Insert Not Done");
                    // this.dg();
                    this.ClearAll();
                    this.PopulateGridView();
                }
                else
                    MessageBox.Show("missing some data!!");
            }
            else
            {
                if (this.FillEntityForManager() == true)
                {
                    bool d = mRepo.Save(M);
                    if (d == true)
                    {
                        MessageBox.Show("Insert Done ");
                       // uRepo.Save(M.managerid, M.name, this.cmbDesignation.Text);
                        //MessageBox.Show("New User Your Id =" + this.txtEmployeeId.Text + " Password is = ' " + this.M.name + " ' please Change Your PassWord After First Login  ");
                    }
                    else
                        MessageBox.Show("Insert Not Done");
                    // this.dg();
                    this.ClearAll();
                    this.PopulateGridView();
                }
                else
                    MessageBox.Show("missing some data!!");
            }

        }

        private void dgvManager_DoubleClick(object sender, EventArgs e)
        {
            this.txtEmployeeId.Text = this.dgvManager.CurrentRow.Cells[0].Value.ToString();
            this.txtEmployeeName.Text = this.dgvManager.CurrentRow.Cells[1].Value.ToString();
            this.txtaddress.Text = this.dgvManager.CurrentRow.Cells[2].Value.ToString();
            this.txtPhoneNum.Text = this.dgvManager.CurrentRow.Cells[3].Value.ToString();
            this.txtSalary.Text = this.dgvManager.CurrentRow.Cells[4].Value.ToString();
            this.cmbDesignation.Text = "Manager";
        }

 
    }
}
