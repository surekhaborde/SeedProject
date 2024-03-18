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
    internal class CategoriesDAL
    {
       // static string method for database connection string
       static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region select methods

        public DataTable Select()
        {
            //creating database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            DataTable dt = new DataTable();
            try
            {
                //writing sql to get all data from database
                string sql = "SELECT * FROM Tbl_Categories";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Adding the value from adpter to data table to dt
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return dt;
        }
        #endregion
        #region Insert new category
        public bool Insert(CategoriesBLL c)
        {
            
            bool b = false;
            
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            DataTable dt = new DataTable();
            try
            {
                
                string sql = "INSERT INTO Tbl_categories (title , description , added_date , added_by) VALUES (@title , @description , @added_date , @added_by)";
                
                SqlCommand cmd= new SqlCommand(sql,conn);
               
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description",c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
               
                int rows=cmd.ExecuteNonQuery();
               
                if(rows > 0)
                {
                    b = true;
                }
                else { 
                    b = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close() ;
            return b;
        }
        #endregion
        #region update method 

        public bool Update(CategoriesBLL c)
        {
            
           bool b=false;
           
            SqlConnection conn = new SqlConnection(myconnstrng) ;
            conn.Open();
            try
            {
                //Query to update category
                string sql = "UPDATE Tbl_Categories SET title=@title , description=@description ,added_date=@added_date," +
                    "added_by =@added_by WHERE Userid=@Userid";
                //sql command to pass the value on sql query
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@Userid", c.Userid);

                // create int variable to execute query
                int rows=cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    b = true;
                }
                else
                {
                    b = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return b;
        }
        #endregion
        #region delete category method

        public bool Delete(CategoriesBLL c)
        {
            
            bool b = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            try
            {
                
                string sql = "DELETE FROM Tbl_Categories WHERE Userid=@Userid";
                SqlCommand cmd= new SqlCommand(sql,con);
                con.Open();
                
                cmd.Parameters.AddWithValue("@Userid",c.Userid);

                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    b = true;
                }
                else { 
                    b = false;
                }

            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
            
            }
            con.Close();
            return b;
        }


        #endregion
        #region search method
        public DataTable Search(string keywords)
        {
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            DataTable dt = new DataTable();
            
            try
            {
                string sql = "Select * from Tbl_Categories where Userid like'%" + keywords + "%' or title like '%"+keywords+"%' or description like '%"+keywords+"%'";
                SqlCommand cmd= new SqlCommand(sql,con);
                
                SqlDataAdapter adapter= new SqlDataAdapter(cmd);
                adapter.Fill(dt);
;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return dt;
        }
        #endregion

    }
}
