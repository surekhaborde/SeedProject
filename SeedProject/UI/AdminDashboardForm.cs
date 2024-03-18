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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usersCategoryProductsInventoryTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm user = new UsersForm();
            user.Show();
        }

        private void AdminDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login=new LoginForm();
            login.Show();
            this.Hide();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = LoginForm.loggedIn;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesForm cat = new CategoriesForm();
            cat.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm();
            products.Show();
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealCustForm deal = new DealCustForm();
            deal.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm transaction = new TransactionForm();
            transaction.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = new InventoryForm();
            inventory.Show();
        }
    }
}
