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
    public partial class OrderingApp : Form
    {
        public OrderingApp()
        {
            InitializeComponent();
        }

        private static int status;
        private const int Query = 1;
        private const int Place = 2;
        private const int Change = 3;
        private const int Delete = 4;

        private void textBoxOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            status = Query;
            this.textBoxOrderID.Enabled     = true;
            this.textBoxVendorID.Enabled    = false;
            this.textBoxOrderDate.Enabled   = false;
            this.textBoxOrderItemID.Enabled = false;
            this.textBoxOrderItemQuan.Enabled = false;
        }

        private void buttonPlace_Click(object sender, EventArgs e)
        {
            status = Place;
            this.textBoxOrderID.Enabled = true;
            this.textBoxVendorID.Enabled = true;
            this.textBoxOrderDate.Enabled = true;
            this.textBoxOrderItemID.Enabled = true;
            this.textBoxOrderItemQuan.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            status = Change;
            this.textBoxOrderID.Enabled = true;
            this.textBoxVendorID.Enabled = true;
            this.textBoxOrderDate.Enabled = true;
            this.textBoxOrderItemID.Enabled = true;
            this.textBoxOrderItemQuan.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            status = Delete;
            this.textBoxOrderID.Enabled = true;
            this.textBoxVendorID.Enabled = false;
            this.textBoxOrderDate.Enabled = false;
            this.textBoxOrderItemID.Enabled = false;
            this.textBoxOrderItemQuan.Enabled = false;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (this.textBoxOrderID.Text == "")
            {
                MessageBox.Show("Must have an Order ID!");
            }
            else
            {
                OleDbConnection conn = getConn(); //get connection object
                conn.Open();
                switch (status)
                { 
                    case Query:
                        try
                        {
                            string strCheck = "SELECT * FROM [order] WHERE oID =" + this.textBoxOrderID.Text;
                            OleDbCommand cmdCheck = new OleDbCommand(strCheck, conn);
                            OleDbDataReader reader;
                            reader = cmdCheck.ExecuteReader(); //execute query and get according DataReader
                            
                            //if we have to assign the orderID text here again?
                            if (!reader.Read())
                                MessageBox.Show("This order does not exist!");
                            else
                            {
                                this.textBoxVendorID.Text = reader["vID"].ToString();
                                this.textBoxOrderDate.Text = reader["oDate"].ToString();
                                this.textBoxOrderItemID.Text = reader["itemID"].ToString();
                                this.textBoxOrderItemQuan.Text = reader["itemQ"].ToString();
                            }
                        }
                        catch (Exception ee)
                        {
                            throw (new Exception("Database error:" + ee.Message));
                        }        
                        break;

                    case Place:
                        if (this.textBoxOrderDate.Text == "" || this.textBoxOrderID.Text == ""
                           || this.textBoxOrderItemID.Text == "" || this.textBoxVendorID.Text == ""
                           || this.textBoxOrderItemQuan.Text == "")
                        {
                            MessageBox.Show("Please type the full information!");
                        }
                        else
                        {
                            try
                            {
                                string strCheck = "SELECT * FROM [order] WHERE oID =" + this.textBoxOrderID.Text;
                                OleDbCommand cmdCheck = new OleDbCommand(strCheck, conn);
                                OleDbDataReader reader;
                                reader = cmdCheck.ExecuteReader(); //execute query and get according DataReader
                                if (reader.Read())
                                {
                                    MessageBox.Show("This order already exists!");
                                    reader.Close();
                                }
                                else
                                {
                                    reader.Close();
                                    string strInsertItem = "INSERT INTO [order] VALUES ("
                                        + int.Parse(this.textBoxOrderID.Text) + ","
                                        + int.Parse(this.textBoxVendorID.Text) + ",'"
                                        + this.textBoxOrderDate.Text + "',"
                                        + int.Parse(this.textBoxOrderItemID.Text) + ","
                                        + int.Parse(this.textBoxOrderItemQuan.Text) + ")";
                                    OleDbCommand cmdInsertItem = new OleDbCommand(strInsertItem, conn);
                                    cmdInsertItem.ExecuteNonQuery();
                                    cmdInsertItem.Dispose();


                                    //check the item table for the item quantity
                                    bool itemexist = checkitemexist(int.Parse(this.textBoxOrderItemID.Text), conn);
                                    if (!itemexist)
                                    {
                                        MessageBox.Show("We can only place an item which is existed!");
                                    }
                                    else
                                    {
                                        string stritemquan = "SELECT * FROM item WHERE iID=" + int.Parse(this.textBoxOrderItemID.Text);

                                        OleDbCommand quancheck = new OleDbCommand(stritemquan, conn);

                                        OleDbDataReader quanreader = quancheck.ExecuteReader();
                                        if (quanreader.Read()) ;
                                        int itemquan = int.Parse(quanreader["itemQ"].ToString());
                                        quancheck.Dispose();

                                        int itemnewquan = int.Parse(this.textBoxOrderItemQuan.Text);
                                        int newquan = itemquan + itemnewquan;

                                        string strnewitemquan = "UPDATE item SET itemQ=" + newquan + " WHERE iID=" + int.Parse(this.textBoxOrderItemID.Text);
                                        OleDbCommand newquanquery = new OleDbCommand(strnewitemquan, conn);
                                        OleDbDataReader newquanreader = newquanquery.ExecuteReader();
                                        newquanquery.Dispose();
                                    }
                                    MessageBox.Show("Add this order successfully");

                                }
                            }
                            catch (Exception ee)
                            {
                                throw (new Exception("Database error:" + ee.Message));
                            }
                        }
                        break;

                    case Change:
                        string strCheckU = "SELECT * FROM [order] WHERE oID =" + this.textBoxOrderID.Text;
                        OleDbCommand cmdCheckU = new OleDbCommand(strCheckU, conn);
                        OleDbDataReader readerUpdateItem = cmdCheckU.ExecuteReader();
                        if (!readerUpdateItem.Read())
                        {
                            MessageBox.Show("This Order does no exists!");
                        }
                        else
                        {
                            int orderitemq = int.Parse(readerUpdateItem["itemQ"].ToString());   //get the quantity of item in the order
                            try
                            {
                                string strCheckItemID = "SELECT * FROM item WHERE iID =" + this.textBoxOrderItemID.Text;
                                int itemqinstore;
                                OleDbCommand cmdCheckItemID = new OleDbCommand(strCheckItemID, conn);
                                OleDbDataReader readerCheckItemID = cmdCheckItemID.ExecuteReader();
                                if (!readerCheckItemID.Read()) 
                                    MessageBox.Show("There is no this item!");
                                itemqinstore = int.Parse(readerCheckItemID["itemQ"].ToString());    //get the quantity of item in store
                                cmdCheckItemID.Dispose();
                                if (!(orderitemq >  itemqinstore))
                                {
                                    string strUpdateItem = "UPDATE [order] SET vID = " + int.Parse(this.textBoxVendorID.Text)
                                    + ",oDate ='" + this.textBoxOrderDate.Text
                                    + "', itemID = " + int.Parse(this.textBoxOrderItemID.Text)
                                    + ", itemQ = " + int.Parse(this.textBoxOrderItemQuan.Text)
                                    + " WHERE oID = " + int.Parse(this.textBoxOrderID.Text);
                                    OleDbCommand cmdUpdateItem = new OleDbCommand(strUpdateItem, conn);
                                    cmdUpdateItem.ExecuteNonQuery();
                                    cmdUpdateItem.Dispose();


                                    int newitemQ = int.Parse(this.textBoxOrderItemQuan.Text);
                                    int newq = itemqinstore - orderitemq + newitemQ;

                                    string strupdateitemq = "UPDATE item SET itemQ=" + newq + " WHERE iID=" + this.textBoxOrderItemID.Text;
                                    OleDbCommand cmdUpteItem = new OleDbCommand(strupdateitemq, conn);
                                    cmdUpteItem.ExecuteNonQuery();
                                    cmdUpteItem.Dispose();
                                    MessageBox.Show("Update this order successfully");
                                }
                                else
                                {
                                    MessageBox.Show("Sold out!");
                                }
                            }
                            catch(Exception ee)
                            {
                                throw (new Exception("Update error: " + ee.Message));
                            }
                        }
                        break;

                    case Delete:
                        try
                        {
                            string stregettuple = "SELECT * FROM [order] WHERE oID=" + this.textBoxOrderID.Text;
                            OleDbCommand cmdgettuple = new OleDbCommand(stregettuple, conn);
                            OleDbDataReader readerDeletetuple = cmdgettuple.ExecuteReader();

                            if (!readerDeletetuple.Read()) 
                                MessageBox.Show("No this order exists!");
                            else
                            {
                            int orderitemid = int.Parse(readerDeletetuple["itemID"].ToString());
                            int orderitemquan = int.Parse(readerDeletetuple["itemQ"].ToString());

                            cmdgettuple.Dispose();

                            string stredelitem = "SELECT * FROM item WHERE iID=" + orderitemid;
                            OleDbCommand cmdDeleteItemQ = new OleDbCommand(stredelitem, conn);
                            OleDbDataReader readerDeleteOrderQ = cmdDeleteItemQ.ExecuteReader();
                            
                            if (!readerDeleteOrderQ.Read()) ;
                            int itemstoredquan = int.Parse(readerDeleteOrderQ["itemQ"].ToString());
                            cmdDeleteItemQ.Dispose();
                            int newq = itemstoredquan - orderitemquan;

                            if (itemstoredquan < orderitemquan)
                                MessageBox.Show("Have sold some this item!");
                            else
                            {
                                string streupitemq = "UPDATE item SET itemQ=" + newq + " WHERE iID=" + orderitemid;
                                OleDbCommand cmdupdateItemQ = new OleDbCommand(streupitemq, conn);
                                cmdupdateItemQ.ExecuteNonQuery();
                                cmdupdateItemQ.Dispose();

                                string strDeleteItem = "DELETE From [order] WHERE oID = " + this.textBoxOrderID.Text;
                                OleDbCommand cmdDeleteItem = new OleDbCommand(strDeleteItem, conn);

                                OleDbDataReader readerDeleteOrder = cmdDeleteItem.ExecuteReader();
                                cmdDeleteItem.Dispose();
                                MessageBox.Show("Have deleted this order");
                                freshtext();
                            }
                        }
                        }
                        catch (Exception ee)
                        {
                            throw (new Exception("Delete error:" + ee.Message));
                        }
                        break;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            freshtext();
        }

        public OleDbConnection getConn()
        {
            string connstr = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=" + Application.StartupPath + "\\test.accdb";
            OleDbConnection tempconn = new OleDbConnection(connstr);
            return (tempconn);
        }

        private void freshtext()
        {
            textBoxOrderID.Text = "";
            textBoxVendorID.Text = "";
            textBoxOrderDate.Text = "";
            textBoxOrderItemID.Text = "";
            textBoxOrderItemQuan.Text = "";
        }

        public bool checkitemexist(int itemid,OleDbConnection conn)
        {
            //OleDbConnection conn = getConn(); //get connection object
            //conn.Open();
            string strCheck = "SELECT * FROM item WHERE iID =" + itemid;
            OleDbCommand cmdCheck = new OleDbCommand(strCheck, conn);
            OleDbDataReader reader = cmdCheck.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true; 
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        private void OrderingApp_Load(object sender, EventArgs e)
        {

        }

        private void OrderingApp_Load_1(object sender, EventArgs e)
        {
            this.textBoxOrderID.Enabled = false;
            this.textBoxVendorID.Enabled = false;
            this.textBoxOrderDate.Enabled = false;
            this.textBoxOrderItemID.Enabled = false;
            this.textBoxOrderItemQuan.Enabled = false;
        }

        private void OrderInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}