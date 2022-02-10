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
    public partial class Cancel : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        public Cancel()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amie\Desktop\effa sepang\SEM 7 FINALLLLL\PDIE\Hotel Event.accdb;
            Persist Security Info=False;";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageMenu open = new ManageMenu();
            open.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                com.Connection = connect;

                string query = "select CustID,CustName,Phone,Email,EName,Etype,QuantityDay,ELoc,MaxSeat,Chair,Table,PAsystem,Microphone,Staff,StartDate,EndDate,TimeIn,Deposit from Try where CustID = '" + txtCancel.Text + "' ";
                com.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show("Error " + s);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                com.Connection = connect;
                string query = "delete from Try where CustID= '" + txtCancel.Text + "' ";
                com.CommandText = query;

                com.ExecuteNonQuery();
                MessageBox.Show("Data deleted Successfully!");
                connect.Close();

            }
            catch (Exception s)
            {
                MessageBox.Show("Error " + s);
            }
            
        }
    }
}
