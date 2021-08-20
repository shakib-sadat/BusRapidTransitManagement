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
            string sql = "SELECT * FROM Stuffs" ;
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

            public bool AddStuff(string stuffName, string stuffEmail, double stuffSalary,int stuffAge, string stuffGender, string stuffContactNo)


            {
                string sql = "INSERT INTO Stuffs(StuffName,StuffEmail,StuffSalary,Age,Gender,StuffContactNo) VALUES('" + stuffName + "','"+ stuffEmail +"' ," + stuffSalary + "," + stuffAge+ ",'" + stuffGender + "'," + stuffContactNo + ")";
                int result = this.ExecuteQuery(sql);
                if (result > 0)
                    return true;
                else
                    return false;
            }
            /*public bool AddStuffId(int stuffId)
            {
                string sql = "INSERT INTO Stuffs(StuffId) VALUES('" + stuffId + "')";
                int result = this.ExecuteQuery(sql);
                if (result > 0)
                    return true;
                else
                    return false;
            }*/
            /*public bool AddStuffEmail(string stuffEmail)
            {
                string sql = "INSERT INTO Stuffs(StuffEmail) VALUES('" + stuffEmail + "')";
                int result = this.ExecuteQuery(sql);
                if (result > 0)
                    return true;
                else
                    return false;
            }
            public bool AddStuffSalary(double stuffSalary)
            {
                string sql = "INSERT INTO Stuffs(StuffSalary) VALUES('" + stuffSalary + "')";
                int result = this.ExecuteQuery(sql);
                if (result > 0)
                    return true;
                else
                    return false;
            }
            public bool AddStuffAge(int stuffAge)
            {
                string sql = "INSERT INTO Stuffs(Age) VALUES('" + stuffAge + "')";
                int result = this.ExecuteQuery(sql);
                if (result > 0)
                    return true;
                else
                    return false;
            }
            public bool AddStuffGender(string stuffGender)
            {
                string sql = "INSERT INTO Stuffs(Gender) VALUES('" + stuffGender + "')";
                int result = this.ExecuteQuery(sql);
                if (result > 0)
                    return true;
                else
                    return false;
            }

            public bool AddStuffContactNo(string stuffContactNo)
            {
                string sql = "INSERT INTO Stuffs(StufContactNo) VALUES('" + stuffContactNo + "')";
                int result = this.ExecuteQuery(sql);
                if (result > 0)
                    return true;
                else
                    return false;
            }

        public bool AddStuffName(string stuffName)
        {
            string sql = "INSERT INTO Stuffs(Gender) VALUES('" + stuffName + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }*/


    }
    }

