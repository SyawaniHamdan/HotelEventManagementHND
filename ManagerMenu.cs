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
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (rdbEveRep.Checked == true)
            {
                EventReport open = new EventReport();
                open.Show();
                this.Hide();

            }
            else if (rdbSchRep.Checked == true)
            {
                EventSchedule open = new EventSchedule();
                open.Show();
                this.Hide();
            }
            else if (rdbPayRep.Checked == true)
            {
                PaymentReport open = new PaymentReport();
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
