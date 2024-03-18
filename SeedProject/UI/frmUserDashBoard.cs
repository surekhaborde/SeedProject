using SeedProject.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeedProject
{
    public partial class frmUserDashBoard : Form
    {
        public frmUserDashBoard()
        {
            InitializeComponent();
        }
        //public static method to specify whether the form is purchase or sales
        public static string transactionType;
        private void frmUserDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void frmUserDashBoard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = LoginForm.loggedIn;
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealCustForm Deal=new DealCustForm();
            Deal.Show();
        }

        private void menuStripTop_Click(object sender, EventArgs e)
        {
            //set value on transactionType static method to purchase
            transactionType = "Purchase";
            PurchaseAndSaleForm purchase = new PurchaseAndSaleForm();
            purchase.Show();
           
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set value on transactionType static method to sales
            transactionType = "Sales";
            PurchaseAndSaleForm sales = new PurchaseAndSaleForm();
            sales.Show();
           

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = new InventoryForm();
            inventory.Show();
        }
    }
}
