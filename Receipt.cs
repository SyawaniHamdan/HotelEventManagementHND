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
    public partial class Receipt : Form
    {
        private OleDbConnection connect = new OleDbConnection();

        OleDbCommand com = new OleDbCommand();

        private PrintDocument document = new PrintDocument();
        public Receipt()
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
                    string query = "select CustID,EName,Etype,QuantityDay,Eloc,StartDate,TimeIn,TotalPrice,PayStatus from Try where [CustID] ='" + txtCID.Text + "' ";
                    com.CommandText = query;

                    using (OleDbDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add("");
                            listBox1.Items.Add("\t\t\t\t         SAI VILLA HOTEL       ");
                            listBox1.Items.Add("");
                            listBox1.Items.Add("\t\t\t   HAVE A GLORIUS DAY IN SAI VILLA HOTEL          ");
                            listBox1.Items.Add("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            listBox1.Items.Add("");
                            listBox1.Items.Add("\t\t\t\tCustomer ID     : "+ "  "+(reader["CustID"].ToString()));
                            listBox1.Items.Add("\t\t\t\tEvent Name     :" +"  "+(reader["EName"].ToString()));
                            listBox1.Items.Add("\t\t\t\tEvent Type      : " + "  "+(reader["EType"].ToString()));
                            listBox1.Items.Add("\t\t\t\tQuantity (Day)  : " + "  "+(reader["QuantityDay"].ToString()));
                            listBox1.Items.Add("\t\t\t\tEvent Location : " + "  "+(reader["ELoc"].ToString()));
                            listBox1.Items.Add("\t\t\t\tStart Date         : " + "  "+(reader["StartDate"].ToString()));
                            listBox1.Items.Add("\t\t\t\tStart Time         : " + "  "+(reader["TimeIn"].ToString()));
                            listBox1.Items.Add("\t\t\t\tTotal Price        : " + "  "+(reader["TotalPrice"].ToString()));
                            listBox1.Items.Add("\t\t\t\tStatus               : " + "  "+(reader["PayStatus"].ToString()));
                            listBox1.Items.Add("");
                            listBox1.Items.Add("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            listBox1.Items.Add("\t\t\t\t         THANK YOU       ");
                            listBox1.Items.Add("");
                            listBox1.Items.Add("\t\t\t   PLEASE COME AGAIN LATER          ");
                        }
                    }

                    connect.Close();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error " + a);
                }
        }

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            StaffMenu open = new StaffMenu();
            open.Show();
            this.Hide();
        }
    }
}
