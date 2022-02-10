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
    public partial class ManagerLogin : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public ManagerLogin()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amie\Desktop\effa sepang\SEM 7 FINALLLLL\PDIE\Hotel Event.accdb;
            Persist Security Info=False;";
        }

        int i = 3;
        private void ManagerLogin_Load(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                lblLogin.Text = "PLEASE  LOGIN TO ENTER THIS SYSTEM";
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = connect;
            com.CommandText = "select * from Manager where Username = '" + txtUserName.Text + "' and Password = '" + txtPassWord.Text + "'";

            OleDbDataReader read = com.ExecuteReader();

            int count = 0;

            while (read.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Welcome to Manager Main Menu", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveForm.Hide();
                ManagerMenu open = new ManagerMenu();
                open.Show();
                this.Hide();
            }
            else
            {
                i--;
                MessageBox.Show("The Username AND/OR Password Don't Match Sir, Please Try Again", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassWord.Text = null;
                txtUserName.Text = null;
                tries.Text = i + "";
            }
            if (i == 0)
            {
                MessageBox.Show("You have entered 3 times, System will go to Main Menu", "ALERT!");
                MainMenu open = new MainMenu();
                open.Show();
                this.Hide();
            }
            connect.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassWord.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu open = new MainMenu();
            open.Show();
            this.Hide();
        }
    }
}
