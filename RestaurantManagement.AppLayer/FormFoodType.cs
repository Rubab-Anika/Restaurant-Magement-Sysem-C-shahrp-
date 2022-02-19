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
    public partial class FormFoodType : Form
    {
        private FoodTypeRepo fRepo { get; set; }
        private FoodType t { get; set; }
        private User Usr { get; set; }
        private static string tId;
        private void LoadAutoTypeId()
        {
            int serial = fRepo.AutoIDValue();
            fRepo.TypeId = (++serial).ToString("d4");
            tId = fRepo.TypeId;
        }
        public FormFoodType(User user)
        {
            InitializeComponent();
            this.fRepo = new FoodTypeRepo();
            this.t = new FoodType();
            this.Usr = user;
        }

        private void dgvFoodItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormFoodType_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        private void PopulateGridView()
        {
            this.dgvFoodType.AutoGenerateColumns = false;
            this.dgvFoodType.DataSource = fRepo.GetAll().ToList();
            this.dgvFoodType.ClearSelection();
            tId = "";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmManager fm = new frmManager(Usr);
            fm.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtFoodType.Clear();
            this.PopulateGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.FillEntity() == true)
            {
                bool d = fRepo.Save(t);
                if (d == true)
                { MessageBox.Show("Insert Done"); }
                else
                { MessageBox.Show("Insert Not Done"); }

               
                this.PopulateGridView();
            }
            else
                MessageBox.Show("Insert Not Done");
        }
        private bool FillEntity()
        {
            {
                if (tId == "")
                {
                    this.LoadAutoTypeId();

                    if (!IsValidToSave())
                        return false;

                    t.typeId = tId;
                    t.typeName = this.txtFoodType.Text;
                    return true;
                }
                else
                {
                    t.typeId = tId;
                    t.typeName = this.txtFoodType.Text;
                    return true;
                }
            }
        }
        private bool IsValidToSave()
        {
            if (Validation.IsStringValid(this.txtFoodType.Text))
            {
                if (this.txtFoodType.Text != "")
                    return true;
                else return false;
            }
            else
                return false;
        }

        private void dgvFoodType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tId = this.dgvFoodType.CurrentRow.Cells[0].Value.ToString();
            this.txtFoodType.Text = this.dgvFoodType.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            bool a = this.IsValidToDelete();
            if (a == true)
            {
                DialogResult result = MessageBox.Show("Are you sure You want to Delete This Food Type And All The Food Item Belong This Type", "Warning!!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool d = fRepo.Delete(this.dgvFoodType.CurrentRow.Cells[0].Value.ToString());
                    if (d == true)
                    {
                        MessageBox.Show("Deleted");
                        FoodItemRepo frRepo = new FoodItemRepo();
                        frRepo.DeleteByType(this.txtFoodType.Text);
                        this.PopulateGridView();
                    }
                    else
                        MessageBox.Show("Could not Delete the item Name you inserted is invalid!!  ");


                    this.PopulateGridView();
                }
                else 
                    this.PopulateGridView();
                
            }
            else
                MessageBox.Show("Could not Delete the item Type you inserted is invalid!!  ");
        }
        private bool IsValidToDelete()
        {
            if ((tId != "") || (dgvFoodType.SelectedRows.Count == 1))
                return true;
            else
                return false;
        }
    }
}
