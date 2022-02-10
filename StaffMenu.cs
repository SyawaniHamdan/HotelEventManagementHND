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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (rdbEveRes.Checked == true)
            {
                Reserve open = new Reserve();
                open.Show();
                this.Hide();

            }
            else if (rdbEvePay.Checked == true)
            {
                Payment open = new Payment();
                open.Show();
                this.Hide();
            }
            else if (rdbEveMan.Checked == true)
            {
                ManageMenu open = new ManageMenu();
                open.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please Choose Your Action", "ALERT!");    //error handling occur when user directly click here aand did not select one of the option given 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu open = new MainMenu();
            open.Show();
            this.Hide();
        }
    }
}
