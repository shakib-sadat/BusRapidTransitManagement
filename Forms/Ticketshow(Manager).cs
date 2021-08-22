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
    public partial class Ticketshow_Manager_ : UserControl
    {
        
        public Ticketshow_Manager_()
        {
            
            InitializeComponent();
            BookTicketManagerpanel.Visible = false;
            CancelTicketManagerpanel.Visible = false;
        }

        public void ClearFields()
        {
            PassengerNameManagertextBox.Text = string.Empty;
            ContactNoManagertextBox.Text = string.Empty;
            FromManagercomboBox.Text = "";
            SeatNoManagertextBox.Text = string.Empty;
            ToManagercomboBox.Text = string.Empty;
            DepartureManagerdateTimePicker.Text = string.Empty;
            DepartureTimeManagertextBox.Text = string.Empty;
            BusIdcomboBox.Text = string.Empty;
           

            PricetextBox.Text = string.Empty;
        }

        void ConfirmGridView()
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.GetTicketsInfo() != null)
            {
                TicketInfodataGridView.DataSource = managerDataAccess.GetTicketsInfo();
                TicketInfodataGridView.Columns[1].Visible = false;

            }
            else

                TicketInfodataGridView.DataSource = null;

            if (managerDataAccess.GetBusesInfo() != null)
            {
                BusShowdataGridView.DataSource = managerDataAccess.GetBusesInfo();

            }
            else
                BusShowdataGridView.DataSource = null;
        }
        private void BookTicketManagerbutton_Click(object sender, EventArgs e)
        {
            CancelTicketManagerpanel.Visible = false;
            BookTicketManagerpanel.Visible = true;
        }

        private void CancelTicketManagerbutton_Click(object sender, EventArgs e)
        {
            BookTicketManagerpanel.Visible = false ;
            CancelTicketManagerpanel.Visible = true;
            ClearFields();
        }

        private void TicketConfirmManagerbutton_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();

            if (PassengerNameManagertextBox.Text == "")
            {
                MessageBox.Show("Enter a Name");
            }
            else if (ContactNoManagertextBox.Text == "")
            {
                MessageBox.Show("Enter Contact No");
            }

            else if (SeatNoManagertextBox.Text == "")
            {
                MessageBox.Show("Enter SeatNo");
            }
            else if (ToManagercomboBox.Text == FromManagercomboBox.Text)
            {
                MessageBox.Show("Enter Invalid Location");
            }
            else if (DepartureManagerdateTimePicker.Text == "")
            {
                MessageBox.Show("Enter Date");
            }
            else if (DepartureTimeManagertextBox.Text == "")
            {
                MessageBox.Show("Enter Departure Time");
            }


            else if (PricetextBox.Text == "")
            {
                MessageBox.Show("Enter Price");
            }
            else
            {


                if (FromManagercomboBox.Text == managerDataAccess.GetDepartureDestination(Convert.ToInt32(BusIdcomboBox.Text))
                    && ToManagercomboBox.Text == managerDataAccess.GetArrivalDestination(Convert.ToInt32(BusIdcomboBox.Text)))

                {
                    if (managerDataAccess.AddTicket(Convert.ToInt32(PricetextBox.Text), Convert.ToInt32(BusIdcomboBox.Text), FromManagercomboBox.Text,
                        ToManagercomboBox.Text, DepartureTimeManagertextBox.Text, DepartureManagerdateTimePicker.Text, SeatNoManagertextBox.Text,
                        PassengerNameManagertextBox.Text, ContactNoManagertextBox.Text))
                    {
                        MessageBox.Show("New Ticket Booked");
                        ConfirmGridView();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error in Booking");
                        ClearFields();

                    }

                }

                else
                {
                    MessageBox.Show("Departure And Arrival Location not Correct");
                }
            }



        

            
        }
        private void Ticketshow_Manager__Load(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            ConfirmGridView();
           
            
            

        }

        private void ConfirmCancelManagerbutton_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.CancelTicket(Convert.ToInt32(CancelManagerTicketIdtextBox.Text)))
            {
                MessageBox.Show("Canceled Ticket");
                ConfirmGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Can Not be canceled");
                ClearFields();
            }
        }

        private void BookTicketManagerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FromManagercomboBox_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            FromManagercomboBox.DataSource = managerDataAccess.ViewDestinations();
        }

        private void ToManagercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BusIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToManagercomboBox_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            ToManagercomboBox.DataSource = managerDataAccess.ViewDestinations();
        }

        private void BusIdcomboBox_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            BusIdcomboBox.DataSource = managerDataAccess.ViewBuses();
        }
    }
}
