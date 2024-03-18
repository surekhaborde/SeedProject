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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        LoginBLL l = new LoginBLL();
        LoginDAL DAL = new LoginDAL();
        public static string loggedIn;

        private void pBoxClose_Click(object sender, EventArgs e)
        {
            //close the login form
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.UserName =txtUserName.Text.Trim();
            l.password =txtPassword.Text.Trim();
            l.user_type=comboBoxUserType.Text.Trim();

            //checking login credentials

            bool success=DAL.loginCheck(l);
            if(success==true)
            {
                //login successful
                MessageBox.Show("Login Successful.");
                loggedIn=l.UserName;
            //
            switch(l.user_type)
                {
                    case "Admin":
                        {
                            //To dispaly admin dashboard
                            AdminDashboardForm Ad = new AdminDashboardForm();
                            Ad.Show();
                            this.Hide();

                        }
                        break;
                    case "User":
                        {
                            //To display user dashboard
                            frmUserDashBoard Ud = new frmUserDashBoard();
                            Ud.Show();
                            this.Hide();

                        }
                        break;
                    default:
                        {
                            //Dispaly an error message
                            MessageBox.Show("Invalid User Type");
                        
                        }
                        break;
                }
            
            
            }
            else
            {
                MessageBox.Show("Login Failed. Try Again");
            }

        }
    }
}
