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
    public partial class DealCustForm : Form
    {
        public DealCustForm()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void pBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DealCustBLLcs d = new DealCustBLLcs();
        DeaCustDAL dcDAL = new DeaCustDAL();
        UserDAL uDAL = new UserDAL();
        private void btnADD_Click(object sender, EventArgs e)
        {
            d.type = comboBoxType.Text;
            d.name = txtName.Text;
            d.email = txtEmail.Text;
            d.contact = txtCont.Text;
            d.address = txtAddress.Text;
            d.added_date = DateTime.Now;

            string loggedUsr = LoginForm.loggedIn;
            UserBLL usr = uDAL.GetIdfromUsername(loggedUsr);
            d.added_by = usr.Userid;

            bool b = dcDAL.Insert(d);
            if (b == true)
            {
                MessageBox.Show("Dealer or customer added successfully ");
                clear();
                DataTable dt = dcDAL.Select();
                DGVdelCust.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed to add Dealer or customer ");
            }
        }
        public void clear()
        {
            txtDC.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCont.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void DealCustForm_Load(object sender, EventArgs e)
        {
            DataTable dt = dcDAL.Select();
            DGVdelCust.DataSource = dt;

        }

        private void DGVdelCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DGVdelCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtDC.Text = DGVdelCust.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxType.Text = DGVdelCust.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = DGVdelCust.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = DGVdelCust.Rows[rowIndex].Cells[3].Value.ToString();
            txtCont.Text = DGVdelCust.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = DGVdelCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            d.Userid=int.Parse(txtDC.Text);
            d.type = comboBoxType.Text; 
            d.name=txtName.Text; 
            d.email=txtEmail.Text;
            d.contact=txtCont.Text;
            d.address=txtAddress.Text;
            d.added_date=DateTime.Now;


            string loggedUsr = LoginForm.loggedIn;
            UserBLL usr = uDAL.GetIdfromUsername(loggedUsr);
            d.added_by = usr.Userid;

            bool b = dcDAL.Update(d);
            if(b==true)
            {
                MessageBox.Show("dealer or customer updated successfully ");
                clear();
                DataTable dt = dcDAL.Select();
                DGVdelCust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to update dealer or customer");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          d.Userid = int.Parse(txtDC.Text);
            bool b= dcDAL.Delete(d);
            if(b==true)
            {
                MessageBox.Show("Dealer or customer deleted successfully");
                clear() ;
                DataTable dt = dcDAL.Select();
                DGVdelCust.DataSource=dt;
            }
            else
            {
                MessageBox.Show("Failed to delete Dealer or customer ");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword =txtSearch.Text;
            if(keyword!= null)
            {
                DataTable dt=dcDAL.Search(keyword);
                DGVdelCust.DataSource= dt;
            }
            else
            {
                DataTable dt = dcDAL.Select();
                DGVdelCust.DataSource= dt;
            }

        }
    }
}
