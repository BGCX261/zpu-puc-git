using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item_Application itemapp = new Item_Application();
            itemapp.Show();
            //Form1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderingApp orderingapp = new OrderingApp();
            orderingapp.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            //add code here
            //if we  type a wrong pwd but close the dialog, we can still log in the sales report
            if (Login.logincorrect == true)
            {
                SalesApp salesapp = new SalesApp();
                salesapp.Show();
                Login.logincorrect = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (Login.logincorrect == true)
            {
                AdminApp adminapp = new AdminApp();
                adminapp.Show();
                Login.logincorrect = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
