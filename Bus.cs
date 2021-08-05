using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement
{
    class Bus
    {
        private int busId;
        private string busName;
        private int busCapacity;
        private List<Destination> destinationList = new List<Destination>();
        private Passenger[] passengerList;
        public int BusId
        {
            set { this.busId = value; }
            get { return busId; }
        }
        public string BusName
        {
            set { this.BusName = value; }
            get { return busName; }
        }

        public int BusCapacity
        {
            set { this.busCapacity = value; }
            get { return busCapacity; }
        }

        public List<Destination> DestinationList
        {
            set { this.destinationList = value; }
            get { return destinationList; }
        }

        public Passenger[] PassengerList
        {
            set { this.passengerList = value; }
            get { return passengerList; }
        }

        public void addPassenger(Passenger passenger)
        {
            for (int i = 0; i < passengerList.Length; i++)
            {
                if (passengerList[i] == null)
                {
                    passengerList[i] = passenger;
                    break;
                }

            }
        }


        public void removePassenger(Passenger passenger)
        {
            for (int i = 0; i < passengerList.Length; i++)
            {
                if (passengerList[i] == passenger)
                {
                    passengerList[i] = null;
                    break;
                }

            }
        }

        public Passenger searchPassenger(int passengerId)
        {
            for (int i = 0; i < passengerList.Length; i++)
            {
                if (passengerList[i] != null && passengerList[i].PassengerId == passengerId)
                {
                    return passengerList[i];
                }
            }
            return null;

        }

        public Destination searchDestination(int destinationId)
        {
            for (int i = 0; i < destinationList.Count; i++)
            {
                if (destinationList[i] != null && destinationList[i].DestinationId == destinationId)
                {
                    return destinationList[i];
                }
            }
            return null;

        }
    }
}

