using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement
{
    public abstract class Employee
    {
        protected int id;
        protected string name;
        protected string email;
        protected double salary;

        public int Id
        {
            set { this.id = value; }
            get { return id; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }

        public string Email
        {
            set { this.email = value; }
            get { return email; }
        }

        public double Salary
        {
            set { this.salary = value; }
            get { return salary; }
        }
    }
}
