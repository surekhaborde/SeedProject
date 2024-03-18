namespace SeedProject.UI
{
    partial class PurchaseAndSaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseAndSaleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.pnlPurSal = new System.Windows.Forms.Panel();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDCDetails = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInven = new System.Windows.Forms.Label();
            this.lblQnty = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblProdSearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPSearch = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPInventr = new System.Windows.Forms.TextBox();
            this.txtPRate = new System.Windows.Forms.TextBox();
            this.txtQnty = new System.Windows.Forms.TextBox();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDGVTitl = new System.Windows.Forms.Label();
            this.DGVAddedProd = new System.Windows.Forms.DataGridView();
            this.pnlAddCalcu = new System.Windows.Forms.Panel();
            this.lblCalDet = new System.Windows.Forms.Label();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.lblPaidAmnt = new System.Windows.Forms.Label();
            this.lblGrandTot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiscont = new System.Windows.Forms.Label();
            this.lblRetnAmnt = new System.Windows.Forms.Label();
            this.txtSubTot = new System.Windows.Forms.TextBox();
            this.txtGrandTOT = new System.Windows.Forms.TextBox();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.txtPaidAmt = new System.Windows.Forms.TextBox();
            this.txtReturnAmnt = new System.Windows.Forms.TextBox();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.pnlPurSal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAddedProd)).BeginInit();
            this.pnlAddCalcu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lbltop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 50);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1337, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1448, 2);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(49, 44);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop.ForeColor = System.Drawing.Color.White;
            this.lbltop.Location = new System.Drawing.Point(611, 9);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(204, 28);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "PURCHASE AND SALE";
            // 
            // pnlPurSal
            // 
            this.pnlPurSal.Controls.Add(this.dTP);
            this.pnlPurSal.Controls.Add(this.txtName);
            this.pnlPurSal.Controls.Add(this.txtAddress);
            this.pnlPurSal.Controls.Add(this.txtContact);
            this.pnlPurSal.Controls.Add(this.txtEmail);
            this.pnlPurSal.Controls.Add(this.txtSearch);
            this.pnlPurSal.Controls.Add(this.lblDate);
            this.pnlPurSal.Controls.Add(this.lblDCDetails);
            this.pnlPurSal.Controls.Add(this.lblAddress);
            this.pnlPurSal.Controls.Add(this.lblSearch);
            this.pnlPurSal.Controls.Add(this.lblContact);
            this.pnlPurSal.Controls.Add(this.lblName);
            this.pnlPurSal.Controls.Add(this.lblEmail);
            this.pnlPurSal.Location = new System.Drawing.Point(12, 55);
            this.pnlPurSal.Name = "pnlPurSal";
            this.pnlPurSal.Size = new System.Drawing.Size(1365, 130);
            this.pnlPurSal.TabIndex = 3;
            // 
            // dTP
            // 
            this.dTP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP.Location = new System.Drawing.Point(1125, 41);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(200, 30);
            this.dTP.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(104, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 30);
            this.txtName.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(809, 43);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(208, 73);
            this.txtAddress.TabIndex = 11;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(473, 90);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(208, 30);
            this.txtContact.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(473, 43);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 30);
            this.txtEmail.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(104, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 30);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1046, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Bill Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblDCDetails
            // 
            this.lblDCDetails.AutoSize = true;
            this.lblDCDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDCDetails.Location = new System.Drawing.Point(25, 10);
            this.lblDCDetails.Name = "lblDCDetails";
            this.lblDCDetails.Size = new System.Drawing.Size(244, 23);
            this.lblDCDetails.TabIndex = 0;
            this.lblDCDetails.Text = "Dealer and Customer Details ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(733, 47);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 23);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(25, 47);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 23);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(393, 93);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(70, 23);
            this.lblContact.TabIndex = 5;
            this.lblContact.Text = "Contact";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(25, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 23);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(393, 47);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPAdd);
            this.panel2.Controls.Add(this.txtQnty);
            this.panel2.Controls.Add(this.txtPRate);
            this.panel2.Controls.Add(this.txtPInventr);
            this.panel2.Controls.Add(this.txtPName);
            this.panel2.Controls.Add(this.txtPSearch);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblInven);
            this.panel2.Controls.Add(this.lblQnty);
            this.panel2.Controls.Add(this.lblRate);
            this.panel2.Controls.Add(this.lblProdSearch);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(12, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 100);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // lblInven
            // 
            this.lblInven.AutoSize = true;
            this.lblInven.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInven.Location = new System.Drawing.Point(509, 39);
            this.lblInven.Name = "lblInven";
            this.lblInven.Size = new System.Drawing.Size(85, 23);
            this.lblInven.TabIndex = 4;
            this.lblInven.Text = "Inventory";
            // 
            // lblQnty
            // 
            this.lblQnty.AutoSize = true;
            this.lblQnty.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQnty.Location = new System.Drawing.Point(963, 38);
            this.lblQnty.Name = "lblQnty";
            this.lblQnty.Size = new System.Drawing.Size(77, 23);
            this.lblQnty.TabIndex = 3;
            this.lblQnty.Text = "Quantity";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(743, 39);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(45, 23);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Rate";
            // 
            // lblProdSearch
            // 
            this.lblProdSearch.AutoSize = true;
            this.lblProdSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdSearch.Location = new System.Drawing.Point(25, 39);
            this.lblProdSearch.Name = "lblProdSearch";
            this.lblProdSearch.Size = new System.Drawing.Size(61, 23);
            this.lblProdSearch.TabIndex = 1;
            this.lblProdSearch.Text = "Search";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Details";
            // 
            // txtPSearch
            // 
            this.txtPSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSearch.Location = new System.Drawing.Point(93, 39);
            this.txtPSearch.Name = "txtPSearch";
            this.txtPSearch.Size = new System.Drawing.Size(176, 30);
            this.txtPSearch.TabIndex = 7;
            this.txtPSearch.TextChanged += new System.EventHandler(this.txtPSearch_TextChanged);
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(348, 39);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(142, 30);
            this.txtPName.TabIndex = 8;
            // 
            // txtPInventr
            // 
            this.txtPInventr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPInventr.Location = new System.Drawing.Point(600, 35);
            this.txtPInventr.Name = "txtPInventr";
            this.txtPInventr.Size = new System.Drawing.Size(124, 30);
            this.txtPInventr.TabIndex = 9;
            // 
            // txtPRate
            // 
            this.txtPRate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRate.Location = new System.Drawing.Point(794, 36);
            this.txtPRate.Name = "txtPRate";
            this.txtPRate.Size = new System.Drawing.Size(142, 30);
            this.txtPRate.TabIndex = 10;
            // 
            // txtQnty
            // 
            this.txtQnty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQnty.Location = new System.Drawing.Point(1046, 36);
            this.txtQnty.Name = "txtQnty";
            this.txtQnty.Size = new System.Drawing.Size(137, 30);
            this.txtQnty.TabIndex = 11;
            // 
            // btnPAdd
            // 
            this.btnPAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAdd.ForeColor = System.Drawing.Color.White;
            this.btnPAdd.Location = new System.Drawing.Point(1222, 31);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(115, 38);
            this.btnPAdd.TabIndex = 12;
            this.btnPAdd.Text = "ADD";
            this.btnPAdd.UseVisualStyleBackColor = false;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGVAddedProd);
            this.panel3.Controls.Add(this.lblDGVTitl);
            this.panel3.Location = new System.Drawing.Point(12, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 358);
            this.panel3.TabIndex = 5;
            // 
            // lblDGVTitl
            // 
            this.lblDGVTitl.AutoSize = true;
            this.lblDGVTitl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGVTitl.Location = new System.Drawing.Point(25, 0);
            this.lblDGVTitl.Name = "lblDGVTitl";
            this.lblDGVTitl.Size = new System.Drawing.Size(139, 23);
            this.lblDGVTitl.TabIndex = 0;
            this.lblDGVTitl.Text = "Added Products";
            // 
            // DGVAddedProd
            // 
            this.DGVAddedProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAddedProd.Location = new System.Drawing.Point(29, 34);
            this.DGVAddedProd.Name = "DGVAddedProd";
            this.DGVAddedProd.RowHeadersWidth = 51;
            this.DGVAddedProd.RowTemplate.Height = 24;
            this.DGVAddedProd.Size = new System.Drawing.Size(742, 301);
            this.DGVAddedProd.TabIndex = 1;
            // 
            // pnlAddCalcu
            // 
            this.pnlAddCalcu.Controls.Add(this.btnSave);
            this.pnlAddCalcu.Controls.Add(this.txtDisc);
            this.pnlAddCalcu.Controls.Add(this.txtReturnAmnt);
            this.pnlAddCalcu.Controls.Add(this.txtPaidAmt);
            this.pnlAddCalcu.Controls.Add(this.txtGST);
            this.pnlAddCalcu.Controls.Add(this.txtGrandTOT);
            this.pnlAddCalcu.Controls.Add(this.txtSubTot);
            this.pnlAddCalcu.Controls.Add(this.lblRetnAmnt);
            this.pnlAddCalcu.Controls.Add(this.lblDiscont);
            this.pnlAddCalcu.Controls.Add(this.label3);
            this.pnlAddCalcu.Controls.Add(this.lblGrandTot);
            this.pnlAddCalcu.Controls.Add(this.lblPaidAmnt);
            this.pnlAddCalcu.Controls.Add(this.lblSubTot);
            this.pnlAddCalcu.Controls.Add(this.lblCalDet);
            this.pnlAddCalcu.Location = new System.Drawing.Point(830, 328);
            this.pnlAddCalcu.Name = "pnlAddCalcu";
            this.pnlAddCalcu.Size = new System.Drawing.Size(547, 358);
            this.pnlAddCalcu.TabIndex = 6;
            // 
            // lblCalDet
            // 
            this.lblCalDet.AutoSize = true;
            this.lblCalDet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalDet.Location = new System.Drawing.Point(14, 0);
            this.lblCalDet.Name = "lblCalDet";
            this.lblCalDet.Size = new System.Drawing.Size(159, 23);
            this.lblCalDet.TabIndex = 0;
            this.lblCalDet.Text = "Calculation Details";
            // 
            // lblSubTot
            // 
            this.lblSubTot.AutoSize = true;
            this.lblSubTot.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTot.Location = new System.Drawing.Point(26, 34);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(80, 23);
            this.lblSubTot.TabIndex = 1;
            this.lblSubTot.Text = "Sub Total";
            // 
            // lblPaidAmnt
            // 
            this.lblPaidAmnt.AutoSize = true;
            this.lblPaidAmnt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmnt.Location = new System.Drawing.Point(26, 229);
            this.lblPaidAmnt.Name = "lblPaidAmnt";
            this.lblPaidAmnt.Size = new System.Drawing.Size(110, 23);
            this.lblPaidAmnt.TabIndex = 2;
            this.lblPaidAmnt.Text = "Paid Amount";
            // 
            // lblGrandTot
            // 
            this.lblGrandTot.AutoSize = true;
            this.lblGrandTot.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTot.Location = new System.Drawing.Point(26, 183);
            this.lblGrandTot.Name = "lblGrandTot";
            this.lblGrandTot.Size = new System.Drawing.Size(98, 23);
            this.lblGrandTot.TabIndex = 3;
            this.lblGrandTot.Text = "Grand Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "GST(%)";
            // 
            // lblDiscont
            // 
            this.lblDiscont.AutoSize = true;
            this.lblDiscont.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscont.Location = new System.Drawing.Point(26, 81);
            this.lblDiscont.Name = "lblDiscont";
            this.lblDiscont.Size = new System.Drawing.Size(103, 23);
            this.lblDiscont.TabIndex = 5;
            this.lblDiscont.Text = "Discount(%)";
            // 
            // lblRetnAmnt
            // 
            this.lblRetnAmnt.AutoSize = true;
            this.lblRetnAmnt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetnAmnt.Location = new System.Drawing.Point(26, 278);
            this.lblRetnAmnt.Name = "lblRetnAmnt";
            this.lblRetnAmnt.Size = new System.Drawing.Size(129, 23);
            this.lblRetnAmnt.TabIndex = 6;
            this.lblRetnAmnt.Text = "Return Amount";
            // 
            // txtSubTot
            // 
            this.txtSubTot.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTot.Location = new System.Drawing.Point(186, 31);
            this.txtSubTot.Name = "txtSubTot";
            this.txtSubTot.ReadOnly = true;
            this.txtSubTot.Size = new System.Drawing.Size(321, 30);
            this.txtSubTot.TabIndex = 7;
            this.txtSubTot.Text = "0";
            // 
            // txtGrandTOT
            // 
            this.txtGrandTOT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTOT.Location = new System.Drawing.Point(186, 176);
            this.txtGrandTOT.Name = "txtGrandTOT";
            this.txtGrandTOT.ReadOnly = true;
            this.txtGrandTOT.Size = new System.Drawing.Size(321, 30);
            this.txtGrandTOT.TabIndex = 8;
            // 
            // txtGST
            // 
            this.txtGST.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGST.Location = new System.Drawing.Point(186, 127);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(321, 30);
            this.txtGST.TabIndex = 9;
            this.txtGST.TextChanged += new System.EventHandler(this.txtGST_TextChanged);
            // 
            // txtPaidAmt
            // 
            this.txtPaidAmt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmt.Location = new System.Drawing.Point(186, 222);
            this.txtPaidAmt.Name = "txtPaidAmt";
            this.txtPaidAmt.Size = new System.Drawing.Size(321, 30);
            this.txtPaidAmt.TabIndex = 10;
            this.txtPaidAmt.TextChanged += new System.EventHandler(this.txtPaidAmt_TextChanged);
            // 
            // txtReturnAmnt
            // 
            this.txtReturnAmnt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnAmnt.Location = new System.Drawing.Point(186, 271);
            this.txtReturnAmnt.Name = "txtReturnAmnt";
            this.txtReturnAmnt.ReadOnly = true;
            this.txtReturnAmnt.Size = new System.Drawing.Size(321, 30);
            this.txtReturnAmnt.TabIndex = 11;
            // 
            // txtDisc
            // 
            this.txtDisc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisc.Location = new System.Drawing.Point(186, 78);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(321, 30);
            this.txtDisc.TabIndex = 12;
            this.txtDisc.TextChanged += new System.EventHandler(this.txtDisc_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(243, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 47);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PurchaseAndSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1389, 708);
            this.Controls.Add(this.pnlAddCalcu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPurSal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseAndSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase And Sale";
            this.Load += new System.EventHandler(this.PurchaseAndSaleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.pnlPurSal.ResumeLayout(false);
            this.pnlPurSal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAddedProd)).EndInit();
            this.pnlAddCalcu.ResumeLayout(false);
            this.pnlAddCalcu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Panel pnlPurSal;
        private System.Windows.Forms.Label lblDCDetails;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInven;
        private System.Windows.Forms.Label lblQnty;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblProdSearch;
        private System.Windows.Forms.TextBox txtQnty;
        private System.Windows.Forms.TextBox txtPRate;
        private System.Windows.Forms.TextBox txtPInventr;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPSearch;
        private System.Windows.Forms.Button btnPAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DGVAddedProd;
        private System.Windows.Forms.Label lblDGVTitl;
        private System.Windows.Forms.Panel pnlAddCalcu;
        private System.Windows.Forms.Label lblDiscont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrandTot;
        private System.Windows.Forms.Label lblPaidAmnt;
        private System.Windows.Forms.Label lblSubTot;
        private System.Windows.Forms.Label lblCalDet;
        private System.Windows.Forms.TextBox txtSubTot;
        private System.Windows.Forms.Label lblRetnAmnt;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.TextBox txtReturnAmnt;
        private System.Windows.Forms.TextBox txtPaidAmt;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.TextBox txtGrandTOT;
        private System.Windows.Forms.Button btnSave;
    }
}