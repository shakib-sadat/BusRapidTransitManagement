using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement
{
    class Manager 
    {
        private string managerPosition;
        
        protected int managerId;
        protected string managerName;
        protected string managerEmail;
        
        protected int managerAge;
        protected string managerGender;
        protected string managerPassword;
        protected string managerContactNo;


        


        public int ManagerId
        {
            set { this.managerId = value; }
            get { return managerId; }
        }

        public string ManagerName
        {
            set { this.managerName = value; }
            get { return managerName; }
        }

        public string ManagerEmail
        {
            set { this.managerEmail = value; }
            get { return managerEmail; }
        }

        

        public int ManagerAge
        {
            set { this.managerAge = value; }
            get { return managerAge; }
        }

        public string ManagerGender
        {
            set { this.managerGender = value; }
            get { return managerGender; }
        }

        public string ManagerContactNo
        {
            set { this.managerContactNo = value; }
            get { return managerContactNo; }
        }

        public string ManagerPassword
        {
            set { this.managerPassword = value; }
            get { return managerPassword; }
        }
        public string ManagerPosition
        {
            set { this.managerPosition = value; }
            get { return managerPosition; }
        }

    }
}
