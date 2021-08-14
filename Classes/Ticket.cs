using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement
{
    class Ticket
    {
        private int ticketId;
        private int price;
        private Passenger npassenger;
        private Destination departureLocation;
        private Destination arrivalLocation;
        private string time;
        private string date;
        private string seatNo;

        public int TicketId
        {
            set { this.ticketId = value; }
            get { return ticketId; }
        }

        public int Price
        {
            set { this.price = value; }
            get { return price; }
        }

        public Passenger Npassenger
        {
            set { this.npassenger = value; }
            get { return npassenger; }
        }

        public Destination DepartureLocation
        {
            set { this.departureLocation = value; }
            get { return departureLocation; }
        }

        public Destination ArrivalLocation
        {
            set { this.arrivalLocation = value; }
            get { return arrivalLocation; }
        }

        public string Time
        {
            set { this.time = value; }
            get { return time; }
        }

        public string Date
        {
            set { this.date = value; }
            get { return date; }
        }

        public string SeatNo
        {
            set { this.seatNo = value; }
            get { return seatNo; }
        }
    }
}
