using SeedProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeedProject.UI
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }
        CategoriesDAL cDAL= new CategoriesDAL();
        ProductsDAL pDAL= new ProductsDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            //Display the categories in combo box
            DataTable cdt = cDAL.Select();
            comboBoxCategories.DataSource = cdt;

            //Give the value member and display member for combo box
            comboBoxCategories.DisplayMember = "title";
            comboBoxCategories.ValueMember = "title";

            //Diaplay all the products in data grid view
            DataTable pdt = pDAL.Select();
            DGVProducts.DataSource = pdt;
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // display all the products based on selected Category
            string category = comboBoxCategories.Text;
            DataTable dt=pDAL.DspalyProductsByCategories(category);
            DGVProducts.DataSource= dt;
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            DataTable dt=pDAL.Select();
            DGVProducts.DataSource=dt;
        }
    }
}
