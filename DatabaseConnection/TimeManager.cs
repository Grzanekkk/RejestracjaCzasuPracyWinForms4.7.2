using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using DatabaseConnection;
using System.Data;

namespace DatabaseConnection
{
    public class TimeManager
    {
        private DataTable dataTable = new DataTable();
        private string query;
        private DBAccess dbAccess = new DBAccess();


        public bool AddNewEvent(string userID, int minutesToCatchUp)
        {
            SqlCommand insertCommand = new SqlCommand($"INSERT into Events(EventID, Date, MinutesToCatchUp, UserID) values(@EventID, @Date, @Minutes, @UserID)");

            insertCommand.Parameters.AddWithValue("@EventID", Guid.NewGuid());
            insertCommand.Parameters.AddWithValue("@Date", DateTime.Now);
            insertCommand.Parameters.AddWithValue("@Minutes", minutesToCatchUp);
            insertCommand.Parameters.AddWithValue("@UserID", userID);

            int row = dbAccess.ExecuteQuery(insertCommand);

            if(row == 1)
            {
                return true;    // Event added successfully
            }
            else
            {
                return false;   // FAILED to add an Event
            }
        }

        public int CountUserTimeToCatchUp(string userID)
        {
            dataTable = new DataTable();
            int minutesToCatchUp = 0;
            query = $"SELECT MinutesToCatchUp from Events Where UserID = '{userID}'";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            foreach(DataRow row in dataTable.Rows)
            {
                minutesToCatchUp += Convert.ToInt32(row["MinutesToCatchUp"]);
            }

            return minutesToCatchUp;
        }

        public int CountMinutesToCatchUpFromNow(User currentUser)
        {
            TimeSpan timeSpan = DateTime.Now - currentUser.finishWorkHour;

            int minutesToCatchUp = Convert.ToInt32(timeSpan.TotalMinutes);

            // AddNewEvent(currentUser.id, minutesToCatchUp);

            return minutesToCatchUp;
        }
    }

}
