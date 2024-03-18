using DGVPrinterHelper;
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
using System.Transactions;
using System.Windows.Forms;

namespace SeedProject.UI
{
    public partial class PurchaseAndSaleForm : Form
    {
        public PurchaseAndSaleForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
        DeaCustDAL dcDAL = new DeaCustDAL();
        ProductsDAL pDAL=new ProductsDAL();
        UserDAL uDAL = new UserDAL();
        TransactionDAL tDAL= new TransactionDAL();
        TransactionDetailDAL tdDAL = new TransactionDetailDAL();

        DataTable transactDT= new DataTable();

        private void PurchaseAndSaleForm_Load(object sender, EventArgs e)
        {
            string type = frmUserDashBoard.transactionType;
            lbltop.Text = type;
            transactDT.Columns.Add("Product Name");
            transactDT.Columns.Add("Rate");
            transactDT.Columns.Add("Quantity");

            transactDT.Columns.Add("Total");


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keyword from text box
            string keyword=txtSearch.Text;
            if(keyword =="")
            {
                txtName.Text = "";
                txtEmail.Text = string.Empty;
                txtContact.Text = string.Empty;
                txtAddress.Text = string.Empty;
                return;
            }
            DealCustBLLcs dc=dcDAL.SearchDealerCustomrForTransaction(keyword);
            txtName.Text=dc.name; 
            txtEmail.Text=dc.email;
            txtContact.Text=dc.contact;
            txtAddress.Text=dc.address;
        }

        private void txtPSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword= txtPSearch.Text;

            if(keyword == "")
            {
                txtPName.Text = " ";
                txtPInventr.Text =" ";
                txtPRate.Text =" ";
                txtQnty.Text =" ";
                return;
            }
            // search the product and display on respective textboxes
            ProductsBLL p=pDAL.GetProductsForTransaction(keyword);
            txtPName.Text = p.prod_name;
            txtPInventr.Text=p.qnty.ToString();
            txtPRate.Text=p.rate.ToString();
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
              string productName= txtPName.Text;
            decimal Rate=decimal.Parse(txtPRate.Text);
            decimal quantity =decimal.Parse(txtQnty.Text);
            decimal Total=Rate*quantity;
            decimal SubTotal=decimal.Parse(txtSubTot.Text);
            SubTotal = SubTotal + Total;

            if(productName == "")
            {
                MessageBox.Show("Select the product ");
            }
            else
            {
                transactDT.Rows.Add(productName,Rate,quantity,Total);
                DGVAddedProd.DataSource = transactDT;
                txtSubTot.Text=SubTotal.ToString();

                txtPSearch.Text = "";
                txtPName.Text = "";
                txtPInventr.Text = "0.00";
                txtPRate.Text = "0.00";
                txtQnty.Text = "0.00";
            }
        }

        private void txtDisc_TextChanged(object sender, EventArgs e)
        {
            string value = txtDisc.Text;
            if(value == "")
            {
                MessageBox.Show("Please add Discount");
            }
            else
            {
                decimal SubTotal=decimal.Parse(txtSubTot.Text);
                decimal discount=decimal.Parse(txtDisc.Text);
                decimal grandTotal = ((100 - discount) / 100) * SubTotal;
                txtGrandTOT.Text = grandTotal.ToString();
            }
        }

        private void txtGST_TextChanged(object sender, EventArgs e)
        {
            string check = txtGrandTOT.Text;
            if(check =="")
            {
                MessageBox.Show("First Calculate Discount and set Grand total");
            }
            else
            {
                decimal previousGrandtot = decimal.Parse(txtGrandTOT.Text);
                decimal gst= decimal.Parse(txtGST.Text);
                decimal grandTotalWithGSt = ((100 + gst) / 100) * previousGrandtot;

                //display new grand total with gst
                txtGrandTOT.Text=grandTotalWithGSt.ToString();
            }
        }

        private void txtPaidAmt_TextChanged(object sender, EventArgs e)
        {
            decimal grandtotal = decimal.Parse(txtGrandTOT.Text);
            decimal paidAmount=decimal.Parse(txtPaidAmt.Text);
            decimal returnAmount=paidAmount-grandtotal;
            txtReturnAmnt.Text = returnAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TransactionBLL trans=new TransactionBLL();
            trans.type=lbltop.Text;
            string deaCustName=txtName.Text;
            DealCustBLLcs dc=dcDAL.GetDeaCustIdFromName(deaCustName);
            trans.dealer_cust_id = dc.Userid;
            trans.grandTotal = Math.Round(decimal.Parse(txtGrandTOT.Text),2);
            trans.transaction_date = DateTime.Now;
            trans.tax=decimal.Parse(txtGST.Text);
            trans.discount = decimal.Parse(txtDisc.Text);

            string username = LoginForm.loggedIn;
            UserBLL u= uDAL.GetIdfromUsername(username);
             trans.added_by=u.Userid;
            trans.TransactionDetails = transactDT;

            bool b = false;
            using (TransactionScope scope = new TransactionScope())
            {
                int transactionId = -1;
                bool w=tDAL.Insert_transaction(trans,out transactionId);

                //use the for loop to add transaction details
                for(int i = 0;i<transactDT.Rows.Count;i++)
                {
                    TransactionDetailBLL transDtl=new TransactionDetailBLL();
                    string ProductName = transactDT.Rows[i][0].ToString();
                    ProductsBLL p=pDAL.GetProductIdFromName(ProductName);
                    transDtl.product_id = p.Userid;
                    transDtl.rate = decimal.Parse(transactDT.Rows[i][1].ToString());
                    transDtl.qty = decimal.Parse(transactDT.Rows[i][2].ToString());
                    transDtl.total = Math.Round(decimal.Parse(transactDT.Rows[i][3].ToString()),2);

                    transDtl.dea_cust_id = dc.Userid;
                    transDtl.added_date = DateTime.Now;
                    transDtl.added_by = u.Userid;

                    // Increase or decrease product quantity based on purchase or sales
                    string transactionType=lbltop.Text;
                    bool x = false;
                    //lets check whether we are on purchase or sale
                    if(transactionType =="Purchase")
                    {
                         x = pDAL.IncreaseProduct(transDtl.product_id, transDtl.qty);
                    }
                    else if(transactionType =="Sales")
                    {
                         x=pDAL.DecreaseProduct(transDtl.product_id,transDtl.qty);
                    }

                    //insert transaction detail inside the database
                    bool y =tdDAL.InsertTransactionDetail(transDtl);
                    b = w && x && y;

                }
              
                if (b == true)
                {
                    scope.Complete();

                    //Code to print Bill
                     
                    DGVPrinter printer= new DGVPrinter();
                    printer.Title = "\r\n\r\n\r\n HAPPY MARKET PLACE \r\n\r\n ";
                    printer.SubTitle = "Pune ,Maharashtra \r\n Phn.no.:XXXXXXXXXX \r\n\r\n";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Discount :" + txtDisc.Text + "%\r\n " + "GST :" + txtGST.Text + " % \r\n"+ "Grand Total :" + txtGrandTOT + "\r\n\r\n"+ "THANK YOU , VISIT AGAIN ";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(DGVAddedProd);


                    MessageBox.Show("Transaction Completed");
                    DGVAddedProd.DataSource = null;
                    DGVAddedProd.Rows.Clear();  

                    txtSearch.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                    txtContact.Text = string.Empty;

                    txtPSearch.Text = string.Empty;
                    txtPName.Text = string.Empty;
                    txtPInventr.Text = "0";
                    txtPRate.Text = "0";
                    txtQnty.Text = "0";

                    txtSubTot.Text = "0";
                    txtDisc.Text = "0";
                    txtGST.Text = "0";
                    txtGrandTOT.Text = "0";
                    txtPaidAmt.Text = "0";
                    txtReturnAmnt.Text = "0";

                }
                else
                {
                    MessageBox.Show("Transation Failed");
                }

            }


        }
    }
}
