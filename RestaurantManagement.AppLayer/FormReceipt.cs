
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
    public partial class FrmReceipt : Form
    {
        private static User Usr { get; set; }
        public FrmReceipt(List<OrderCart> oclist, double bill, string tableName,User usr)
        {
            InitializeComponent();
            this.GenerateBill(oclist, bill, tableName);
            Usr = usr;

        }
        public void GenerateBill(List<OrderCart> oclist, double bill, string tableName)
        {
            this.richTextBox1.Clear();
            this.richTextBox1.Text += "******************************************************************************\n";
            this.richTextBox1.Text += "**********************************Receipt*************************************\n";
            this.richTextBox1.Text += "******************************************************************************\n";
            this.richTextBox1.Text += "\n\n";
            this.richTextBox1.Text += "\n\n";
            this.richTextBox1.Text += "Date :  " + DateTime.Now + "\n\n";
            this.richTextBox1.Text += "\n\n";
            this.richTextBox1.Text += "  Order Table Name :                             " + tableName + "    \n ";
            this.richTextBox1.Text += "\n\n";
            this.richTextBox1.Text += "\n\n";
            this.richTextBox1.Text += "Food Name                     Quantity                     Price \n";
            this.richTextBox1.Text += "-------------------------------------------------------------------------------------\n";
            foreach (OrderCart or in oclist)
            {
                this.richTextBox1.Text += "" + or.FoodName + "                      " + or.Quantity + "                      " + or.price + "\n";
            }
            this.richTextBox1.Text += "---------------------------------------------------------------------------------\n";
            this.richTextBox1.Text += "Bill                :                                                         " + bill + "    \n";
            this.richTextBox1.Text += "Vat(5%)             :                                                      " + (bill * .05) + "\n";
            this.richTextBox1.Text += "TotalBill(Including Tax) :                                         " + (bill + (bill * 0.05)) + "\n";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            frmOrderCart foc = new frmOrderCart(Usr);
            foc . Visible = true;

        }

        private void UcMoneyReceit_Load(object sender, EventArgs e)
        {
        
        }
    }
}
