using SeedProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeedProject.DAL
{
    internal class UserDAL
    {

        static string myconnstrng= ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Data from Database
        public DataTable Select()
        {
            //sql connection to connect with database
            SqlConnection con= new SqlConnection(myconnstrng);

            // to create object of Datatable to hold data from database
            DataTable dt =new DataTable();
            try
            {
                //sql query to get data from database
                string sql = "SELECT * FROM Tbl_Users";
                //For executing Command
                SqlCommand cmd = new SqlCommand(sql, con);
                //Getting data fron database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //database connection open
                con.Open();
                //fill data from datatable
                adapter.Fill(dt);
               
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //return value to datatable
            return dt;
        }
        #endregion
        #region Insert data in database
        public bool Insert(UserBLL u)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            try
            {
                string sql = "INSERT INTO Tbl_Users (first_name,last_name,email,username,password,contact," +
                    "address,gender,user_type,added_date,added_by) VALUES (@first_name ,@last_name,@email," +
                    "@username,@password,@contact,@address,@gender,@user_type,@added_date,@added_by)";

                SqlCommand cmd1 = new SqlCommand(sql, con);
                cmd1.Parameters.AddWithValue("@first_name",u.first_name);
                cmd1.Parameters.AddWithValue("@last_name", u.last_name);
                cmd1.Parameters.AddWithValue("@email", u.email);
                cmd1.Parameters.AddWithValue("@username", u.username);
                cmd1.Parameters.AddWithValue("@password", u.password);
                cmd1.Parameters.AddWithValue("@contact", u.contact);
                cmd1.Parameters.AddWithValue("@address", u.address);
                cmd1.Parameters.AddWithValue("@gender", u.gender);
                cmd1.Parameters.AddWithValue("@user_type", u.user_type);
                cmd1.Parameters.AddWithValue("@added_date", u.added_date);
                cmd1.Parameters.AddWithValue("@added_by", u.added_by);
                int rows=cmd1.ExecuteNonQuery();

                // if the query is executed successfully the the value to 
                if(rows>0)
                {
                    b = true;
                }
                else { b = false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return b;
        }
        #endregion
        #region Update data in database
        public bool Update(UserBLL u)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            try
            {
                string sql = ("Update Tbl_Users SET first_name=@first_name ,last_name =@last_name," +
                    "email=@email,username=@username,password=@password,contact =@contact," +
                      "address=@address,gender=@gender,user_type=@user_type,added_date=@added_date," +
                      "added_by=@added_by WHERE Userid=@Userid");
                SqlCommand cmd = new SqlCommand(sql, con);
               // cmd.Parameters.AddWithValue("@Userid", u.Userid);
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@Userid", u.Userid);
                int rows=cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    b = true;
                }
                else { b = false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
                return b;
        }
        #endregion
        #region Delete data from database
        public bool Delete(UserBLL u)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM Tbl_Users WHERE Userid=@Userid";
                SqlCommand cmd= new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Userid", u.Userid);
                con.Open();
                int rows=cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    //query success
                    b = true;
                }
                else { 
                    //Query fail
                    b = false; }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            
            }
            con.Close();
            return b;
        }
        #endregion
        #region search user on database using keywords 

        public DataTable Search(string keywords)
        {
            //sql connection to connect with database
            SqlConnection con = new SqlConnection(myconnstrng);

        // to create object of Datatable to hold data from database
        DataTable dt = new DataTable();
            try
            {
                //sql query to get data from database
                string sql = "SELECT * FROM Tbl_Users WHERE Userid LIKE '%"+keywords+"%' OR" +
                    " first_name LIKE '%"+keywords+ "%' OR " +
                    " last_name LIKE '%"+keywords+"%' OR  username LIKE '%"+keywords+"%' ";
        //For executing Command
        SqlCommand cmd = new SqlCommand(sql, con);
        //Getting data fron database
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //database connection open
        con.Open();
                //fill data from datatable
                adapter.Fill(dt);
               
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             //return value to datatable
                  return dt;
        }
        #endregion
        #region getting user id from user name
        public UserBLL GetIdfromUsername(string username)
        {
            UserBLL userBLL = new UserBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT UserId FROM Tbl_users WHERE username = '" + username + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    userBLL.Userid = int.Parse(dt.Rows[0]["UserId"].ToString());
                }
            }
            catch(
            Exception ex )
            {
                
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return userBLL;
           
        }
        #endregion
    }
}
