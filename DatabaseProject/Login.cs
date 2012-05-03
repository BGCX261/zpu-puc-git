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
    public partial class Login : Form
    {
        public static bool logincorrect= false;
        public Login()
        {
            InitializeComponent();
        }

        private void labelID_Click(object sender, EventArgs e)
        {
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPwd_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxID.Text == "")
            {
                MessageBox.Show("Must type an Employee ID!");
            }
            else 
            {
                OleDbConnection conn = getConn(); //get connection object
                conn.Open();
                try
                {
                    string strCheck = "SELECT * FROM employee WHERE eID = " + int.Parse(this.textBoxID.Text.ToString()) ;
                    OleDbCommand cmdCheck = new OleDbCommand(strCheck, conn);
                    OleDbDataReader reader;
                    reader = cmdCheck.ExecuteReader(); //execute query and get according DataReader

                    if (reader.Read())
                    {
                        if (this.textBoxPwd.Text ==reader["epassword"].ToString())
                        {
                            logincorrect = true;
                            this.Close();
                            reader.Close();
                        }
                        else 
                        {
                            MessageBox.Show("Wrong Password!");
                            freshtext();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Does not exist this Manager!");
                        freshtext();
                    }

                }
                catch (Exception ee)
                {
                    throw (new Exception("Database error:" + ee.Message));
                } 
            }
            //this.Close();
        }

        public OleDbConnection getConn()
        {
            string connstr = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=" + Application.StartupPath + "\\test.accdb";
            OleDbConnection tempconn = new OleDbConnection(connstr);
            return (tempconn);
        }

        private void freshtext()
        {
            this.textBoxID.Text = "";
            this.textBoxPwd.Text = "";
        }
    }
}