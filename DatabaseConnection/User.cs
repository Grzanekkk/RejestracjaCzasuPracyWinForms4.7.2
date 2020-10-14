using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DatabaseConnection
{
    public class User
    {
        public string id, name, password;

        public DateTime startWorkHour;
        public DateTime finishWorkHour;


        #region Constructors


        public User(string _id, string _name, string _password)
        {
            id = _id;
            name = _name;
            password = _password;

            startWorkHour = DateTime.Today.AddHours(9);
            finishWorkHour = startWorkHour.AddHours(8);
        }

        public User(string _id, string _name)
        {
            id = _id;
            name = _name;

            startWorkHour = DateTime.Today.AddHours(9);
            finishWorkHour = startWorkHour.AddHours(8);
        }


        #endregion Constructors

    }
}
