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
    public partial class AdminApp : Form
    {
        public AdminApp()
        {
            InitializeComponent();
        }

        private static int status;
        private const int CInfo = 1;
        private const int PInfo = 2;
        private const int EInfo = 3;

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCInfo_Click(object sender, EventArgs e)
        {
            status = CInfo;
        }

        private void buttonPInfo_Click(object sender, EventArgs e)
        {
            status = PInfo;
        }

        private void buttonEinfo_Click(object sender, EventArgs e)
        {
            //if want to change the employee's information, it needs manager permission
            status = EInfo;
            freshtext();
            Login login = new Login();
            login.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textBoxID.Text == "") // if ID textbox is empty
            {
                MessageBox.Show("Must Have a ID number!");
            }
            else
            {
                OleDbConnection conn = getConn(); //get connection object
                conn.Open();

                switch (status)
                { 
                    case CInfo:
                        try
                        {
                            string strCheck = "SELECT * FROM customer WHERE cID =" + int.Parse(this.textBoxID.Text);
                            OleDbCommand cmdCheck = new OleDbCommand(strCheck, conn);
                            OleDbDataReader reader;
                            reader = cmdCheck.ExecuteReader(); //execute query and get according DataReader

                            if (reader.Read())
                            {
                                MessageBox.Show("This ID already exists!");
                                reader.Close();
                            }
                            else
                            {
                                reader.Close();
                                string strInsertItem = "INSERT INTO customer VALUES ('"
                                   
                                    + this.textBoxName.Text + "'," + int.Parse(this.textBoxID.Text) + ",'"
                                    + this.textBoxState.Text + "','"
                                    + this.textBoxStreet.Text + "',"
                                    + this.textBoxZip.Text + ",'"
                                    + this.textBoxCity.Text + "')";

                                OleDbCommand cmdInsertItem = new OleDbCommand(strInsertItem, conn);
                                cmdInsertItem.ExecuteNonQuery();
                                cmdInsertItem.Dispose();
                                MessageBox.Show("Add this customer successfully");
                                freshtext();
                            }

                        }
                        catch (Exception ee)
                        {
                            throw (new Exception("Database error:" + ee.Message));
                        } 
                        break ;
                    case PInfo: 
                        //no publisher info table
                        break;

                        //should do more in the GUI part
                    case EInfo:
                        try
                        {
                            string strCheck = "SELECT * FROM employee WHERE eID =" + int.Parse(this.textBoxID.Text);
                            OleDbCommand cmdCheck = new OleDbCommand(strCheck, conn);
                            OleDbDataReader reader;
                            reader = cmdCheck.ExecuteReader(); //execute query and get according DataReader

                            if (reader.Read())
                            {
                                MessageBox.Show("This ID already exists!");
                                reader.Close();
                            }
                            else
                            {
                                reader.Close();
                                string strInsertItem = "INSERT INTO customer VALUES ("
                                    + int.Parse(this.textBoxID.Text) + ","
                                    + this.textBoxName.Text + ","
                                    + this.textBoxStreet.Text + ","
                                    + this.textBoxCity.Text + ",'"
                                    + this.textBoxState.Text + ",'"
                                    + this.textBoxZip.Text + "')";

                                OleDbCommand cmdInsertItem = new OleDbCommand(strInsertItem, conn);
                                cmdInsertItem.ExecuteNonQuery();
                                cmdInsertItem.Dispose();
                            }

                        }
                        catch (Exception ee)
                        {
                            throw (new Exception("Database error:" + ee.Message));
                        } 
                        break;
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

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (this.textBoxID.Text == "") // if ID textbox is empty
            {
                MessageBox.Show("Must Have a ID number before modification!");
            }
            else
            {
                OleDbConnection conn = getConn(); //get connection object
                conn.Open();

                switch (status)
                {
                    case CInfo:
                        try
                        {
                            string strCheck = "SELECT * FROM customer WHERE cID ="+ int.Parse(this.textBoxID.Text);
                            OleDbCommand cmdCheck = new OleDbCommand(strCheck, conn);
                            OleDbDataReader reader;
                            reader = cmdCheck.ExecuteReader(); //execute query and get according DataReader

                            if (!reader.Read())
                            {
                                MessageBox.Show("This Customer does not exist!");
                                reader.Close();
                            }
                            else
                            {
                                reader.Close();
                                string strUpdateC = "UPDATE customer SET cName='"
                                    + this.textBoxName.Text + "',street='"
                                    + this.textBoxStreet.Text + "',city='"
                                    + this.textBoxCity.Text + "',state='"
                                    + this.textBoxState.Text + "',zip='"
                                    + this.textBoxZip.Text + "' WHERE cID = " + int.Parse(this.textBoxID.Text);

                                OleDbCommand cmdInsertItem = new OleDbCommand(strUpdateC, conn);
                                cmdInsertItem.ExecuteNonQuery();
                                cmdInsertItem.Dispose();
                                MessageBox.Show("Update customer information successfully");
                                freshtext();
                            }

                        }
                        catch (Exception ee)
                        {
                            throw (new Exception("Database error:" + ee.Message));
                        }
                        break;
                    case PInfo:
                        //no publisher info table
                        break;

                    //should do more in the GUI part
                    /*
                    case EInfo:
                        try
                        {
                            string strCheck = "SELECT * FROM employee WHERE eID =" + int.Parse(this.textBoxID.Text);
                            OleDbCommand cmdCheck = new OleDbCommand(strCheck, conn);
                            OleDbDataReader reader;
                            reader = cmdCheck.ExecuteReader(); //execute query and get according DataReader

                            if (!reader.Read())
                            {
                                MessageBox.Show("This Employee does not exist!");
                                reader.Close();
                            }
                            else
                            {
                                reader.Close();
                                string strInsertItem = "UPDATE customer SET eName='"
                                    + this.textBoxName.Text + "',street='"
                                    + this.textBoxStreet.Text + "',"
                                    + this.textBoxCity.Text + ",'"
                                    + this.textBoxState.Text + ",'"
                                    + this.textBoxZip.Text + "')";

                                OleDbCommand cmdInsertItem = new OleDbCommand(strInsertItem, conn);
                                cmdInsertItem.ExecuteNonQuery();
                                cmdInsertItem.Dispose();
                            }

                        }
                        catch (Exception ee)
                        {
                            throw (new Exception("Database error:" + ee.Message));
                        }
                        break;
                        */
                }
            }
        }

        private void freshtext()
        {
            this.textBoxID.Text = "";
            this.textBoxName.Text = "";
            this.textBoxStreet.Text = "";
            this.textBoxCity.Text = "";
            this.textBoxState.Text = "";
            this.textBoxZip.Text = "";
        }
    }
}