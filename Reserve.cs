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
    public partial class Reserve : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        Customer infoCustomer = new Customer();
        Event infoevent = new Event();
        facility infofacility = new facility();
        reservation inforeservation = new reservation();

        OleDbCommand com = new OleDbCommand();

        public Reserve()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amie\Desktop\effa sepang\SEM 7 FINALLLLL\PDIE\Hotel Event.accdb;
            Persist Security Info=False;";
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                lblDetail.Text = "Please fill your personal detail in the provided form below:";
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (txtCustID.Text != "" && txtCustName.Text != "" && txtPhone.Text != "" && txtEmail.Text != "")
            {

                infoCustomer.CustID = txtCustID.Text;
                infoCustomer.CustName = txtCustName.Text;
                infoCustomer.PhoneNo = txtPhone.Text;
                infoCustomer.Email = txtEmail.Text;

                try
                {
                    connect.Open();
                    com.Connection = connect;
                    com.CommandText = "insert into Try (CustID, CustName, Phone, Email) values ('" + txtCustID.Text + "','" + txtCustName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "')";

                    com.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successful!");
                    grpCustDetail.Enabled = false;
                }

                catch (Exception er)
                {
                    MessageBox.Show("Error" + er);
                }
                connect.Close();
            }
            else if (txtCustID.Text == "" || txtCustName.Text == "" || txtPhone.Text == "" || txtEmail.Text != "")
            {
                MessageBox.Show("Please Fill In All The Information Needed", "Alert");//error handling occur for user that did not fill in all the information needed
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grpCustDetail.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustName.Text = null;
            txtCustID.Text = null;
            txtEmail.Text = null;
            txtPhone.Text = null;
            dataGridView2.DataSource = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                com.Connection = connect;
                string query = "select * from Try where CustID='" + txtID.Text + "' ";
                com.CommandText = query;

                OleDbDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    txtID.Text = reader["CustID"].ToString();
                    txtEName.Text = reader["EName"].ToString();
                    cboEType.Text = reader["EType"].ToString();
                    cboDay.Text = reader["QuantityDay"].ToString();
                    cboELoc.Text = reader["ELoc"].ToString();
                    txtMax.Text = reader["MaxSeat"].ToString();

                }
                connect.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show("Error " + s);
            }
            
        }
        private void btnNew1_Click(object sender, EventArgs e)
        {
           grpEventD.Enabled = true;
           txtID.Text = infoCustomer.CustID;
        }
        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtEName.Text != "" && cboEType.Text != "" && cboDay.Text != "" && cboELoc.Text != "" && txtMax.Text != "")
            {
                try
                {
                    connect.Open();
                    com.Connection = connect;
                    string query = "update Try set EName='" + txtEName.Text + "' ,EType='" + cboEType.Text + "' ,QuantityDay='" + cboDay.Text + "', ELoc='" + cboELoc.Text + "' ,MaxSeat='" + txtMax.Text + "',TotalPrice='" + txtTotal.Text + "' where CustID ='" + txtID.Text + "' ";

                    MessageBox.Show(query);
                    com.CommandText = query;

                    com.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successful!");

                    connect.Close();

                }
                catch (Exception s)
                {
                    MessageBox.Show("Error " + s);
                }
            }
            else if (txtID.Text == "" || txtEName.Text == "" || cboEType.Text == "" || cboDay.Text == "" || cboELoc.Text == "" || txtMax.Text != "")
            {
                MessageBox.Show("Please Fill In All The Information Needed", "Alert");//error handling occur for user that did not fill in all the information needed
            }

        }
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtEName.Text = null;
            cboEType.Text = null;
            cboELoc.Text = null;
            txtMax.Text = null;
            cboDay.Text = null;
                 
        }
        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (txtCID1.Text != "" && txtC.Text != "" && txtT.Text != "" && txtPA.Text != "" && txtMic.Text != "")
            {
                infofacility.Chair = Convert.ToInt32(txtC.Text);
                infofacility.Table = Convert.ToInt32(txtT.Text);
                infofacility.PAsystem = Convert.ToInt32(txtPA.Text);
                infofacility.Mic = Convert.ToInt32(txtMic.Text);

                try
                {
                    connect.Open();
                    com.Connection = connect;
                    string query = "update [Try] set [Chair]='" + txtC.Text + "' ,[Table]='" + txtT.Text + "' ,[PAsystem]='" + txtPA.Text + "', [Microphone]='" + txtMic.Text + "' where [CustID] ='" + txtCID1.Text + "' ";

                    MessageBox.Show(query);
                    com.CommandText = query;

                    com.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successful!");
                    connect.Close();

                }
                catch (Exception s)
                {
                    MessageBox.Show("Error " + s);
                }
            }
            else if (txtCID1.Text == "" || txtC.Text == "" || txtT.Text == "" || txtPA.Text == "" || txtMic.Text == "")
            {
                MessageBox.Show("Please Fill In All The Information Needed", "Alert");//error handling occur for user that did not fill in all the information needed
            }
            
        }
        private void btnNew2_Click(object sender, EventArgs e)
        {
            grpFacilityD.Enabled = true;
            txtCID1.Text = infoCustomer.CustID;
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            txtCID1.Text = null;
            txtC.Text = null;
            txtT.Text = null;
            txtPA.Text = null;
            txtMic.Text = null;
        }

        private void btnNew3_Click(object sender, EventArgs e)
        {
            grpReserveD.Enabled = true;
            txtCusID.Text = infoCustomer.CustID;
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            if (txtCusID.Text != "" && cboStaff.Text != "" && dateS.Text != "" && dateE.Text != "" && TimeS.Text != "" && txtDeposit.Text != "" && txtEType.Text != "" && txtDay.Text != "" && txtLoc.Text != "")
            {
                try
                {
                    connect.Open();
                    com.Connection = connect;
                    string query = "update [Try] set [Staff]='" + cboStaff.Text + "' ,[StartDate]='" + dateS.Text + "', [EndDate]='" + dateE.Text + "', [TimeIn]='" + TimeS.Text + "', [Deposit]='" + txtDeposit.Text + "', [EType]='" + txtEType.Text + "', [QuantityDay]='" + txtDay.Text + "', [ELoc]='" + txtLoc.Text + "', [PayStatus]='" + cboStatus.Text + "', [Month]='" + cboMonth.Text + "', [Year]='" + txtYear.Text + "' where [CustID] ='" + txtCusID.Text + "' ";

                    MessageBox.Show(query);
                    com.CommandText = query;

                    com.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successful!");
                    connect.Close();

                }

                catch (Exception s)
                {
                    MessageBox.Show("Error " + s);
                }
            }
            else if (txtCusID.Text == "" || cboStaff.Text == "" || dateS.Text == "" || dateE.Text == "" || TimeS.Text == "" || txtDeposit.Text == "" || txtEType.Text == "" || txtDay.Text == "" || txtLoc.Text == "")
            {
                MessageBox.Show("Please Fill In All The Information Needed", "Alert");//error handling occur for user that did not fill in all the information needed
            }
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            txtCusID.Text = null;
            cboStaff.Text = null;
            dateS.Text = null;
            dateE.Text = null;
            TimeS.Text = null;
            txtEType.Text = null;
            txtDay.Text = null;
            txtLoc.Text = null;
            txtDeposit.Text = null;
            cboStatus.Text = null;
            cboMonth.Text = null;
            txtYear.Text = null;
            dataGridView1.DataSource = null;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                com.Connection = connect;
                string query = "select CustID,CustName,Phone,Email from Try";
                com.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                connect.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show("Error " + s);
            }
        }

        private void btnLInfo_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                com.Connection = connect;
                string query = "select CustID,EName,EType,QuantityDay,ELoc,Staff,StartDate,EndDate,Month,Year,TimeIn,Deposit from Try";
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

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffMenu open = new StaffMenu();
            open.Show();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
                MainMenu open = new MainMenu();
                open.Show();
                this.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtCID1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                com.Connection = connect;
                string query = "select * from Try where CustID='" + txtCID1.Text + "' ";
                com.CommandText = query;

                OleDbDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    txtCID1.Text = reader["CustID"].ToString();
                    txtC.Text = reader["Chair"].ToString();
                    txtT.Text = reader["Table"].ToString();
                    txtPA.Text = reader["PAsystem"].ToString();
                    txtMic.Text = reader["Microphone"].ToString();
                }
                connect.Close();

            }
            catch (Exception s)
            {
                MessageBox.Show("Error " + s);
            }
            
        }

        private void txtCusID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                com.Connection = connect;
                string query = "select * from Try where CustID='" + txtCusID.Text + "' ";
                com.CommandText = query;

                OleDbDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    txtCusID.Text = reader["CustID"].ToString();
                    txtEType.Text = reader["EType"].ToString();
                    txtDay.Text = reader["QuantityDay"].ToString();
                    txtLoc.Text = reader["ELoc"].ToString();
                    cboStaff.Text = reader["Staff"].ToString();
                    dateS.Text = reader["StartDate"].ToString();
                    dateE.Text = reader["EndDate"].ToString();
                    TimeS.Text = reader["TimeIn"].ToString();
                }
                connect.Close();

            }
            catch (Exception s)
            {
                MessageBox.Show("Error " + s);
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboEType.Text == "Full Day Meeting")
                {
                    infoevent.EventType = "Full Day Meeting";
                    infoevent.Quantity = int.Parse(cboDay.Text);
                    infoevent.SetPriceEvent();
                }
                if (cboEType.Text == "Half Day Meeting")
                {
                    infoevent.EventType = "Half Day Meeting";
                    infoevent.Quantity = int.Parse(cboDay.Text);
                    infoevent.SetPriceEvent(); //invoke method of calculation
                }
                if (cboEType.Text == "Full Day Seminar")
                {
                    infoevent.EventType = "Full Day Seminar";
                    infoevent.Quantity = int.Parse(cboDay.Text);
                    infoevent.SetPriceEvent();
                }
                if (cboEType.Text == "Half Day Seminar")
                {
                    infoevent.EventType = "Half Day Seminar";
                    infoevent.Quantity = int.Parse(cboDay.Text);
                    infoevent.SetPriceEvent();
                }
                if (cboEType.Text == "Birthday Party")
                {
                    infoevent.EventType = "Birthday Party";
                    infoevent.Quantity = int.Parse(cboDay.Text);
                    infoevent.SetPriceEvent();
                }

                txtTotal.Text = Convert.ToString(infoevent.Totalprice) + (".00");


            }
            catch (Exception)
            {
                MessageBox.Show("Please enter quantity of day", "ALERT");  //error handling occur for user that did not input quantity but already tick the package
            }
        }

        private void cboEType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
