using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement.Data_Access
{
    class StuffDataAccess : DataAccess
    {
        public bool LoginValidationStuff(int stuffId, string stuffPassword)
        {
            string sql = "SELECT * FROM Stuffs WHERE StuffId='" + stuffId + "' AND StuffPassword='" + stuffPassword + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }

        public List<Stuff> GetStuffInfo(int stuffId)
        {
            string sql = "SELECT * FROM Stuffs WHERE StuffId = " + stuffId;
            SqlDataReader reader = this.GetData(sql);
            List<Stuff> stuffs = new List<Stuff>();
            while (reader.Read())
            {
                Stuff stuff = new Stuff();
                stuff.StuffId = (int)reader["StuffId"];
                stuff.StuffName = reader["StuffName"].ToString();
                stuff.StuffEmail = reader["StuffEmail"].ToString();
                stuff.StuffContactNo = reader["StuffContactNo"].ToString();
                stuff.StuffShift = reader["StuffShift"].ToString();
                stuff.StuffPassword = reader["StuffPassword"].ToString();
                stuff.StuffAge = (int)reader["Age"];
                stuff.StuffGender = reader["Gender"].ToString();
                stuff.StuffSalary = (double)reader["StuffSalary"];


                stuffs.Add(stuff);
            }
            if (stuffs.Count != 0)
                return stuffs;
            else
                return null;
        }

        public List<Ticket> GetTicketsInfoStuff()
        {
            string sql = "SELECT * FROM Tickets";
            SqlDataReader reader = this.GetData(sql);
            List<Ticket> tickets = new List<Ticket>();
            while (reader.Read())
            {
                Ticket ticket = new Ticket();
                ticket.TicketId = (int)reader["TicketId"];
                ticket.Price = (double)reader["Price"];
                ticket.Date = reader["Date"].ToString();
                ticket.SeatNo = reader["SeatNo"].ToString();
                ticket.PassengerName = reader["PassengerName"].ToString();
                ticket.PhoneNumber = reader["PhoneNumber"].ToString();
                ticket.DepartureLocation = reader["DepartureLocation"].ToString();
                ticket.ArrivalLocation = reader["ArrivalLocation"].ToString();
                ticket.BusId = (int)reader["BusId"];
                ticket.Time = reader["Time"].ToString();

                tickets.Add(ticket);

            }
            if (tickets.Count != 0)
            {
                return tickets;
            }
            else
                return null;
        }
        public List<string> ViewDestinationsStuff()
        {
            string sql = "SELECT * FROM Counters";
            SqlDataReader reader = this.GetData(sql);
            List<string> destinationnames = new List<string>();
            while (reader.Read())
            {
                string destinationName = "";
                destinationName = reader["Destination"].ToString();
                destinationnames.Add(destinationName);
            }
            if (destinationnames.Count != 0)
            {
                return destinationnames;
            }
            else
                return null;
        }
        public List<string> ViewBusesStuff()
        {
            string sql = "SELECT * FROM Buses ";
            SqlDataReader reader = this.GetData(sql);
            List<string> busIds = new List<string>();
            while (reader.Read())
            {
                string BusId = "";
                BusId = reader["BusId"].ToString();
                busIds.Add(BusId);
            }
            if (busIds.Count != 0)
            {
                return busIds;
            }
            else
                return null;
        }

        public string GetDepartureDestinationStuff(int busId)
        {
            string sql = "SELECT * FROM Buses WHERE BusId =  '" + busId + "'";
            SqlDataReader reader = this.GetData(sql);
            string busdeploc = "";
            while (reader.Read())
            {

                busdeploc = reader["DepartureLocation"].ToString();

            }
            return busdeploc;
        }

        public string GetArrivalDestinationStuff(int busId)
        {
            string sql = "SELECT * FROM Buses WHERE BusId =  '" + busId + "'";
            SqlDataReader reader = this.GetData(sql);
            string busarrloc = "";
            while (reader.Read())
            {

                busarrloc = reader["ArrivalLocation"].ToString();

            }
            return busarrloc;
        }

        public List<Bus> GetBusesInfoStuff()
        {
            string sql = "SELECT * FROM Buses";
            SqlDataReader reader = this.GetData(sql);
            List<Bus> buses = new List<Bus>();
            while (reader.Read())
            {
                Bus bus = new Bus();
                bus.BusId = (int)reader["BusId"];
                bus.BusName = reader["BusName"].ToString();
                bus.BusCapacity = (int)reader["BusCapacity"];

                bus.DepartureLocation = reader["DepartureLocation"].ToString();
                bus.ArrivalLocation = reader["ArrivalLocation"].ToString();

                buses.Add(bus);
            }
            if (buses.Count != 0)
            {
                return buses;
            }
            else
                return null;

        }

        public List<Destination> GetDestinationsStuff()
        {
            string sql = "SELECT * FROM Counters";
            SqlDataReader reader = this.GetData(sql);
            List<Destination> destinations = new List<Destination>();
            while (reader.Read())
            {
                Destination destination = new Destination();
                destination.Location = reader["Destination"].ToString();
                destinations.Add(destination);
            }
            if (destinations.Count != 0)
            {
                return destinations;
            }
            else
                return null;
        }
        public bool UpdateStuffName(int stuffId, string stuffName)
        {
            string sql = "UPDATE Stuffs SET StuffName ='" + stuffName + "' WHERE StuffId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateStuffEmail(int stuffId, string stuffEmail)
        {
            string sql = "UPDATE Stuffs SET StuffEmail='" + stuffEmail + "' WHERE StuffId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateStuffContactNo(int stuffId, string stuffContactNo)
        {
            string sql = "UPDATE Stuffs SET StuffContactNo='" + stuffContactNo + "' WHERE ManagerId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }



        public bool UpdateStuffPassword(int stuffId, string stuffPassword)
        {
            string sql = "UPDATE Stuffs SET StuffPassword='" + stuffPassword + "' WHERE StuffId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateStuffAge(int stuffId, int stuffAge)
        {
            string sql = "UPDATE Stuffs SET Age='" + stuffAge + "' WHERE stuffId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateStuffGender(int stuffId, string stuffGender)
        {
            string sql = "UPDATE Stuffs SET Gender='" + stuffGender + "' WHERE StuffId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool AddTicketStuff(int price, int busId, string departueLoaction, string arrivalLocation, string time, string date, string seatNo, string passengerName, string phoneNumber)
        {
            string sql = "INSERT INTO Tickets(Price,BusId,DepartureLocation,ArrivalLocation,Time,Date,SeatNo,PassengerName,PhoneNumber ) VALUES( '" + price + "' , '" + busId + "' , '" + departueLoaction + "' ,'" + arrivalLocation + "' , '" + time + "' , '" + date + "','" + seatNo + "', '" + passengerName + "', '" + phoneNumber + "' )";

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool CancelTicketStuff(int ticketId)
        {
            string sql = "DELETE FROM Tickets WHERE TicketId =" + ticketId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
