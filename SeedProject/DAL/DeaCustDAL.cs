using SeedProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeedProject.DAL
{
    internal class DeaCustDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select method
        public DataTable Select()
        {
            SqlConnection conn=new SqlConnection(myconnstrng);
            conn.Open();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Tbl_dealer_customer ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return dt;
        }
        #endregion
        #region Insert  method
        public bool Insert(DealCustBLLcs d )
        {

            bool b= false;
            SqlConnection connection = new SqlConnection(myconnstrng);
            connection.Open();
            try
            {
                string sql = "INSERT INTO Tbl_dealer_customer (type , name, email,contact ,address,added_date, added_by) VALUES (@type , @name, @email,@contact ,@address,@added_date, @added_by) ";
                 SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@type", d.type);
                cmd.Parameters.AddWithValue("@name", d.name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                int rows=cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    b = true;
                  
                }
                else
                {
                    b= false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            return b;
        }
        #endregion
        #region Update method
        public bool Update(DealCustBLLcs d)
        {
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            bool b = false;
            try
            {
                string sql = "Update Tbl_dealer_customer SET type=@type , name=@name , email=@email, contact=@contact, address=@address, added_date=@added_date ,added_by=@added_by WHERE Userid=@Userid";

                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@type",d.type);
                cmd.Parameters.AddWithValue("@name", d.name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                cmd.Parameters.AddWithValue("@Userid", d.Userid);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                   b |= true;
                }
                else { 
                    b = false;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return b;
        }
        #endregion
        #region Delete Method
        public bool Delete(DealCustBLLcs d)
        {
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            bool b = false;
            try
            {
                string sql = "DELETE FROM Tbl_dealer_customer WHERE Userid=@Userid";
                SqlCommand cmd= new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@Userid", d.Userid);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
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
            con.Close();
            return b;

        }
        #endregion
        #region Search method for dealer and customer module
        public DataTable Search(string keyword)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            DataTable dt=new DataTable();
            try
            {
                string sql = "SELECT * FROM Tbl_dealer_customer WHERE Userid LIKE '%" + keyword + "%' OR type LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
                SqlCommand cmd=new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch(Exception ex) { 
            
               MessageBox.Show(ex.Message);
            }
            conn.Close();
            return dt;
        }
        #endregion 
        #region method to search dealer or customer transaction module
        public DealCustBLLcs SearchDealerCustomrForTransaction(string keyword)
        {
            DealCustBLLcs dc= new DealCustBLLcs();

          
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT name, email,contact, address FROM Tbl_dealer_customer WHERE Userid LIKE '%"+keyword+"%' OR name LIKE '%"+keyword+"%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address= dt.Rows[0]["address"].ToString();

                }
                else
                {

                }
            
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close() ;
            return dc;
        }
        #endregion
        #region method to get id of the dealer or customer based on name
        public DealCustBLLcs GetDeaCustIdFromName(string name)
        {
            DealCustBLLcs dc=new DealCustBLLcs();
            SqlConnection con =new SqlConnection(myconnstrng);
            con.Open();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT Userid from Tbl_dealer_customer WHERE name='" + name + "'";
                SqlDataAdapter adapter = new SqlDataAdapter( sql,con);
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    dc.Userid = int.Parse(dt.Rows[0]["Userid"].ToString());
                }
                else { 
                
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close() ;
            return dc;
        }
        #endregion
    }
}
