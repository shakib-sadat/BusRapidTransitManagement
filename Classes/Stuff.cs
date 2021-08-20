using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement
{
    
        class Stuff
        {
            private string stuffShift;
            protected int stuffId;
            protected string stuffName;
            protected string stuffEmail;
            protected double stuffSalary;
            protected int stuffAge;
            protected string stuffGender;
            protected string stuffPassword;
            protected string stuffContactNo;


        public string StuffShift
            {
                set { this.stuffShift = value; }
                get { return stuffShift; }
            }

        
        public int StuffId
        {
            set { this.stuffId = value; }
            get { return stuffId; }
        }

        public string StuffName
        {
            set { this.stuffName = value; }
            get { return stuffName; }
        }

        public string StuffEmail
        {
            set { this.stuffEmail = value; }
            get { return stuffEmail; }
        }

        public double StuffSalary
        {
            set { this.stuffSalary = value; }
            get { return stuffSalary; }
        }

        public int StuffAge
        {
            set { this.stuffAge = value; }
            get { return stuffAge; }
        }

        public string StuffGender
        {
            set { this.stuffGender = value; }
            get { return stuffGender; }
        }

        public string StuffContactNo
        {
            set { this.stuffContactNo = value; }
            get { return stuffContactNo; }
        }

        public string StuffPassword
        {
            set { this.stuffPassword = value; }
            get { return stuffPassword; }
        }

    }
    
}
