using SeedProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeedProject.DAL
{
    internal class LoginDAL
    {
        // static string method to connect to dATABASE
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
         
         public bool loginCheck(LoginBLL l)
        {
            //create a boolean variable and set its value to false and return it
             bool b = false;
            //connecting to the database create connection string

            SqlConnection conn= new SqlConnection(myconnstrng);

            conn.Open();

            try
            {
                //sql query to check login
                string sql = "SELECT * FROM Tbl_Users WHERE username=@username AND password=@password AND user_type=@user_type";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", l.UserName);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);

                //sql dataadapter to hold data temporarily

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //checking the rows in datatable
                if(dt.Rows.Count>0)
                {
                    b = true;

                }
                else { 
                b= false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return b;
        }
    
    }
}
