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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        UserBLL u = new UserBLL();
        UserDAL userDAL = new UserDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string loggedUser = LoginForm.loggedIn;
            //getting data from UI
            u.first_name=txtFirstName.Text;
            u.last_name=txtLastName.Text;
            u.email=txtEmail.Text;
            u.username=txtUsername.Text;
            u.password=txtPass.Text;
            u.contact=txtContact.Text;
            u.address=txtAdd.Text;    
            u.gender= comboBoxGender.Text;
            u.user_type = comboBoxUserType.Text;
            u.added_date = DateTime.Now;

            // getting user name from the logged user
            UserBLL userBLL = userDAL.GetIdfromUsername(loggedUser);
            u.added_by = userBLL.Userid;

            //Inserting data into database
            bool success=userDAL.Insert(u);
            if (success==true) {
                //Data successfully Inserted
                MessageBox.Show("User successfully created!!!!!");
                clear();
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed to add new user....");
            }
            //Refreshing gridview
            DataTable dt = userDAL.Select();
            dGVUsers.DataSource= dt;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            DataTable dt = userDAL.Select();
            dGVUsers.DataSource = dt;

        }

        private void clear()
        {
            txtUserId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPass.Text = "";
            txtContact.Text = "";
            txtAdd.Text = "";
            comboBoxGender.Text = "";
            comboBoxUserType.Text = "";
        }

        private void dGVUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // get index of perticular row
            int rowIndex = e.RowIndex;
            txtUserId.Text = dGVUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dGVUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dGVUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dGVUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dGVUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPass.Text = dGVUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dGVUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAdd.Text = dGVUsers.Rows[rowIndex].Cells[7].Value.ToString();
            comboBoxGender.Text = dGVUsers.Rows[rowIndex].Cells[8].Value.ToString();
            comboBoxUserType.Text = dGVUsers.Rows[rowIndex].Cells[9].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the value from user ui
            u.Userid=Convert.ToInt32(txtUserId.Text);
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPass.Text;
            u.contact = txtContact.Text;
            u.address=txtAdd.Text;
            u.gender = comboBoxGender.Text;
            u.user_type = comboBoxUserType.Text;
            u.added_date= DateTime.Now;
            u.added_by = 1;

            //updating Data into database
            bool success = userDAL.Update(u);
            if (success == true)
            {
                MessageBox.Show("User Updated Successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to updated the User");
            }
            //Refreshing data in grid view
            DataTable dt = userDAL.Select();
            dGVUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.Userid= Convert.ToInt32(txtUserId.Text);
            bool success = userDAL.Delete(u);
            if(success == true)
            {
                MessageBox.Show("User deleted Successfully!!!!");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete user!!!!");
            }
            DataTable dt = userDAL.Select();
            dGVUsers.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get keyword from Text Box
            string keywords=txtSearch.Text;

            // check if keywords has value or not
            if(keywords!=null)
            {
                //show user based on keywords
                DataTable dt = userDAL.Search(keywords);
                dGVUsers.DataSource= dt;
            }
            else
            {
                //show all users from databasse
                DataTable dt = userDAL.Select();
                dGVUsers.DataSource = dt;
            }
        }
    }
}
