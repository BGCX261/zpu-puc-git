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
    public partial class Report : Form
    {
        private static int status = 0;
        private const int byItem = 1;
        private const int byCustomer = 2;
        private const int byVendor = 3;

        public Report()
        {
            InitializeComponent();
        }
        public void setTitle(int s,string title)
        {
            status = s;
            switch(s){
                case byItem:
                    this.labelTitle.Text = "Sort by item: ";
                    break;
                case byCustomer:
                    this.labelTitle.Text = "Sort by customer: ";
                    break;
                case byVendor:
                    this.labelTitle.Text = "Sort by vendor: ";
                    break;
                default:
                    break;
            }
            this.labelTitle.Text += title;
            loadReport(s, title);
        }
        private void loadReport(int s,string title)
        {
            OleDbConnection conn = getConn(); //get connection object
            conn.Open();
            string aRecord;
            switch (s)
            {
                case byItem:
                    string strItemReport = "SELECT * FROM sells WHERE itemID = " + title;
                    OleDbCommand cmdItemReport = new OleDbCommand(strItemReport, conn);
                    OleDbDataReader readerItemReport;
                    readerItemReport = cmdItemReport.ExecuteReader(); //execute query and get according DataReader
                    if (readerItemReport.Read())
                    {
                        do
                        {
                            aRecord = "Employee ID: " + readerItemReport["eID"].ToString() + "|Customer ID: " + readerItemReport["cID"].ToString() +
                                "|Vendor ID: " + readerItemReport["vID"].ToString() + "|Item quantity: " + readerItemReport["itemQ"].ToString();
                            this.richTextBoxReport.AppendText(aRecord + "\n");
                        } while (readerItemReport.Read());
                    }
                    else
                    {
                        this.richTextBoxReport.Text = "No such record!";
                        //MessageBox.Show("No such record!");
                    }
                    break;
                case byCustomer:
                    string strCusReport = "SELECT * FROM sells WHERE cID = " + title;
                    OleDbCommand cmdCusReport = new OleDbCommand(strCusReport, conn);
                    OleDbDataReader readerCusReport;
                    readerCusReport = cmdCusReport.ExecuteReader(); //execute query and get according DataReader
                    if (readerCusReport.Read())
                    {
                        do
                        {
                            aRecord = "Employee ID: " + readerCusReport["eID"].ToString() + "|Item ID: " + readerCusReport["itemID"].ToString() +
                                "|Vendor ID: " + readerCusReport["vID"].ToString() + "|Item quantity: " + readerCusReport["itemQ"].ToString();
                            this.richTextBoxReport.AppendText(aRecord + "\n");
                        } while (readerCusReport.Read());
                    }
                    else
                    {
                        this.richTextBoxReport.Text = "No such record!";
                        //MessageBox.Show("No such record!");
                    }
                    break;
                case byVendor:
                    string strVendorReport = "SELECT * FROM sells WHERE vID = " + title;
                    OleDbCommand cmdVendorReport = new OleDbCommand(strVendorReport, conn);
                    OleDbDataReader readerVendorReport;
                    readerVendorReport = cmdVendorReport.ExecuteReader(); //execute query and get according DataReader
                    if (readerVendorReport.Read())
                    {
                        do
                        {
                            aRecord = "Employee ID: " + readerVendorReport["eID"].ToString() + "|Item ID: " + readerVendorReport["itemID"].ToString() +
                                "|Customer ID: " + readerVendorReport["cID"].ToString() + "|Item quantity: " + readerVendorReport["itemQ"].ToString();
                            this.richTextBoxReport.AppendText(aRecord + "\n");
                        } while (readerVendorReport.Read());
                    }
                    else
                    {
                        this.richTextBoxReport.Text = "No such record!";
                        //MessageBox.Show("No such record!");
                    }
                    break;
                default:
                    break;
            }
        }
        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public OleDbConnection getConn()
        {
            string connstr = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=" + Application.StartupPath + "\\test.accdb";
            OleDbConnection tempconn = new OleDbConnection(connstr);
            return (tempconn);
        }
    }
}
