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
    public partial class frmOrderCart : Form
    {
        private OrderCartRepo ocRepo = new OrderCartRepo();
        private OrderDetailRepo odRepo { get; set; }
        FoodTypeRepo tRepo = new FoodTypeRepo();
       
       private OrderDetailRepo odrRepo=new OrderDetailRepo();

        private static User Usr { get; set; }

        string OrderId;

        private void LoadAutoOrderId()
        {
            int serial = odrRepo.AutoIDValue();
            odrRepo.OrderId = (++serial).ToString("d4");
            this.OrderId= odrRepo.OrderId;
        }


        List<OrderCart> ordercartlist = new List<OrderCart>();
       
        static double bill = 0;

        public frmOrderCart(User usr)
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

        private void frmOrder_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void PopulateGridView()
        {
            //this.dgvCart.AutoGenerateColumns = false;
            this.cmbSelectTable.DataSource = ocRepo.FillTableComBo().ToList();
            this.cmbSelectTable.DisplayMember = "tname";
            this.cmbFoodType.DataSource = tRepo.FillTypeComBo().ToList();
            this.cmbFoodType.DisplayMember = "type";
            this.dgvCart.ClearSelection();
            this.cmbFoodName.Text = "";
            this.nudQuantity.Value = 0;
            this.txtPrice.Clear();
        }

        private void cmbFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ftype = this.cmbFoodType.Text;
            this.cmbFoodName.DataSource = ocRepo.FillFoodNameComBo(ftype).ToList();
            this.cmbFoodName.DisplayMember = "fname";
            
        }

        private void cmbFoodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fname = this.cmbFoodName.Text;
            this.txtPrice.Text = ocRepo.GetPrice(fname);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(ocRepo.GetPrice(this.cmbFoodName.Text));
            int quantity=Convert.ToInt32(this.nudQuantity.Value);
            this.txtPrice.Text =Convert.ToString( price * quantity);
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            bool d=Update(this.cmbFoodType.Text,this.cmbFoodName.Text);
            if (d == false)
            {
                this.AddData(this.cmbFoodType.Text, this.cmbFoodName.Text, this.nudQuantity.Value.ToString(), this.txtPrice.Text);
                this.dgvCart.ClearSelection();
            }
        }

        private bool Update(string type, string foodname)
        {
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (foodname == row.Cells[1].Value.ToString())
                {
                    this.UpdateData(row);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
                    return false;
     
        }
        private void AddData(string type, string name, string quantity, string price)
        {
            string []Row = { type, name, quantity, price };
            dgvCart.Rows.Add(Row);
            this.PopulateGridView();

        }
        private void UpdateData(DataGridViewRow row)
        {
            row.Cells[0].Value = this.cmbFoodType.Text;
            row.Cells[1].Value = this.cmbFoodName.Text;
            row.Cells[2].Value = nudQuantity.Value.ToString();
            row.Cells[3].Value = txtPrice.Text.ToString();
            this.PopulateGridView();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 1)
            {
                dgvCart.Rows.RemoveAt(dgvCart.CurrentCell.RowIndex);
                this.PopulateGridView();
                
            }
            else
                MessageBox.Show("PLease Select a value Before Delete ");
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to confirm Order", "Confirm Order", MessageBoxButtons.YesNo);

            if ((result == DialogResult.Yes)&&(dgvCart.Rows.Count!=0))
            {
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    OrderCart oc = new OrderCart();
                    oc.id = Convert.ToInt32(row.Cells[0].Value);
                    oc.FoodType = row.Cells[1].Value.ToString();
                    oc.FoodName = row.Cells[2].Value.ToString();
                    oc.Quantity = Convert.ToInt32(row.Cells[3].Value);
                    oc.price = Convert.ToDouble(row.Cells[4].Value);
                    bill = bill + oc.price;
                    ordercartlist.Add(oc);
                }
                this.Visible = false;
                FrmReceipt fr = new FrmReceipt(ordercartlist,bill,this.cmbSelectTable.Text,Usr);
               
                this.SaveIntoOrderDetail();
                fr.Visible = true;
            }
            else if (dgvCart.Rows.Count == 0)
            { MessageBox.Show("Please insert Food Before Order"); }
            
        }

        public void SaveIntoOrderDetail()
        {
            OrderDetailRepo OrRepo = new OrderDetailRepo();
            OrderDetail Or = new OrderDetail();
            this.LoadAutoOrderId();
            
            Or.orderId = OrderId;
            Or.tableName = this.cmbSelectTable.Text.ToString();
            Or.empId = Usr.userid;
            Or.date = DateTime.Today.Date;
            Or.totalBill = (bill + (bill * .05));
            OrRepo.Save(Or);


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure You want to leave this page Without Compleating Order ", "Leave Page", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                frmEmployee fe = new frmEmployee(Usr);
                fe.Visible = true;
            }
        }

        private void dgvCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cmbFoodType.Text = this.dgvCart.CurrentRow.Cells[0].Value.ToString();
            this.cmbFoodName.Text=this.dgvCart.CurrentRow.Cells[1].Value.ToString();
            this.nudQuantity.Value = Convert.ToInt32(this.dgvCart.CurrentRow.Cells[2].Value);
            this.txtPrice.Text = this.dgvCart.CurrentRow.Cells[3].Value.ToString();
            //dgvCart.Rows.RemoveAt(dgvCart.CurrentCell.RowIndex);
            //--count;
        }
        
    }
}
