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
    public partial class frmTable : Form
    {
        private TableRepo tRepo { get; set; }
        private User Usr { get; set; }
        private Table t = new Table();
        public frmTable(User usr)
        {
            InitializeComponent();
            this.tRepo = new TableRepo();
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

        private void frmTable_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        private void PopulateGridView()
        {
            this.dgvTable.AutoGenerateColumns = false;
            this.dgvTable.DataSource = tRepo.GetAll().ToList();
            this.dgvTable.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (this.FillEntity() == false)
            {
                MessageBox.Show("Insert Not Done");
            }
            else
            {
                bool d = tRepo.Save(t);
                if (d == true)
                    MessageBox.Show("Insert Done");
                else
                    MessageBox.Show("Insert Not Done");
                // this.dg();
                this.ClearAll();
                this.PopulateGridView();
            }

        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FillEntity() == false)
            {
                MessageBox.Show("Insert Not Done");
            }
            else
            {
                bool d = tRepo.Save(t);
                if (d == true)
                    MessageBox.Show("Insert Done");
                else
                    MessageBox.Show("Insert Not Done");
                // this.dg();
                this.ClearAll();
                this.PopulateGridView();
            }
        }
        private bool FillEntity()
        {
            if (IsValidToSave() == true)
            {

                t.name = this.txtTableName.Text;
                t.numOfChair = Convert.ToInt32(this.cmbNumOfChair.Text);
                t.status = this.cmbStatus.Text;
                // pro.quantity = Int32.Parse(this.txtQuantity.Text);
                return true;
            }
            else return false;
        }
        private bool IsValidToSave()
        {
            if (Validation.IsStringValid(this.txtTableName.Text) && Validation.IsStringValid(this.cmbStatus.Text) &&
                 Validation.IsIntValid(this.cmbNumOfChair.Text))
            {
                if ((this.txtTableName.Text!= "")&&(this.cmbNumOfChair.Text!="")&&(this.cmbStatus.Text!=""))
                {return true;}
                else 
                return false;
            }
            else
                return false;
        }
        private bool IsValidToDelete()
        {
            if ((dgvTable.SelectedRows.Count==1)||(this.txtTableName.Text!=""))
                return true;
            else return false;
        }
        private void ClearAll()
        {
            
            this.txtTableName.Clear();
            this.cmbNumOfChair.Text="";
            this.cmbStatus.Text="";
        }

        private void refreashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            PopulateGridView();
            this.dgvTable.ClearSelection();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool a = this.IsValidToDelete();
            if (a == true)
            {
                bool d = tRepo.Delete(this.dgvTable.CurrentRow.Cells[1].Value.ToString());
                if (d == true)
                    MessageBox.Show("Deleted");
                else
                    MessageBox.Show("Could not Delet the item Name you inserted is invalid!!  ");
                // this.dg();
                this.ClearAll();
                this.PopulateGridView();
            }
            else MessageBox.Show("Could not Delet the item Name you inserted is invalid!!  ");

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool a = this.IsValidToDelete();
            if (a == true)
            {
                var name = this.dgvTable.CurrentRow.Cells[1].Value.ToString();
                bool d = tRepo.Delete(name);
                if (d == true)
                    MessageBox.Show("Deleted");
                else
                    MessageBox.Show("Could not Delet the item Name you inserted is invalid!!  ");
                // this.dg();
                this.ClearAll();
                this.PopulateGridView();
            }
            else MessageBox.Show("Could not Delet the item Name you inserted is invalid!!  ");
        }

      

        private void dgvTable_DoubleClick(object sender, EventArgs e)
        {
            this.txtTableName.Text = this.dgvTable.CurrentRow.Cells[1].Value.ToString();
            this.cmbNumOfChair.Text = this.dgvTable.CurrentRow.Cells[2].Value.ToString();
            this.cmbStatus.Text = this.dgvTable.CurrentRow.Cells[3].Value.ToString();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var txt = this.txtSearch.Text;
            this.dgvTable.AutoGenerateColumns = false;
            this.dgvTable.DataSource = tRepo.Search(txt).ToList();
            this.dgvTable.ClearSelection();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var txt = this.txtSearch.Text;
            this.dgvTable.AutoGenerateColumns = false;
            this.dgvTable.DataSource = tRepo.Search(txt).ToList();
            this.dgvTable.ClearSelection();
        }

        private void pnlTableManagement_Paint(object sender, PaintEventArgs e)
        {

        }
       
      
        
    }
}
