using SeedProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeedProject.DAL
{
    internal class TransactionDetailDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert method for transaction details
        public bool InsertTransactionDetail(TransactionDetailBLL td)
        {
            bool b=false;
            SqlConnection conn=new SqlConnection(myconnstrng);
            conn.Open();
            try
            {
                string sql = "INSERT INTO Tbl_detail (product_id,rate,qty,total,dea_cust_id,added_date,added_by) VALUES (@product_id,@rate,@qty,@total,@dea_cust_id,@added_date,@added_by)";
                SqlCommand cmd=new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

                int rows=cmd.ExecuteNonQuery();
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
    }
}
