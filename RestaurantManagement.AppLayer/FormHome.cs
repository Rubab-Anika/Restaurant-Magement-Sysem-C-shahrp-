using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin fl = new frmLogin();
            fl.Visible = true;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.Gray;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.Black;
        }
    }
}
