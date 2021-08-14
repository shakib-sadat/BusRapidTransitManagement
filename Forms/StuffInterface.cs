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
    }
}
