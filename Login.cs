using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusRapidTransitManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Stuffbutton_Click(object sender, EventArgs e)
        {

            Managerlabel.Text = "Stuff";
            Loginpanel.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            Loginpanel.Visible = false;
            Managerlabel.Text = "";
        }

        private void Managerbutton_Click(object sender, EventArgs e)
        {
            Managerlabel.Text = "Manager";
            Loginpanel.Visible = true;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StuffLoginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Managerlabel_Click(object sender, EventArgs e)
        {

        }

        private void ManagerLoginpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
