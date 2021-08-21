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
            FromManagertextBox.Text = string.Empty;
            SeatNoManagertextBox.Text = string.Empty;
            ToManagertextBox.Text = string.Empty;
            DepartureManagerdateTimePicker.Text = string.Empty;
            DepartureTimeManagertextBox.Text = string.Empty;
            BusIdManagertextBox.Text = string.Empty;
           

            PricetextBox.Text = string.Empty;
        }

        void ConfirmGridView()
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.GetTicketsInfo() != null)
                TicketInfodataGridView.DataSource = managerDataAccess.GetTicketsInfo();
        }
        private void BookTicketManagerbutton_Click(object sender, EventArgs e)
        {
            CancelTicketManagerpanel.Visible = false;
            BookTicketManagerpanel.Visible = true;
        }

        private void CancelTicketManagerbutton_Click(object sender, EventArgs e)
        {
            //BookTicketManagerpanel.Visible = false ;
            CancelTicketManagerpanel.Visible = true;
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
            else if (FromManagertextBox.Text == "")
            {
                MessageBox.Show("Enter Departure Location");
            }
            else if (SeatNoManagertextBox.Text == "")
            {
                MessageBox.Show("Enter SeatNo");
            }
            else if (ToManagertextBox.Text == "")
            {
                MessageBox.Show("Enter Arrival Location");
            }
            else if (DepartureManagerdateTimePicker.Text == "")
            {
                MessageBox.Show("Enter Date");
            }
            else if (DepartureTimeManagertextBox.Text == "")
            {
                MessageBox.Show("Enter Departure Time");
            }
            else if (BusIdManagertextBox.Text == "")
            {
                MessageBox.Show("Enter Bus Id");
            }
            
            else if (PricetextBox.Text == "")
            {
                MessageBox.Show("Enter Price");
            }
            else
            {
                if (managerDataAccess.AddTicket( Convert.ToInt32(PricetextBox.Text), Convert.ToInt32(BusIdManagertextBox.Text)  ,FromManagertextBox.Text, ToManagertextBox.Text, DepartureTimeManagertextBox.Text, DepartureManagerdateTimePicker.Text, SeatNoManagertextBox.Text, PassengerNameManagertextBox.Text, ContactNoManagertextBox.Text))
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

            
        }
        private void Ticketshow_Manager__Load(object sender, EventArgs e)
        {
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
    }
}
