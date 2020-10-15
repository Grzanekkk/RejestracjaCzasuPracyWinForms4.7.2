using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DatabaseConnection
{
    public class UserManager
    {
        string query;
        DataTable dataTable = new DataTable();
        DBAccess dbAccess = new DBAccess();

        public User GetUserWithNameAndPassword(string name, string password)
        {
            dataTable = new DataTable();

            query = $"Select * from Users Where Name = '{name}' AND Password = '{password}'";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            if (dataTable.Rows.Count == 1)
            {
                User currentUser = new User
                (
                    dataTable.Rows[0]["UserID"].ToString(),
                    dataTable.Rows[0]["Name"].ToString(),
                    dataTable.Rows[0]["Password"].ToString()
                );

                return currentUser;
            }
            else
            {
                return null;    // DO ZMIANY !!!!!!!!!!!!!!!!!!
            }
        }

        public User GetUserWithName(string name)
        {
            dataTable = new DataTable();

            query = $"Select * from Users Where Name = '{name}'";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            if (true) // dtUsers.Rows.Count == 1
            {
                User currentUser = new User
                (
                    dataTable.Rows[0]["UserID"].ToString(),
                    dataTable.Rows[0]["Name"].ToString()
                );

                return currentUser;
            }
            else
            {
                return null;    // DO ZMIANY !!!!!!!!!!!!!!!!!!
            }
        }

        public List<User> GetAllUsers()
        {
            dataTable = new DataTable();

            List<User> listOfAllUsers = new List<User>();
            query = $"Select * from Users";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                User user = new User
                (
                    dataTable.Rows[i]["UserID"].ToString(),
                    dataTable.Rows[i]["Name"].ToString()
                );

                listOfAllUsers.Add(user);
                i++;
            }

            return listOfAllUsers;
        }

        public DataTable GetAllUserEvents(string userID)
        {
            dataTable = new DataTable();

            //query = $"SELECT Date, MinutesToCatchUp, UserID from Events Where UserID = '{userID}'";
            query = $"SELECT * from Events Where UserID = '{userID}'";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            return dataTable;
        }
    }
}
