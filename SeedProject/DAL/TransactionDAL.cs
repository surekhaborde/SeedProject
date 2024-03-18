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
    internal class TransactionDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Insert Transaction Method
        public bool Insert_transaction(TransactionBLL t,out int transactionID)
        {
            bool b = false;
            transactionID = -1;
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            try
            {
                string sql = "INSERT INTO Tbl_transactions (type,dealer_cust_id,grandTotal,transaction_date,tax,discount,added_by)VALUES (@type,@dealer_cust_id,@grandTotal,@transaction_date,@tax,@discount,@added_by);SELECT @@IDENTITY;";
           SqlCommand cmd= new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", t.type);
                cmd.Parameters.AddWithValue("@dealer_cust_id", t.dealer_cust_id);
                cmd.Parameters.AddWithValue("@grandtotal", t.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
                cmd.Parameters.AddWithValue("@tax", t.tax);
                cmd.Parameters.AddWithValue("@discount", t.discount);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

                object o =cmd.ExecuteScalar();
                if (o!= null)
                {
                    transactionID=int.Parse(o.ToString());
                    b= true;
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
        #region Method to display all the transactions
        public DataTable DisplayAllTransactions()
        {
            SqlConnection conn= new SqlConnection(myconnstrng);
            conn.Open();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Tbl_transactions";
                SqlCommand cmd= new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
        #region Method to display transaction based on transaction type
        public DataTable DisplatTransactionByType(string type)
        {
            SqlConnection con = new SqlConnection(myconnstrng);
            con.Open();
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Tbl_transactions WHERE type='"+type+"'";
                SqlCommand cmd=new SqlCommand(sql, con);
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
