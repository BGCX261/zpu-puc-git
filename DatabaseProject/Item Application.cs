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
    public partial class Item_Application : Form
    {
        public Item_Application()
        {
            InitializeComponent();
        }
        private static int status;
        private const int Add = 1;
        private const int Delete = 2;
        private const int Change = 3;
        private const int Query = 4;

        private void Item_Application_Load(object sender, EventArgs e)
        {           
            this.GroupItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status = Add;
            this.GroupItem.Enabled = true;
            cleanTextbox();
            panelItemD.Enabled = true;
            panelBook.Enabled = true;
            panelCD.Enabled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            status = Delete;
            this.GroupItem.Enabled = true;
            cleanTextbox();
            panelItemD.Enabled = false;
            panelBook.Enabled = false;
            panelCD.Enabled = false;
            radioButtonBook.Enabled = false;
            radioButtonCD.Enabled = false;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            status = Change;
            this.GroupItem.Enabled = true;
            cleanTextbox();
            panelItemD.Enabled = true;
            panelBook.Enabled = true;
            panelCD.Enabled = false;
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            status = Query;
            this.GroupItem.Enabled = true;
            cleanTextbox();
            panelItemD.Enabled = false;
            panelBook.Enabled = false;
            panelCD.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonBook_CheckedChanged(object sender, EventArgs e)
        {
            this.panelBook.Enabled = true;
            this.panelCD.Enabled = false;
        }

        private void radioButtonCD_CheckedChanged(object sender, EventArgs e)
        {
            this.panelCD.Enabled = true;
            this.panelBook.Enabled = false;
        }

        private void cleanTextbox()
        {
            this.textBoxID.Text = "";
            this.textBoxYear.Text = "";
            this.textBoxPrice.Text = "";
            this.textBoxQ.Text = "";
            this.textBoxTitle.Text = "";
            this.textBoxISDN.Text = "";
            this.textBoxEdi.Text = "";
            this.textBoxAuthor.Text = "";
            this.textBoxEditor.Text = "";
            this.textBoxSub.Text = "";
            this.textBoxComp.Text = "";
            this.textBoxArtist.Text = "";
            this.textBoxProducer.Text = "";
            this.radioButtonBook.Select();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (this.textBoxID.Text == "") // if ID textbox is empty
            {
                MessageBox.Show("Item ID empty!");
            }
            else
            {
                //MessageBox.Show("Begin operate database");
                //int int.Parse(this.textBoxID.Text) = int.Parse(this.textBoxID.Text);
                
                OleDbConnection conn = getConn(); //get connection object
                conn.Open();

                //do actions depends on status
                switch (status)
                {
                    case Add:
                        try
                        {
                            string strCheck = "SELECT * FROM item WHERE iID ="+ int.Parse(this.textBoxID.Text);
                            OleDbCommand cmdCheck = new OleDbCommand(strCheck, conn);
                            OleDbDataReader reader;
                            reader = cmdCheck.ExecuteReader(); //execute query and get according DataReader

                            if (reader.Read())
                            {
                                MessageBox.Show("This item ID already exists!");
                                reader.Close();
                            }
                            else
                            {
                                reader.Close();      
                                string strInsertItem = "INSERT INTO item VALUES (" + int.Parse(this.textBoxID.Text) + "," + int.Parse(this.textBoxYear.Text) +
                                                                "," + int.Parse(this.textBoxPrice.Text) + "," + int.Parse(this.textBoxQ.Text) + ",'" +
                                                                    this.textBoxTitle.Text + "')";

                                OleDbCommand cmdInsertItem = new OleDbCommand(strInsertItem, conn);
                                cmdInsertItem.ExecuteNonQuery();
                                cmdInsertItem.Dispose();

                                if (this.radioButtonBook.Checked == true)
                                {
                                    string strInsertBook = "INSERT INTO book VALUES (" + int.Parse(this.textBoxID.Text) + ",'" + this.textBoxISDN.Text +
                                                                "'," + int.Parse(this.textBoxEdi.Text) + ",'" + this.textBoxAuthor.Text + "','" +
                                                                    this.textBoxEditor.Text + "')";
                                    OleDbCommand cmdInsertBook = new OleDbCommand(strInsertBook, conn);
                                    cmdInsertBook.ExecuteNonQuery();
                                    cmdInsertBook.Dispose();
                                }
                                else if (this.radioButtonCD.Checked == true)
                                {
                                    string strInsertCD = "INSERT INTO CD VALUES (" + int.Parse(this.textBoxID.Text) + ",'" + this.textBoxSub.Text +
                                                                "','" + this.textBoxComp.Text + "','" + this.textBoxArtist.Text + "','" +
                                                                    this.textBoxProducer.Text + "')";
                                    OleDbCommand cmdInsertCD = new OleDbCommand(strInsertCD, conn);
                                    cmdInsertCD.ExecuteNonQuery();
                                    cmdInsertCD.Dispose();
                                }
                                MessageBox.Show("Add this item successfully");
                            }
                                                        
                        }
                        catch (Exception ee)
                        {
                            throw (new Exception("Database error:" + ee.Message));
                        }                        
                        break;
                    case Delete:
                        try
                        {
                            //do we have to check if this item exist at firest?
                            string strDeleteItem = "DELETE From item WHERE iID = " + int.Parse(this.textBoxID.Text);
                            OleDbCommand cmdDeleteItem = new OleDbCommand(strDeleteItem, conn);
                            cmdDeleteItem.ExecuteNonQuery();
                            cmdDeleteItem.Dispose();

                            string strDeleteBook = "DELETE From book WHERE bookID = " + int.Parse(this.textBoxID.Text);
                            OleDbCommand cmdDeleteBook = new OleDbCommand(strDeleteBook, conn);
                            cmdDeleteBook.ExecuteNonQuery();
                            cmdDeleteBook.Dispose();

                            string strDeleteCD = "DELETE From CD WHERE cdID = " + int.Parse(this.textBoxID.Text);
                            OleDbCommand cmdDeleteCD = new OleDbCommand(strDeleteCD, conn);
                            cmdDeleteCD.ExecuteNonQuery();
                            cmdDeleteCD.Dispose();
                            MessageBox.Show("Delete this item successfully");
                        }
                        catch (Exception ee)
                        {
                            throw(new Exception("Delete error:" + ee.Message));
                        }
                        break;

                    case Change:
                        string strCheckU = "SELECT * FROM item WHERE iID ="+ int.Parse(this.textBoxID.Text);
                        OleDbCommand cmdCheckU = new OleDbCommand(strCheckU, conn);
                        OleDbDataReader readerUpdateItem = cmdCheckU.ExecuteReader();
                        if (!readerUpdateItem.Read())
                        {
                            MessageBox.Show("This item ID does no exists!");
                        }
                        else
                        {
                            try
                            {
                                string strUpdateItem = "UPDATE item SET itemY = " + int.Parse(this.textBoxYear.Text) + ",itemP = "
                                    + this.textBoxPrice.Text + ",itemQ = " + this.textBoxQ.Text + ", itemT = '" + this.textBoxTitle.Text
                                    + "' WHERE iID = " + int.Parse(this.textBoxID.Text);
                                OleDbCommand cmdUpdateItem = new OleDbCommand(strUpdateItem, conn);
                                cmdUpdateItem.ExecuteNonQuery();
                                cmdUpdateItem.Dispose();

                                string strCheckBook = "SELECT * FROM book WHERE bookID =" + int.Parse(this.textBoxID.Text);
                                OleDbCommand cmdCheckBook = new OleDbCommand(strCheckBook, conn);
                                OleDbDataReader readerUpdateBook = cmdCheckBook.ExecuteReader();
                                if (readerUpdateBook.Read())
                                {
                                    string strUpdateBook = "UPDATE book SET ISDN = '" + this.textBoxISDN.Text + "', edition =" + this.textBoxEdi.Text
                                        + ", author = '" + this.textBoxAuthor.Text + "', editor = '" + this.textBoxEditor.Text + "' WHERE bookID = "
                                        + int.Parse(this.textBoxID.Text);
                                    OleDbCommand cmdUpdateBook = new OleDbCommand(strUpdateBook, conn);
                                    cmdUpdateBook.ExecuteNonQuery();
                                    cmdUpdateBook.Dispose();
                                }
                                else
                                {
                                    string strUpdateCD = "UPDATE CD SET subject = '" + this.textBoxSub.Text + "', composer ='" + this.textBoxComp.Text
                                        + "', artist = '" + this.textBoxArtist.Text + "', producer = '" + this.textBoxProducer.Text + "' WHERE cdID = "
                                        + int.Parse(this.textBoxID.Text);
                                    OleDbCommand cmdUpdateCD = new OleDbCommand(strUpdateCD, conn);
                                    cmdUpdateCD.ExecuteNonQuery();
                                    cmdUpdateCD.Dispose();
                                }
                                MessageBox.Show("Modify the information of this item successfully");
                            }
                            catch(Exception ee)
                            {
                                throw (new Exception("Update error: " + ee.Message));
                            }
                        }
                        break;

                    case Query:
                        string strQueryItem = "SELECT * FROM item WHERE iID ="+ int.Parse(this.textBoxID.Text);
                        OleDbCommand cmdQueryItem = new OleDbCommand(strQueryItem, conn);
                        OleDbDataReader readerItem;
                        readerItem = cmdQueryItem.ExecuteReader(); //execute query and get according DataReader
                        if (readerItem.Read())
                        {
                            this.textBoxYear.Text = readerItem["itemY"].ToString();
                            this.textBoxPrice.Text = readerItem["itemP"].ToString();
                            this.textBoxQ.Text = readerItem["itemQ"].ToString();
                            this.textBoxTitle.Text = readerItem["itemT"].ToString();

                            string strQueryBook = "SELECT * FROM book WHERE bookID = " + int.Parse(this.textBoxID.Text);
                            OleDbCommand cmdQueryBook = new OleDbCommand(strQueryBook, conn);
                            OleDbDataReader readerBook = cmdQueryBook.ExecuteReader();
                            if (readerBook.Read())
                            {
                                this.textBoxISDN.Text = readerBook["ISDN"].ToString();
                                this.textBoxEdi.Text = readerBook["edition"].ToString();
                                this.textBoxAuthor.Text = readerBook["author"].ToString();
                                this.textBoxEditor.Text = readerBook["editor"].ToString();
                            }
                            else
                            {
                                string strQueryCD = "SELECT * FROM CD WHERE cdID = " + int.Parse(this.textBoxID.Text);
                                OleDbCommand cmdQueryCD = new OleDbCommand(strQueryCD, conn);
                                OleDbDataReader readerCD = cmdQueryCD.ExecuteReader();
                                if (readerCD.Read())
                                {
                                    this.textBoxSub.Text = readerCD["subject"].ToString();
                                    this.textBoxComp.Text = readerCD["composer"].ToString();
                                    this.textBoxArtist.Text = readerCD["artist"].ToString();
                                    this.textBoxProducer.Text = readerCD["producer"].ToString();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("This item ID does no exists!");
                        }
                        break;
                    default:
                        break;
                }
                conn.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cleanTextbox();
            this.GroupItem.Enabled = false;
        }

        public OleDbConnection getConn()
        {
            //string connstr = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=D:\\Course\\Database Systems\\test.accdb";
            string connstr = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=" + Application.StartupPath + "\\test.accdb";
            OleDbConnection tempconn = new OleDbConnection(connstr);
            return (tempconn);
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
