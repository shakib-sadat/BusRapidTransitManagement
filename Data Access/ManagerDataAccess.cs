using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement.Data_Access
{
    class ManagerDataAccess : DataAccess
    {
        public bool LoginValidation(int managerId, string managerPassword)
        {
            string sql = "SELECT * FROM Managers WHERE ManagerId='" + managerId + "' AND ManagerPassword='" + managerPassword + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }

        public List<Stuff> GetStuffControl()
        {
            string sql = "SELECT * FROM Stuffs";
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
        public List<Manager> GetManagerInfo(int managerId)
        {
            string sql = "SELECT * FROM Managers WHERE ManagerId = " + managerId;
            SqlDataReader reader = this.GetData(sql);
            List<Manager> managers = new List<Manager>();
            while (reader.Read())
            {
                Manager manager = new Manager();
                manager.ManagerId = (int)reader["ManagerId"];
                manager.ManagerName = reader["ManagerName"].ToString();
                manager.ManagerEmail = reader["ManagerEmail"].ToString();
                manager.ManagerContactNo = reader["ManagercontactNo"].ToString();
                manager.ManagerPosition = reader["ManagerPosition"].ToString();
                manager.ManagerPassword = reader["ManagerPassword"].ToString();
                manager.ManagerAge = (int)reader["ManagerAge"];
                manager.ManagerGender = reader["Gender"].ToString();


                managers.Add(manager);




            }
            if (managers.Count != 0)
                return managers;

            else
                return null;
        }

        public List<Passenger> GetPassengersInfo()
        {
            string sql = "SELECT * FROM Passengers";
            SqlDataReader reader = this.GetData(sql);
            List<Passenger> passengers = new List<Passenger>();
            while (reader.Read())
            {
                Passenger passenger = new Passenger();
                passenger.PassengerName = reader["PassengerName"].ToString();
                passenger.PassengerId = (int)reader["PassengerId"];
                passenger.PhoneNumber = reader["PhoneNumber"].ToString();

                passengers.Add(passenger);

            }
            if (passengers.Count != 0)
            {
                return passengers;
            }
            else
                return null;
        }

        public List<Ticket> GetTicketsInfo()
        {
            string sql = "SELECT * FROM Tickets";
            SqlDataReader reader = this.GetData(sql);
            List<Ticket> tickets = new List<Ticket>();
            while (reader.Read())
            {
                Ticket ticket = new Ticket();
                ticket.TicketId = (int)reader["TicketId"];
                ticket.Price = (double)reader["Price"];
                //ticket.PassengerId = (int)reader["PassengerId"];
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

        public List<Bus> GetBusesInfo()
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

        public List<Destination> GetDestinations()
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


        public bool UpdateManagerName(int managerId, string managerName)
        {
            string sql = "UPDATE Managers SET ManagerName ='" + managerName + "' WHERE ManagerId=" + managerId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateManagerEmail(int managerId, string managerEmail)
        {
            string sql = "UPDATE Managers SET ManagerEmail='" + managerEmail + "' WHERE ManagerId=" + managerId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateManagerContactNo(int managerId, string managerContactNo)
        {
            string sql = "UPDATE Managers SET ManagercontactNo='" + managerContactNo + "' WHERE ManagerId=" + managerId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }



        public bool UpdateManagerPassword(int managerId, string managerPassword)
        {
            string sql = "UPDATE Managers SET ManagerPassword='" + managerPassword + "' WHERE ManagerId=" + managerId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateManagerAge(int managerId, int managerAge)
        {
            string sql = "UPDATE Managers SET ManagerAge='" + managerAge + "' WHERE ManagerId=" + managerId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateManagerGender(int managerId, string managerGender)
        {
            string sql = "UPDATE Managers SET Gender='" + managerGender + "' WHERE ManagerId=" + managerId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool AddStuff(string stuffName, string stuffEmail, string stuffShift, double stuffSalary, int stuffAge, string stuffGender, string stuffContactNo)


        {
            string sql = "INSERT INTO Stuffs(StuffName,StuffEmail,StuffShift,StuffSalary,Age,Gender,StuffContactNo) VALUES('" + stuffName + "','" + stuffEmail + "' ,'" + stuffShift + "' ," + stuffSalary + "," + stuffAge + ",'" + stuffGender + "'," + stuffContactNo + ")";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool RemoveStuff(int stuffId)
        {
            string sql = "DELETE FROM Stuffs WHERE StuffId =" + stuffId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool ManageSalary(int stufId, double stuffSalary)
        {
            string sql = "UPDATE Stuffs SET StuffSalary=" + stuffSalary + " WHERE StuffId=" + stufId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool AddTicket(int price, int busId, string departueLoaction, string arrivalLocation, string time, string date, string seatNo, string passengerName, string phoneNumber)
        {
            string sql = "INSERT INTO Tickets(Price,BusId,DepartureLocation,ArrivalLocation,Time,Date,SeatNo,PassengerName,PhoneNumber ) VALUES( '" + price + "' , '" + busId + "' , '" + departueLoaction + "' ,'" + arrivalLocation + "' , '" + time + "' , '" + date + "','" + seatNo + "', '" + passengerName + "', '" + phoneNumber + "' )";

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool CancelTicket(int ticketId)
        {
            string sql = "DELETE FROM Tickets WHERE TicketId =" + ticketId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool AddBus(string busName, int busCapacity, string arrivalLocation, string departureLocation)
        {
            string sql = "INSERT INTO Buses(BusName,BusCapacity,ArrivalLocation,DepartureLocation) VALUES(  '" + busName + "' ,'" + busCapacity + "' , '" + arrivalLocation + "' , '" + departureLocation + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Bus> GetBusesByName(string str)
        {
            string sql = "SELECT * FROM Buses WHERE BusName LIKE '" + str + "%'";
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
                return buses;
        }

        public bool RemoveBus(int busId)
        {
            string sql = "DELETE FROM Buses WHERE BusId =" + busId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool AddCounters(string location)
        {
            string sql = "INSERT INTO Counters Destinations VALUES('" + location + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }


    }
}


