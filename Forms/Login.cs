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
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();

          if(ManagerUsertextBox.Text == "")
            {
                MessageBox.Show("Enter an user ID");
            }
          else if(ManagerPasswordtextBox.Text == "")
            {
                MessageBox.Show("Enter password");
            }
          else
            {
                if (managerDataAccess.LoginValidation(Convert.ToInt32(ManagerUsertextBox.Text), ManagerPasswordtextBox.Text))
                {
                    MessageBox.Show("Logged in as a Manager");
                    ManagerInterface managerInterface = new ManagerInterface(Convert.ToInt32(ManagerUsertextBox.Text));
                    managerInterface.Show();
                    this.Hide();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Enter valid User Id and Password");
                }

            }
        }
        

        private void StuffLoginbutton_Click(object sender, EventArgs e)
        {
            StuffDataAccess stuffDataAccess = new StuffDataAccess();
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
                    if (stuffDataAccess.LoginValidationStuff(Convert.ToInt32(StuffUsertextBox.Text), StuffPasswordtextBox.Text))
                    {
                        MessageBox.Show("Logged in as a Stuff");
                        StuffInterface stuffinterface = new StuffInterface(Convert.ToInt32(StuffUsertextBox.Text));
                        stuffinterface.Show();
                        this.Hide();
                        //this.Close();
                }
                    else
                    {
                        MessageBox.Show("Enter valid User Id and Password");
                    }

                }
            }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManagerUsertextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }



