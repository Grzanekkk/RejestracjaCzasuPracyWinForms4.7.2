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

        public void UpdateEvents(DataTable changes)
        {
            query = $"SELECT * from Events";

            dbAccess.ExecuteDataAdapter(changes, query);
        }

        public int CountUserTimeToCatchUp(string memberID)
        {
            dataTable = new DataTable();
            query = $"SELECT sum(MinutesToCatchUp) Bilans, MemberID from Events where MemberID = '{memberID}' group by MemberID";
            int minutesToCatchUp = 0;

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            if (dataTable.Rows.Count != 0 && !dataTable.Rows[0].IsNull("Bilans") && dataTable.Rows[0]["Bilans"] != DBNull.Value)
            {              
                minutesToCatchUp = Convert.ToInt32(dataTable.Rows[0]["Bilans"]);
            }

            return minutesToCatchUp;
        }

        public int CountMinutesToCatchUpFromNow(User currentUser)
        {
            TimeSpan timeSpan = DateTime.Now - currentUser.finishWorkHour;

            int minutesToCatchUp = Convert.ToInt32(timeSpan.TotalMinutes);

            return minutesToCatchUp;
        }

        public DataTable GetAllUserTimeToCatchUp()
        {
            dataTable = new DataTable();
            query = $"SELECT sum(MinutesToCatchUp) Bilans, MemberID from Events group by MemberID";
            //string query2 = $"SELECT e.*, u.FirstName, u.SurName from Events e inner join CRMember u on e.UserID = u";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            return dataTable;
        }

        public bool CheckIfUserIsWorking(string memberID)
        {
            dataTable = new DataTable();
            query = $"SELECT * from Events where MemberID = '{memberID}'";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            foreach(DataRow row in dataTable.Rows)
            {
                if (row.IsNull("MinutesToCatchUp"))
                {
                    return true;
                }                          
            }

            return false;
        }

        public void StopWorking(string memberID)
        {
            dataTable = new DataTable();
            int minutes = GetMinutesOfWorkSinceStart(memberID);

            minutes -= 480; // 8 hours

            dataTable.Rows[0]["MinutesToCatchUp"] = minutes;

            UpdateEvents(dataTable);
        }

        public void StartWorking(string memberID)
        {
            if(GetMinutesOfWorkSinceStart(memberID) > 12 * 60); // 12 godzin
            {
                DeleteLetestNullRow(memberID);
            }


            AddNewEvent(memberID, 0);
        }

        int GetMinutesOfWorkSinceStart(string memberID)     // return 0 if there is no null record
        {           
            query = $"SELECT * from Events where MinutesToCatchUp IS NULL";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            if (dataTable.Rows.Count == 0)
            {
                return 0;
            }

            DateTime startWorkTime = Convert.ToDateTime(dataTable.Rows[0]["Date"]);

            int minutesOfWork = Convert.ToInt32((DateTime.Now - startWorkTime).TotalMinutes);

            return minutesOfWork;
        }

        void DeleteLetestNullRow(string memberID)
        {
            query = $"DELETE from Events where MinutesToCatchUp IS NULL";
            SqlCommand deleteCommand = new SqlCommand(query);

            dbAccess.ExecuteQuery(deleteCommand);
        }
    }

}
