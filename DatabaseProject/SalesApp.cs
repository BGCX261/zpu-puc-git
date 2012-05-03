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
    public partial class SalesApp : Form
    {
        public SalesApp()
        {
            InitializeComponent();
            
        }


        private void buttonSaleReport_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

            if (Login.logincorrect == true && Login.notmanager == true)
            {
                SalesReport salesreport = new SalesReport();
                salesreport.Show();
                Login.logincorrect = false;
            }
            else
            {
                MessageBox.Show("No permission to access!");
            }

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (this.textBoxSid.Text == "")
            {
                MessageBox.Show("Must have a Sale ID");
            }
            else
            {
                OleDbConnection conn = getConn(); //get connection object
                conn.Open();
                
                string strCheck = "SELECT * FROM item WHERE iID ="+ int.Parse(this.textBoxItemID.Text);
                OleDbCommand cmdCheck = new OleDbCommand(strCheck, conn);
                OleDbDataReader reader= cmdCheck.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("This item does not exist!");
                }
                else
                {
                    int itemquan = int.Parse(reader["itemQ"].ToString());
                    int sellitemquan=int.Parse(this.textBoxItemQuantity.Text);
                    if (itemquan < sellitemquan)
                        MessageBox.Show("No enought item!");
                    else
                    {
                        int newq = itemquan - sellitemquan;
                        string strupdateitemq = "UPDATE item SET itemQ=" + newq + " WHERE iID=" + int.Parse(this.textBoxItemID.Text);
                        OleDbCommand cmdUpdateItemQ = new OleDbCommand(strupdateitemq, conn);
                        cmdUpdateItemQ.ExecuteNonQuery();
                        cmdUpdateItemQ.Dispose();

                        string strInsertItem = "INSERT INTO sells VALUES (" + int.Parse(this.textBoxEid.Text) + ","
                                + int.Parse(this.textBoxCid.Text) + ","
                                + int.Parse(this.textBoxSid.Text) + ","
                                + int.Parse(this.textBoxItemID.Text) + ","
                                + int.Parse(this.textBoxItemQuantity.Text) + ","
                                + int.Parse(this.textBoxVendorID.Text) + ")";

                        OleDbCommand cmdInsertItem = new OleDbCommand(strInsertItem, conn);
                        cmdInsertItem.ExecuteNonQuery();
                        cmdInsertItem.Dispose();
                        MessageBox.Show("Sold this item successfully");
                    }
                }
            }
        }

        public OleDbConnection getConn()
        {
            //string connstr = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=D:\\Course\\Database Systems\\test.accdb";
            string connstr = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=" + Application.StartupPath + "\\test.accdb";
            OleDbConnection tempconn = new OleDbConnection(connstr);
            return (tempconn);
        }
    }
}