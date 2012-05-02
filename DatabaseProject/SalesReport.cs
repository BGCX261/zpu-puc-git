using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DatabaseProject
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
           // Login.logincorrect = false;
        }
        private static int status = 0;
        private const int byItem = 1;
        private const int byCustomer = 2;
        private const int byVendor = 3;


        public OleDbConnection getConn()
        {
            //string connstr = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=D:\\Course\\Database Systems\\test.accdb";
            string connstr = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=" + Application.StartupPath + "\\test.accdb";
            OleDbConnection tempconn = new OleDbConnection(connstr);
            return (tempconn);
        }

        private void freshtext()
        {
            this.textBoxItemID.Text = "";
            this.textBoxCustomerID.Text = "";
            this.textBoxVendorID.Text = "";
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            this.textBoxItemID.Enabled = false;
            this.textBoxCustomerID.Enabled = false;
            this.textBoxVendorID.Enabled = false;
        }

        private void buttonTitem_Click(object sender, EventArgs e)
        {
            freshtext();
            this.textBoxItemID.Enabled = true;
            //this.textBoxItemID.Enabled = false;
            this.textBoxCustomerID.Enabled = false;
            this.textBoxVendorID.Enabled = false;
            status = byItem;
        }

        private void buttonTcustomer_Click(object sender, EventArgs e)
        {
            freshtext();
            this.textBoxCustomerID.Enabled = true;
            this.textBoxItemID.Enabled = false;
            //this.textBoxCustomerID.Enabled = false;
            this.textBoxVendorID.Enabled = false;
            status = byCustomer;
        }

        private void buttonTvendor_Click(object sender, EventArgs e)
        {
            freshtext();
            this.textBoxItemID.Enabled = false;
            this.textBoxCustomerID.Enabled = false;
            this.textBoxVendorID.Enabled = true;
            status = byVendor;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report();
            switch (status)
            {
                case byItem:
                    reportForm.setTitle(status, this.textBoxItemID.Text);
                    break;
                case byCustomer:
                    reportForm.setTitle(status, this.textBoxCustomerID.Text);
                    break;
                case byVendor:
                    reportForm.setTitle(status, this.textBoxVendorID.Text);
                    break;
                default:
                    break;
            }
            reportForm.ShowDialog();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            SalesApp salesapp = new SalesApp();
            salesapp.Show();
        }
    }
}
