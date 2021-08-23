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
    public partial class Ticketshow_Stuff_ : UserControl
    {
        public Ticketshow_Stuff_()
        {
            InitializeComponent();
            BookTicketpanel.Visible = false;
            CancelTicketpanel.Visible = false;
        }


        public void ClearFields()
        {
            PassengerNametextBox.Text = string.Empty;
            ContactNotextBox.Text = string.Empty;
            FromcomboBox.Text = "";
            SeatNotextBox.Text = string.Empty;
            TocomboBox.Text = string.Empty;
            DeparturedateTimePicker.Text = string.Empty;
            TimetextBox.Text = string.Empty;
            BusIdStuffcomboBox.Text = string.Empty;

            CancelTicketIdtextBox.Text = string.Empty;
            PriceStufftextBox.Text = string.Empty;
        }

        private void DepartureTimelabel_Click(object sender, EventArgs e)
        {

        }

        void ConfirmGridView()
        {
            StuffDataAccess stuffDataAccess = new StuffDataAccess();
            if (stuffDataAccess.GetTicketsInfoStuff() != null)
            {
                TicketInfoStuffdataGridView.DataSource = stuffDataAccess.GetTicketsInfoStuff();
                TicketInfoStuffdataGridView.Columns[1].Visible = false;

            }
            else

                TicketInfoStuffdataGridView.DataSource = null;

            if (stuffDataAccess.GetBusesInfoStuff() != null)
            {
                BusShowStuffdataGridView.DataSource = stuffDataAccess.GetBusesInfoStuff();

            }
            else
                BusShowStuffdataGridView.DataSource = null;
        }
        private void BookTicketbutton_Click(object sender, EventArgs e)
        {
            CancelTicketpanel.Visible = false;
            BookTicketpanel.Visible = true;
            
        }

        private void CancelTicketbutton_Click(object sender, EventArgs e)
        {
            BookTicketpanel.Visible = false;
            CancelTicketpanel.Visible = true;
            
        }

        private void CancelTicketpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BusIdcomboBox_Click(object sender, EventArgs e)
        {
            StuffDataAccess stuffDataAccess = new StuffDataAccess();
            BusIdStuffcomboBox.DataSource = stuffDataAccess.ViewBusesStuff();
        }

        private void TicketConfirmbutton_Click(object sender, EventArgs e)
        {
            StuffDataAccess stuffDataAccess = new StuffDataAccess();
            if (PassengerNametextBox.Text == "")
            {
                MessageBox.Show("Enter a Name");
            }
            else if (ContactNotextBox.Text == "")
            {
                MessageBox.Show("Enter Contact No");
            }

            else if (SeatNotextBox.Text == "")
            {
                MessageBox.Show("Enter SeatNo");
            }
            else if (TocomboBox.Text == FromcomboBox.Text)
            {
                MessageBox.Show("Enter Invalid Location");
            }
            else if (DeparturedateTimePicker.Text == "")
            {
                MessageBox.Show("Enter Date");
            }
            else if (TimetextBox.Text == "")
            {
                MessageBox.Show("Enter Departure Time");
            }



            else if (PriceStufftextBox.Text == "")
            {
                MessageBox.Show("Enter Price");
            }
            else
            {
                bool check2 = true;
                string str2 = PriceStufftextBox.Text;
                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2[i] >= 'a' && str2[i] <= 'z' || str2[i] >= 'A' && str2[i] <= 'Z')
                    {
                        check2 = false;
                        break;
                    }
                }

                if(check2 == true  )
                {
                    if (FromcomboBox.Text == stuffDataAccess.GetDepartureDestinationStuff(Convert.ToInt32(BusIdStuffcomboBox.Text))
                    && TocomboBox.Text == stuffDataAccess.GetArrivalDestinationStuff(Convert.ToInt32(BusIdStuffcomboBox.Text)))

                    {
                        if (stuffDataAccess.AddTicketStuff(Convert.ToInt32(PriceStufftextBox.Text), Convert.ToInt32(BusIdStuffcomboBox.Text), FromcomboBox.Text,
                            TocomboBox.Text, TimetextBox.Text, DeparturedateTimePicker.Text, SeatNotextBox.Text,
                            PassengerNametextBox.Text, ContactNotextBox.Text))
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
                else
                {
                    MessageBox.Show("Price Format Not correct");
                }

                
            }
        }

        private void Ticketshow_Stuff__Load(object sender, EventArgs e)
        {
            ConfirmGridView();
        }

        private void ConfirmCancelbutton_Click(object sender, EventArgs e)
        {
            StuffDataAccess stuffDataAccess = new StuffDataAccess();

            bool check2 = true;
            string str2 = PriceStufftextBox.Text;
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] >= 'a' && str2[i] <= 'z' || str2[i] >= 'A' && str2[i] <= 'Z')
                {
                    check2 = false;
                    break;
                }
            }
            if (check2 == true)
            {
                if (stuffDataAccess.CancelTicketStuff(Convert.ToInt32(CancelTicketIdtextBox.Text)))
                {
                    MessageBox.Show("Canceled Ticket");
                    ConfirmGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Can Not be Canceled");
                    ClearFields();
                }
            }
            else
                MessageBox.Show("Id was not in the right format");

        }

        private void FromcomboBox_Click(object sender, EventArgs e)
        {
            StuffDataAccess stuffDataAccess = new StuffDataAccess();
            FromcomboBox.DataSource = stuffDataAccess.ViewDestinationsStuff();
        }

        private void TocomboBox_Click(object sender, EventArgs e)
        {
            StuffDataAccess stuffDataAccess = new StuffDataAccess();
            TocomboBox.DataSource = stuffDataAccess.ViewDestinationsStuff();
        }
    }
}
