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
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }
        TransactionDAL tDAL=new TransactionDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            //Display all transactions
            DataTable dt = tDAL.DisplayAllTransactions();
            DGVTransactionsF.DataSource = dt;
        }

        private void comboBoxTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the value from comboBox
            string type=comboBoxTransactionType.Text;

            DataTable dt = tDAL.DisplatTransactionByType(type);
            DGVTransactionsF.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //Display all transactions
            DataTable dt = tDAL.DisplayAllTransactions();
            DGVTransactionsF.DataSource = dt;
        }
    }
    }

