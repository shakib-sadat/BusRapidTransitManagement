using BusRapidTransitManagement.Data_Access;
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
        public int stuffInterfaceid;
        public StuffInterface(int id)
        {
            InitializeComponent();
            this.stuffInterfaceid = id;
        }

        

        private void StuffInterface_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            StuffDataAccess stuffDataAccess = new StuffDataAccess();
            HomePageStuff homePagestuff = new HomePageStuff();
            stuffhomepanel.Controls.Clear();
            stuffhomepanel.Controls.Add(homePagestuff);
            StuffIdShowlabel.Text = Login.userId;

        }

        private void Ticketbutton_Click(object sender, EventArgs e)
        {
            stuffhomepanel.Controls.Clear();
            stuffhomepanel.Controls.Add(new Ticketshow_Stuff_());
        }

        

        

        private void ticketshow_Stuff_1_Load(object sender, EventArgs e)
        {

        }

        private void BusInformationbutton_Click(object sender, EventArgs e)
        {
            stuffhomepanel.Controls.Clear();
            
        }

        private void PassengerInfobutton_Click(object sender, EventArgs e)
        {
            stuffhomepanel.Controls.Clear();
            stuffhomepanel.Controls.Add(new PassengerInfo_stuff_());
        }

        private void Countersbutton_Click(object sender, EventArgs e)
        {
            stuffhomepanel.Controls.Clear();
            stuffhomepanel.Controls.Add(new Counters_stuff_());
        }

        private void StuffEditinfobutton_Click(object sender, EventArgs e)
        {
            
            stuffhomepanel.Controls.Clear();
            stuffhomepanel.Controls.Add(new StuffEditInfo(this.stuffInterfaceid));
        }

        private void stuffhomepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StuffLogoutpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StuffIHomepagepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StuffLogoutbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out");
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void StuffInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Login login = new Login();
            login.Show();
            this.Hide();*/
            Application.Exit();
        }

        private void RefreshStuffbutton_Click(object sender, EventArgs e)
        {
            
            HomePageStuff homePagestuff = new HomePageStuff();
            stuffhomepanel.Controls.Clear();
            stuffhomepanel.Controls.Add(homePagestuff);
            
        }
    }
}
