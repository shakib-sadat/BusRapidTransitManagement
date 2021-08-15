using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusRapidTransitManagement.Forms
{
    public partial class StuffInterface : Form
    {
        public StuffInterface()
        {
            InitializeComponent();
        }

        private void StuffInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void StuffInterface_Load(object sender, EventArgs e)
        {
            
        }

        private void Ticketbutton_Click(object sender, EventArgs e)
        {
            TicketBookpanel.Controls.Add(new Ticketshow_Stuff_());
        }

        private void StuffLogoutbutton_Click(object sender, EventArgs e)
        {
            
           MessageBox.Show("User Logged Out");
           //Login login = new Login();
           //login.Show();
           //this.Hide();
           this.Close();
        }

        private void StuffInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BusInformationbutton_Click(object sender, EventArgs e)
        {
            BusInfopanel.Controls.Add(new BusInfoshow_Stuff_()  );
        }
    }
}
