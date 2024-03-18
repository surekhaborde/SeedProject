using SeedProject.BLL;
using SeedProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeedProject.UI
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        CategoriesDAL cDAL= new CategoriesDAL();
        ProductsBLL p= new ProductsBLL();
        ProductsDAL pDAL= new ProductsDAL();
        UserDAL uDAL= new UserDAL();
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            //creating datatable to hold categories from database
            DataTable catDt = cDAL.Select();
            //specify datasource for category combobox
            comboBoxCategory.DataSource = catDt;
            comboBoxCategory.DisplayMember = "title";
            comboBoxCategory.ValueMember = "title";
            //load all the products in DGV
            DataTable dt=pDAL.Select();
            DGVproducts.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get all values from form
            p.prod_name = txtName.Text;
            p.prod_category = comboBoxCategory.Text;
            p.description=txtDesc.Text;
            p.rate=decimal.Parse(txtRate.Text);
            p.qnty = 0;
            p.added_date = DateTime.Now;
            string loggedUser = LoginForm.loggedIn;
            UserBLL usr=uDAL.GetIdfromUsername
                (loggedUser);
            p.added_by = usr.Userid;
            bool b=pDAL.Insert(p);
            if (b==true) {
                MessageBox.Show("Added Product successfully");
                clear();
                DataTable dt=pDAL.Select();
                DGVproducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to add product");
            }
            


        }
        public void clear()
        {
            txtPid.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.Userid=int.Parse(txtPid.Text);
            p.prod_name = txtName.Text;
            p.prod_category = comboBoxCategory.Text;
            p.description = txtDesc.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;
            string loggedUser = LoginForm.loggedIn;
            UserBLL usr = uDAL.GetIdfromUsername(loggedUser);
            p.added_by = usr.Userid;

            bool b = pDAL.Update(p);
            if (b == true)
            {
                MessageBox.Show("Product Updated successfully");
                clear();
                DataTable dt = pDAL.Select();
                DGVproducts.DataSource= dt;
            }
            else
            {
                MessageBox.Show("Failed to update product");
            }

        }

        private void DGVproducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // create integer variable to chk which product is selected
            int rowIndex = e.RowIndex;
            txtPid.Text = DGVproducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = DGVproducts.Rows[rowIndex].Cells[1].Value.ToString();

            comboBoxCategory.Text = DGVproducts.Rows[rowIndex].Cells[2].Value.ToString();

            txtDesc.Text = DGVproducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = DGVproducts.Rows[rowIndex].Cells[4].Value.ToString();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            p.Userid=int.Parse(txtPid.Text);
            bool b = pDAL.Delete(p);
            if (b == true)
            {
                MessageBox.Show("Product Deleted Successfully");
                clear();
                DataTable dt = pDAL.Select();
                DGVproducts.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed to delete product");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords=txtSearch.Text;
            if(keywords !=null)
            {
                DataTable dt = pDAL.search(keywords);
                DGVproducts.DataSource= dt;

            }
            else
            {
                DataTable dt=pDAL.Select();
                DGVproducts.DataSource= dt;

                
            }
        }
    }
}
