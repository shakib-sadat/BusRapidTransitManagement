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
        private double price;
        //private Passenger npassenger;
        private string departureLocation;
        private string arrivalLocation;
        private string time;
        private string date;
        private string seatNo;
        private string passengerName;
        private int passengerId;
        private string phoneNumber;
        private int busId;

        public string PassengerName
        {
            set { this.passengerName = value; }
            get { return passengerName; }
        }

        public int PassengerId
        {
            set { this.passengerId = value; }
            get { return passengerId; }
        }

        public string PhoneNumber
        {
            set { this.phoneNumber = value; }
            get { return phoneNumber; }
        }
        public int TicketId
        {
            set { this.ticketId = value; }
            get { return ticketId; }
        }

        public double Price
        {
            set { this.price = value; }
            get { return price; }
        }

        /*public Passenger Npassenger
        {
            set { this.npassenger = value; }
            get { return npassenger; }
        }*/

        public string DepartureLocation
        {
            set { this.departureLocation = value; }
            get { return departureLocation; }
        }

        public string ArrivalLocation
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
        public int BusId
        {
            set { this.busId = value; }
            get { return busId; }
        }
    }
}
