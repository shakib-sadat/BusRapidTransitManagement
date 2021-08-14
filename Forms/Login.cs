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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ManagerLoginpanel.Visible = false;
            StuffLoginpanel.Visible = false;

        }

        private void ManagerLoginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Managerbutton_Click(object sender, EventArgs e)
        {
            ManagerLoginpanel.Visible = true;
            StuffLoginpanel.Visible = false;
        }

        private void Stuffbutton_Click(object sender, EventArgs e)
        {
            StuffLoginpanel.Visible = true;
            ManagerLoginpanel.Visible = false;
        }

        

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManagerLoginbutton_Click(object sender, EventArgs e)
        {

        }

        private void StuffLoginbutton_Click(object sender, EventArgs e)
        {
                if (StuffUsertextBox.Text == "")
                {
                    MessageBox.Show("Enter an user ID");
                }
                else if (StuffPasswordtextBox.Text == "")
                {
                    MessageBox.Show("Enter password");
                }
                else
                {
                    if (StuffUsertextBox.Text == "shakib007" && StuffPasswordtextBox.Text == "1234")
                    {
                        MessageBox.Show("Logged in as a Stuff");
                        StuffInterface stuffinterface = new StuffInterface();
                        stuffinterface.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Enter valid User Id and Password");
                    }

                }
            }
        }
    }



