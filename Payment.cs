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
    public partial class Payment : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        Event infoevent = new Event();
        public Payment()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amie\Desktop\effa sepang\SEM 7 FINALLLLL\PDIE\Hotel Event.accdb;
            Persist Security Info=False;";
        }

        private void cboEType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            grpPay.Enabled = true;

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboEvent.Text == "Full Day Meeting")
                {
                    infoevent.EventType = "Full Day Meeting";
                    infoevent.Quantity = int.Parse(cboQuantity.Text);
                    infoevent.SetPriceEvent();
                }
                if (cboEvent.Text == "Half Day Meeting")
                {
                    infoevent.EventType = "Half Day Meeting";
                    infoevent.Quantity = int.Parse(cboQuantity.Text);
                    infoevent.SetPriceEvent(); //invoke method of calculation
                }
                if (cboEvent.Text == "Full Day Seminar")
                {
                    infoevent.EventType = "Full Day Seminar";
                    infoevent.Quantity = int.Parse(cboQuantity.Text);
                    infoevent.SetPriceEvent();
                }
                if (cboEvent.Text == "Half Day Seminar")
                {
                    infoevent.EventType = "Half Day Seminar";
                    infoevent.Quantity = int.Parse(cboQuantity.Text);
                    infoevent.SetPriceEvent();
                }
                if (cboEvent.Text == "Birthday Party")
                {
                    infoevent.EventType = "Birthday Party";
                    infoevent.Quantity = int.Parse(cboQuantity.Text);
                    infoevent.SetPriceEvent();
                }

                txtTotal.Text = Convert.ToString(infoevent.Totalprice) + (".00");
                grpP.Enabled = true;
                txtTotalPr.Text = txtTotal.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter quantity of day", "ALERT");  //error handling occur for user that did not input quantity but already tick the package
            }

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalprice;
            double balance = 0.00;
            double amount;
            try
            {
            totalprice = Convert.ToDouble(txtTotalPr.Text);
            amount = Convert.ToDouble(txtAmount.Text);

                if (amount >= totalprice )
                {
                    balance = (Convert.ToDouble(txtAmount.Text)) - (Convert.ToDouble(txtTotalPr.Text));
                    txtBalance.Text = balance.ToString(("#.00"));
                }
                else
                {
                MessageBox.Show("Please enter valid amount", "ALERT");
                }
                
            grpUpdate.Enabled = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Please insert amount", "ALERT");  //error handling occur for user that did not input quantity but already tick the package
            }
        }
        private void Payment_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                com.Connection = connect;
                string query = "UPDATE Try Set PayStatus ='" + cboStatus.Text + "' where CustID ='" + txtCIDU.Text + "' ";
                MessageBox.Show(query);
                com.CommandText = query;

                com.ExecuteNonQuery();
                MessageBox.Show("Data Update Successful!");
                
            }
            catch (Exception s)
            {
                MessageBox.Show("Error " + s);
            }
            connect.Close();
        }
        private void cboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoevent.EventType = cboEvent.Text;
            string en;

            en = cboEvent.Text;

            if (en == "Full Day Meeting")
            {
                txtPrice.Text = "800.00";
            }

            else if (en == "Half Day Meeting")
            {
                txtPrice.Text = "400.00";
            }
            else if (en == "Full Day Seminar")
            {
                txtPrice.Text = "800.00";
            }
            else if (en == "Half Day Seminar")
            {
                txtPrice.Text = "400.00";
            }
            else if (en == "Birthday Party")
            {
                txtPrice.Text = "150.00";
            }
            else
            {
                txtPrice.Text = "Error Input";
            }

        }

        private void btnDisBill_Click(object sender, EventArgs e)
        {
            Receipt open = new Receipt();
            open.Show();
            this.Hide();
        }

        private void txtCIDU_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
