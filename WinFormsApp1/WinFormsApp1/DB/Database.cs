using System;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
	public class Database
	{
		public SQLiteConnection myConnection;
		public Database()
		{
			myConnection = new SQLiteConnection("Data Source = ./DB/auto_timetable.db;foreign keys=true;");
		}

		public void OpenConnection()
        {
			if(myConnection.State != System.Data.ConnectionState.Open)
            {
				myConnection.Open();
            }
        }

		public void CloseConnection()
		{
			if (myConnection.State == System.Data.ConnectionState.Open)
			{
				myConnection.Close();
			}
		}
	}
}
