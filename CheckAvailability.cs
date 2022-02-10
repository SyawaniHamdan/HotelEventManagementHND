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
    public partial class CheckAvailability : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        public CheckAvailability()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amie\Desktop\effa sepang\SEM 7 FINALLLLL\PDIE\Hotel Event.accdb;
            Persist Security Info=False;";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                com.Connection = connect;
                string query = "Select EName,Etype,QuantityDay,ELoc,StartDate,EndDate,TimeIn FROM Try WHERE [StartDate] ='" + dateS.Text + "' ";
                com.CommandText = query;


                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception s)
            {
                MessageBox.Show("Error " + s);
            }
            connect.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageMenu open = new ManageMenu();
            open.Show();
            this.Hide();
        }
    }
}
