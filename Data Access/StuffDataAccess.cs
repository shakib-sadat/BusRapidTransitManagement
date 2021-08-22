using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRapidTransitManagement.Data_Access
{
    class StuffDataAccess : DataAccess
    {
        public bool LoginValidationStuff(int stuffId, string stuffPassword)
        {
            string sql = "SELECT * FROM Stuffs WHERE StuffId='" + stuffId + "' AND StuffPassword='" + stuffPassword + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }

        public List<Stuff> GetStuffInfo(int stuffId)
        {
            string sql = "SELECT * FROM Stuffs WHERE StuffId = " + stuffId;
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



        public bool UpdateStuffName(int stuffId, string stuffName)
        {
            string sql = "UPDATE Stuffs SET StuffName ='" + stuffName + "' WHERE StuffId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateStuffEmail(int stuffId, string stuffEmail)
        {
            string sql = "UPDATE Stuffs SET StuffEmail='" + stuffEmail + "' WHERE StuffId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateStuffContactNo(int stuffId, string stuffContactNo)
        {
            string sql = "UPDATE Stuffs SET StuffContactNo='" + stuffContactNo + "' WHERE ManagerId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }



        public bool UpdateStuffPassword(int stuffId, string stuffPassword)
        {
            string sql = "UPDATE Stuffs SET StuffPassword='" + stuffPassword + "' WHERE StuffId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateStuffAge(int stuffId, int stuffAge)
        {
            string sql = "UPDATE Stuffs SET Age='" + stuffAge + "' WHERE stuffId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateStuffGender(int stuffId, string stuffGender)
        {
            string sql = "UPDATE Stuffs SET Gender='" + stuffGender + "' WHERE StuffId=" + stuffId;

            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
