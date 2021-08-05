using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement
{
    
        class Stuff : Employee
        {
            private string shift;

            public string Shift
            {
                set { this.shift = value; }
                get { return shift; }
            }
        }
    
}
