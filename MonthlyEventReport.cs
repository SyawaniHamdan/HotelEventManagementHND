using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Drawing.Printing;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Diagnostics;

namespace FYP_Event
{
    public partial class MonthlyEventReport : Form
    {
        string testing = @"C:\\Users\\amie\\Desktop\\effa sepang\\SEM 7 FINALLLLL\\PDIE\\FYP HOTEL EVENT\\SnorkelingCust.txt";         //path for textfile customer in snorkeling
        private OleDbConnection connect = new OleDbConnection();

        private PrintDocument document = new PrintDocument();

        OleDbCommand com = new OleDbCommand();
        public MonthlyEventReport()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amie\Desktop\effa sepang\SEM 7 FINALLLLL\PDIE\Hotel Event.accdb;
            Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                connect.Open();
                com.Connection = connect;
                string query = "select CustID,EName,Etype,QuantityDay,Eloc,StartDate,TimeIn from Try where [Month] ='" + cboMonth.Text + "' ";
                com.CommandText = query;

                listBox1.Items.Add("\t\t\t\t\t\t\t        MONTHLY REPORT         ");
                listBox1.Items.Add("");
                listBox1.Items.Add("\t\t\t\t\t\t\t         SAI VILLA HOTEL       ");
                listBox1.Items.Add("");
                listBox1.Items.Add("\t\t\t\t\t\t   HAVE A GLORIUS DAY IN SAI VILLA HOTEL          ");
                listBox1.Items.Add("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("CustID \t Event Name \t\t Event Type \t Quantity(Day) \t Event Location \t Start Date \t Start Time");
                listBox1.Items.Add("");
                using (OleDbDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader["CustID"].ToString() + "\t" + reader["EName"].ToString() + "\t\t" + reader["EType"].ToString() + "\t    " + reader["QuantityDay"].ToString() + "\t\t" + reader["ELoc"].ToString() + "\t " + reader["StartDate"].ToString() + "\t " + reader["TimeIn"].ToString());
                    }
                }

                connect.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error " + a);
            }
            //testtt(testing);
        }

        /*
        bool testtt(string testing)
        {
            if (!File.Exists(testing))
            {
                // Create a file to write to. 
                using (StreamWriter file = File.CreateText(testing))
                {
                    string Line = save();
                    file.WriteLine(Line);
                }
            }
            else
                // This text is always added, making the file longer over time 
                // if it is not deleted. 
                using (StreamWriter file = File.AppendText(testing))
                {
                    string Line = save();
                    file.WriteLine(Line);
                }



            return true;
        }
        string save()
        {
            connect.Open();
            com.Connection = connect;
            string query = "select CustID,EName,Etype,QuantityDay,Eloc,StartDate,TimeIn from Try where [Month] ='" + cboMonth.Text + "' ";
            com.CommandText = query;

            StringBuilder sb = new StringBuilder();
            sb.Append("\t\t\t\t\t\t\t            WELCOME TO          ");
            sb.Append("\n");
            sb.Append("\t\t\t\t\t\t\t         SAI VILLA HOTEL       ");
            sb.Append("\n");
            sb.Append("\t\t\t\t\t\t   HAVE A GLORIUS DAY IN SAI VILLA HOTEL          ");
            sb.Append("\n");
            sb.Append("CustID \t Event Name \t\t Event Type \t Quantity(Day) \t Event Location \t Start Date \t Start Time");
            using (OleDbDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {
                    sb.Append("\n"); 
                    sb.Append(reader["CustID"].ToString() + "\t" + reader["EName"].ToString() + "\t\t" + reader["EType"].ToString() + "\t    " + reader["QuantityDay"].ToString() + "\t\t" + reader["ELoc"].ToString() + "\t " + reader["StartDate"].ToString() + "\t " + reader["TimeIn"].ToString());
                }
            }
            connect.Close();
            Debug.WriteLine(sb.ToString());

            return sb.ToString();
        }

        */

        private void btnPrint_Click(object sender, EventArgs e)
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
            int leftMargin = 50;
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
        private void MonthlyEventReport_Load(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerMenu open = new ManagerMenu();
            open.Show();
            this.Hide();
        }
    }
}
