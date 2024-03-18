using SeedProject.BLL;
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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        CategoriesBLL C=new CategoriesBLL();
        CategoriesDAL DAL=new CategoriesDAL();
        UserDAL UserDAL=new UserDAL();
        UserBLL UserBLL=new UserBLL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the values from categories form
            C.title=txtTitle.Text;
            C.description=txtDesc.Text;
            C.added_date=DateTime.Now;

            //GETTING ID IN ADDED BY FIELD
            string loggedUser = LoginForm.loggedIn;
            UserBLL usr=UserDAL.GetIdfromUsername(loggedUser);
            //passed the id of logged in user in added by field
            C.added_by = usr.Userid;

            //creating boolean method to insert data in database
            bool b = DAL.Insert(C);
            if (b == true)
            {
                //new category inserted
                MessageBox.Show("New category inserted ");
                clear();
                //refresh data grid view
                DataTable dt = DAL.Select();
                dGVcATEGORIES.DataSource = dt;
            }
            else
            {
                //failed to insert new category
                MessageBox.Show("Failed to insert new category");
            }


        }
        public void clear()
        {
            txtCatId.Text
                = string.Empty;
            txtTitle.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            // to display all the categories in data grid view
            DataTable dt = DAL.Select();
            dGVcATEGORIES.DataSource = dt;
        }

        private void dGVcATEGORIES_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // finding the row index of the row clicked on data grid view
            int rowIndex=e.RowIndex;
            //display the value from data grid view to txtbox category id
            txtCatId.Text = dGVcATEGORIES.Rows[rowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dGVcATEGORIES.Rows[rowIndex].Cells[1].Value.ToString();
            txtDesc.Text =dGVcATEGORIES.Rows[rowIndex].Cells[2].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get values from data grid view
            C.Userid=int.Parse(txtCatId.Text);
             C.title = txtTitle.Text;
            C.description = txtDesc.Text;
            C.added_date = DateTime.Now;
            //GETTING ID IN ADDED BY FIELD
            string loggedUser = LoginForm.loggedIn;
            UserBLL usr = UserDAL.GetIdfromUsername(loggedUser);
            //passed the id of logged in user in added by field
            C.added_by = usr.Userid;
            // creating the boolean variable to update category successfully and check
            bool b = DAL.Update(C);
            //if the category updated successfully then the value of b is true else false
            if (b==true)
            {
                MessageBox.Show("Category updated successfully.");
                clear();
                // refresh grid view
                DataTable dt =DAL.Select();
                dGVcATEGORIES.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update Category");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get id of category Which we want to delete
            C.Userid=int.Parse(txtCatId.Text);
            
            //creating boolean variable to delete the category
            bool b = DAL.Delete(C);
            if (b==true)
            {
                MessageBox.Show("Category deleted successfully.");
                clear();
                //refreshing data grid view
                DataTable dataTable = DAL.Select();
                dGVcATEGORIES.DataSource=dataTable;
            }
            else
            {
                MessageBox.Show("Failed to delete category.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords=txtSearch.Text;
            if (keywords!=null)
            {
                DataTable dt = DAL.Search(keywords);
                dGVcATEGORIES.DataSource=dt;

            }
            else
            {
                DataTable dt = DAL.Select();
                dGVcATEGORIES.DataSource = dt;
            }
           
        }
    }
}
