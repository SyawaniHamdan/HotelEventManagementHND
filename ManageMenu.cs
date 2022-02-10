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
    public partial class ManageMenu : Form
    {
        public ManageMenu()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (rdbCheck.Checked == true)
            {
                CheckAvailability open = new CheckAvailability();
                open.Show();
                this.Hide();

            }
            else if (rdbCancel.Checked == true)
            {
                Cancel open = new Cancel();
                open.Show();
                this.Hide();
            }
            else if (rdbSch.Checked == true)
            {
                DailySchedule open = new DailySchedule();
                open.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please Choose Your Action", "ALERT!");    //error handling occur when user directly click here and did not select one of the option given 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            StaffMenu open = new StaffMenu();
            open.Show();
            this.Hide();
        }
    }
}
