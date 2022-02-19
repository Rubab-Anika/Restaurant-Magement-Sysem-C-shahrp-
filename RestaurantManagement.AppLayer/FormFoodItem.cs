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
    public partial class frmFoodItem : Form
    {
        private FoodItemRepo fRepo { get; set; }
        private static User Usr { set; get; }
        private FoodTypeRepo tRepo { get; set; }
        private FoodItem f {get;set;}
        public frmFoodItem(User usr)
        {
            InitializeComponent();
            this.fRepo= new FoodItemRepo();
            this.f = new FoodItem(); 
            this.tRepo = new FoodTypeRepo();
            Usr = usr;
        }
        private void LoadAutoFoodId()
        {
            int serial = fRepo.AutoIDValue();
            fRepo.FoodId = (++serial).ToString("d4");
            this.txtFoodId.Text = fRepo.FoodId;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Are you sure You want to leave this page ", "Leave Page", MessageBoxButtons.YesNo);
             if (result == DialogResult.Yes)
             {
                 this.Visible = false;
                 MessageBox.Show("Are you sure to go home??");
                 frmHome fh = new frmHome();
                 fh.Visible = true;
             }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtFoodId.Text = "";
            this.txtFoodName.Text = "";
            this.cmbType.Text = "";
            this.txtPrice.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmManager fm = new frmManager(Usr);
            fm.Visible = true;
        }

        private void frmFoodItem_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        
        private void PopulateGridView()
        {
            this.dgvFoodItem.AutoGenerateColumns = false;
            this.dgvFoodItem.DataSource = fRepo.GetAll().ToList();
            this.dgvFoodItem.ClearSelection();

            this.cmbType.DataSource = tRepo.FillTypeComBo().ToList();
            this.cmbType.DisplayMember = "type";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var txt = this.txtSearch.Text;
            this.dgvFoodItem.AutoGenerateColumns = false;
            this.dgvFoodItem.DataSource = fRepo.Search(txt).ToList();
            this.dgvFoodItem.ClearSelection();

        }

        private void refreashToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.ClearAll();
            this.PopulateGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (this.FillEntity() == true)
            {
                bool d = fRepo.Save(f);
                if (d == true)
                    MessageBox.Show("Insert Done");
                else
                    MessageBox.Show("Insert Not Done");
                // this.dg();
                this.ClearAll();
                this.PopulateGridView();
            }
            else
                MessageBox.Show("missing some data!!");
            this.PopulateGridView();

        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            bool a = this.IsValidToDelete();
            if (a == true)
            {
                bool d = fRepo.Delete(this.dgvFoodItem.CurrentRow.Cells[1].Value.ToString());
                if (d == true)
                    MessageBox.Show("Deleted");
                else
                    MessageBox.Show("Could not Delete the item Name you inserted is invalid!!  ");
                
                this.ClearAll();
                this.PopulateGridView();
            }
            else
            MessageBox.Show("Could not Delete the item Name you inserted is invalid!!  ");
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool a = this.IsValidToDelete();
            if (a == true)
            {
                var name = this.dgvFoodItem.CurrentRow.Cells[1].Value.ToString();
                bool d = fRepo.Delete(name);
                if (d == true)
                    MessageBox.Show("Deleted");
                else
                    MessageBox.Show("Could not Delet the item Name you inserted is invalid!!  ");
                
                this.ClearAll();
                this.PopulateGridView();
            }
            else MessageBox.Show("Can Not Delete the item");
        }

        private void dgvFoodItem_DoubleClick(object sender, EventArgs e)
        {
            this.txtFoodId.Text = this.dgvFoodItem.CurrentRow.Cells[1].Value.ToString();
            this.txtFoodName.Text = this.dgvFoodItem.CurrentRow.Cells[2].Value.ToString();
            this.cmbType.Text = this.dgvFoodItem.CurrentRow.Cells[3].Value.ToString();
            this.txtPrice.Text = this.dgvFoodItem.CurrentRow.Cells[4].Value.ToString();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FillEntity() == true)
            {
                bool d = fRepo.Save(f);
                if (d == true)
                    MessageBox.Show("Insert Done");
                else
                    MessageBox.Show("Insert Not Done");
                
                this.ClearAll();
                this.PopulateGridView();
            }
            else
                MessageBox.Show("Insert Not Done");
            this.PopulateGridView();
        }
       

        private bool FillEntity()
        {
            {
                if (this.txtFoodId.Text == "")
                {
                    this.LoadAutoFoodId();
                    
                    if (!IsValidToSave())
                        return false;
                    
                    f.foodid = this.txtFoodId.Text;
                    f.type = this.cmbType.Text;
                    f.name = this.txtFoodName.Text;
                    f.price = Convert.ToDouble(this.txtPrice.Text);
                    return true;
                }
                else 
                {
                    f.foodid = this.txtFoodId.Text;
                    f.type = this.cmbType.Text;
                    f.name = this.txtFoodName.Text;
                    f.price = Convert.ToDouble(this.txtPrice.Text);
                    return true;
                }
            }
        }
        private bool IsValidToSave()
        {
            if (Validation.IsStringValid(this.txtFoodName.Text) && Validation.IsStringValid(this.cmbType.Text) && Validation.IsStringValid(this.txtFoodName.Text) &&
                 Validation.IsFloatValid(this.txtPrice.Text))
            {
                if ((this.txtFoodId.Text != "") && (this.txtFoodName.Text != "") && (this.cmbType.Text != "") && (this.txtPrice.Text != ""))
                    return true;
                else return false;
            }
            else
                return false;
        }
        private bool IsValidToDelete()
        {
            if ((this.txtFoodId.Text != "")||(dgvFoodItem.SelectedRows.Count==1))
                return true;
            else 
            return false;
        }
        private void ClearAll()
        {

            this.txtFoodId.Clear();
            this.txtFoodName.Clear();
            this.txtPrice.Clear();
            this.cmbType.Text="";
        }

      


    }
}
