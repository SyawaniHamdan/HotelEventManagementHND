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
using System.Drawing.Printing;

namespace FYP_Event
{
    public partial class PaymentReport : Form
    {
        private OleDbConnection connect = new OleDbConnection();

        OleDbCommand com = new OleDbCommand();
        private PrintDocument document = new PrintDocument();
        public PaymentReport()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amie\Desktop\effa sepang\SEM 7 FINALLLLL\PDIE\Hotel Event.accdb;
            Persist Security Info=False;";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                connect.Open();
                com.Connection = connect;
                string query = "select CustID,EName,Etype,QuantityDay,Eloc,StartDate,TimeIn,Deposit,TotalPrice from Try where [Month] ='" + cboMonth.Text + "' ";
                com.CommandText = query;

                listBox1.Items.Add("\t\t\t\t\t\t\t       PAYMENT REPORT          ");
                listBox1.Items.Add("");
                listBox1.Items.Add("\t\t\t\t\t\t\t         SAI VILLA HOTEL       ");
                listBox1.Items.Add("");
                listBox1.Items.Add("\t\t\t\t\t\t   HAVE A GLORIUS DAY IN SAI VILLA HOTEL          ");
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("CustID \t Event Name \t\t Event Type \t Quantity(Day) \t Event Location \t Start Date \t Start Time \t Deposit \t Total Price");
                listBox1.Items.Add("");
                using (OleDbDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader["CustID"].ToString() + "\t" + reader["EName"].ToString() + "\t\t " + reader["EType"].ToString() + "\t    " + reader["QuantityDay"].ToString() + "\t\t  " + reader["ELoc"].ToString() + "\t " + reader["StartDate"].ToString() + "\t " + reader["TimeIn"].ToString() + "\t " + "RM" + reader["Deposit"].ToString() + "\t  " + "RM "+reader["TotalPrice"].ToString());
                    }
                }
                listBox1.Items.Add("");
                listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                connect.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error " + a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = document;
            ppd.Document.DocumentName = "TESTING";
            document.PrintPage += document_PrintPage;
            ppd.ShowDialog();
        }
        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            int leading = 5;
            int leftMargin = 10;
            int topMargin = 10;

            // a few simple formatting options..

            StringFormat FmtCenter = new StringFormat() { Alignment = StringAlignment.Near };

            StringFormat fmt = FmtCenter;

            using (Font font = new Font("Arial Narrow", 12f))
            {
                SizeF sz = e.Graphics.MeasureString("_|", Font);
                float h = sz.Height + leading;

                for (int i = 0; i < listBox1.Items.Count; i++)
                    e.Graphics.DrawString(listBox1.Items[i].ToString(), font, Brushes.Black,
                                          leftMargin, topMargin + h * i, fmt);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerMenu open = new ManagerMenu();
            open.Show();
            this.Hide();
        }
    }
}
