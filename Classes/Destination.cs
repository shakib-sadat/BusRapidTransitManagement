using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement
{
    class Destination
    {
        private int destinationId;
        private string time;
        private string location;

        public int DestinationId
        {
            set { this.destinationId = value; }
            get { return destinationId; }
        }
        public string Time
        {
            set { this.time = value; }
            get { return time; }
        }

        public string Location
        {
            set { this.location = value; }
            get { return location; }
        }

    }
}

