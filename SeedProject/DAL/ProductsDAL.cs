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
    internal class ProductsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select method
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            // datatable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Tbl_products";
                //to execute query 
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return dt;
        }
        #endregion
        #region Insert Method
        public bool Insert(ProductsBLL p)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            try
            {
                string sql = "INSERT INTO Tbl_products (prod_name, prod_category,description ,rate ,qnty,added_date ,added_by) VALUES (@prod_name, @prod_category,@description ,@rate ,@qnty,@added_date ,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, con);
                //passing values with parameters
                cmd.Parameters.AddWithValue("@prod_name", p.prod_name);
                cmd.Parameters.AddWithValue("@prod_category", p.prod_category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qnty", p.qnty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

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
        #region Update method
        public bool Update(ProductsBLL p)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            try
            {
                string sql = "UPDATE Tbl_products SET prod_name=@prod_name, prod_category=@prod_category,description=@description, rate=@rate,added_date=@added_date,added_by=@added_by WHERE Userid=@Userid";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@prod_name", p.prod_name);
                cmd.Parameters.AddWithValue("@prod_category", p.prod_category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qnty", p.qnty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@Userid", p.Userid);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
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
        #region Delete Method
        public bool Delete(ProductsBLL p)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            try
            {
                string sql = "DELETE FROM Tbl_products WHERE Userid=@Userid";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Userid", p.Userid);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    b = true;
                }
                else { b = false; }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            con.Close();
            return b;
        }
        #endregion
        #region Search method

        public DataTable search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Tbl_products WHERE Userid LIKE '%" + keywords + "%' OR prod_name LIKE '%" + keywords + "%' OR prod_category LIKE '%" + keywords + "%' ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }
        #endregion
        #region Method to search product in transaction module
        public ProductsBLL GetProductsForTransaction(string keyword)
        {
            ProductsBLL p = new ProductsBLL();

            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT prod_name, rate ,qnty FROM Tbl_products WHERE Userid LIKE '%" + keyword + "%' OR prod_name LIKE '%" + keyword + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.prod_name = dt.Rows[0]["prod_name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qnty = decimal.Parse(dt.Rows[0]["qnty"].ToString());


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return p;
        }
        #endregion
        #region Method to get Id based on product name
        public ProductsBLL GetProductIdFromName(string productname)
        {
            ProductsBLL p = new ProductsBLL();
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT Userid from Tbl_products WHERE prod_name='" + productname + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.Userid = int.Parse(dt.Rows[0]["Userid"].ToString());
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return p;
        }
        #endregion

        #region Method to get current quantity from the database based on product ID

        public decimal GetProductQty(int productid)
            {
                SqlConnection connection = new SqlConnection(myconnstrng);
                connection.Open();
                decimal qty = 0;
                DataTable dataTable = new DataTable();
                try
                {
                    string sql = "SELECT qnty FROM Tbl_products WHERE Userid= " + productid;
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        qty = decimal.Parse(dataTable.Rows[0]["qnty"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
                return qty;
            }
            #endregion
        #region  Method to update quantity
            public bool UpdateQuantity(int ProductID, decimal qnty)
            {
                bool b = false;
                SqlConnection conn = new SqlConnection(myconnstrng);
                conn.Open();
                try
                {
                    string sql = "UPDATE Tbl_products SET qnty=@qnty WHERE Userid=@Userid";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@qnty", qnty);
                    cmd.Parameters.AddWithValue("@Userid", ProductID);
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
                conn.Close();

                return b;
            }
            #endregion
            #region Method to increase product
            public bool IncreaseProduct(int ProductID, decimal IncreaseQnty)
            {
                bool b = false;
                SqlConnection conn = new SqlConnection(myconnstrng);
                conn.Open();
                try
                {
                    decimal CurrentQnty = GetProductQty(ProductID);
                    decimal NewQnty = CurrentQnty + IncreaseQnty;
                    b = UpdateQuantity(ProductID, NewQnty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                return b;
            }
            #endregion
        #region Method to decrese Product
            public bool DecreaseProduct(int ProductID, decimal qnty)
            {
                bool b = false;
                SqlConnection conn = new SqlConnection(myconnstrng);
                conn.Open();
                try
                {
                    decimal currentQty = GetProductQty(ProductID);
                    decimal NewQty = currentQty - qnty;
                    b = UpdateQuantity(ProductID, NewQty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                return b;
            }
        #endregion
        #region Display Products based on categories
        public DataTable DspalyProductsByCategories(string category)
        {
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Tbl_products WHERE prod_category='" + category + "'";
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return dt;

        }
        #endregion


    }
}
