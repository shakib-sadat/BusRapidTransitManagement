﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement
{
    class Passenger
    {
        private string passengerName;
        private int passengerId;
        private string phoneNumber;

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
    }
}
