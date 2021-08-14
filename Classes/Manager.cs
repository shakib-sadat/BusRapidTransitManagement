using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement
{
    class Manager : Employee
    {
        private string managerPosition;

        public string ManagerPosition
        {
            set { this.managerPosition = value; }
            get { return managerPosition; }
        }

    }
}
