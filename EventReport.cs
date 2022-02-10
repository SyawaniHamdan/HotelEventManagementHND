using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_Event
{
    public partial class EventReport : Form
    {
        public EventReport()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu open = new MainMenu();
            open.Show();
            this.Hide();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (rdbMon.Checked == true)
            {
                MonthlyEventReport open = new MonthlyEventReport();
                open.Show();
                this.Hide();

            }
            else if (rdbAn.Checked == true)
            {
                AnnuallyEventReport open = new AnnuallyEventReport();
                open.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please Choose Your Action", "ALERT!");    //error handling occur when user directly click here aand did not select one of the option given 
            }
        }
    }
}
