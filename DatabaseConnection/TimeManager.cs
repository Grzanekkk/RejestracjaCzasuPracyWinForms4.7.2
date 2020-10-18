using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using DatabaseConnection;
using System.Data;
using System.ComponentModel;

namespace DatabaseConnection
{
    public class TimeManager
    {
        private DataTable dataTable = new DataTable();
        private string query;
        private DBAccess dbAccess = new DBAccess();

        public bool AddNewEvent(string memberID, int minutesToCatchUp)
        {
            SqlCommand insertCommand = new SqlCommand($"INSERT into Events(EventID, Date, MinutesToCatchUp, MemberID) values(@EventID, @Date, @Minutes, @MemberID)");

            insertCommand.Parameters.AddWithValue("@EventID", Guid.NewGuid());
            insertCommand.Parameters.AddWithValue("@Date", DateTime.Now);
            insertCommand.Parameters.AddWithValue("@MemberID", memberID);

            if (minutesToCatchUp == 0) 
            {
                insertCommand.Parameters.AddWithValue("@Minutes", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Minutes", minutesToCatchUp);
            }

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

        public int CountUserTimeToCatchUp(string memberID)
        {
            dataTable = new DataTable();
            query = $"SELECT sum(MinutesToCatchUp) Bilans, MemberID from Events where MemberID = '{memberID}' group by MemberID";
            int minutesToCatchUp = 0;

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            if (dataTable.Rows.Count != 0)
            {
                minutesToCatchUp = Convert.ToInt32(dataTable.Rows[0]["Bilans"]);
            }

            return minutesToCatchUp;
        }

        public DataTable GetAllUserTimeToCatchUp()
        {
            dataTable = new DataTable();
            query = $"SELECT sum(MinutesToCatchUp) Bilans, MemberID from Events group by MemberID";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            return dataTable;
        }

        public int CountMinutesToCatchUpFromNow(User currentUser)
        {
            TimeSpan timeSpan = DateTime.Now - currentUser.finishWorkHour;

            int minutesToCatchUp = Convert.ToInt32(timeSpan.TotalMinutes);

            return minutesToCatchUp;
        }

        public void UpdateEvents(DataTable changes)
        {
            query = $"SELECT * from Events";

            dbAccess.ExecuteDataAdapter(changes, query);
        }

        public bool CheckIfUserIsWorking(string memberID)
        {
            dataTable = new DataTable();
            query = $"SELECT * from Events where MemberID = '{memberID}'";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            int i = 0;
            foreach(DataRow row in dataTable.Rows)
            {
                if (dataTable.Rows[i]["MinutesToCatchUp"] == DBNull.Value)
                {
                    return true;
                }                          
            }

            return false;
        }

        public void StopWorking(string memberID)
        {
            dataTable = new DataTable();
            query = $"SELECT * from Events where MinutesToCatchUp IS NULL";

            dbAccess.ReadDataThroughAdapter(query, dataTable);


        }
    }

}
