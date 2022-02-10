using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FYP_Event
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connect = new OleDbConnection();
                connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amie\Desktop\effa sepang\SEM 7 FINALLLLL\PDIE\Hotel Event.accdb;
            Persist Security Info=False;";
                connect.Open();
                lblWelcome.Text = "WELCOME TO HOTEL EVENT MANAGEMENT SYSTEM";
                connect.Close();
            }
            catch(Exception er)
            {
                MessageBox.Show("Error" + er);
            }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (rdbStaff.Checked == true)
            {
                StaffLogin open = new StaffLogin();
                open.Show();
                this.Hide();
            }
            else if (rdbManager.Checked == true)
            {
                ManagerLogin open = new ManagerLogin();
                open.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Choose Either Staff or Manager", "ALERT!");    //error handling occur when user directly click here aand did not select one of the option given 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Using This System", "BYE BYE!");
            Application.Exit();
        }
    }
}
