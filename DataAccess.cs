using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Data.Sqlite;
using Windows.Storage;
using System.IO;

namespace MomeNikki
{

	public class DataAccess
	{

		public static void InitializeDatabase()
		{
			Windows.Storage.ApplicationData.Current.LocalFolder.CreateFileAsync("nikkis.db", Windows.Storage.CreationCollisionOption.OpenIfExists);
			string dbpath = System.IO.Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "nikkis.db");
			System.Diagnostics.Debug.WriteLine(dbpath);
			using (SqliteConnection db =
			   new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();

				String tableCommand = "CREATE TABLE IF NOT EXISTS " +
					"NikkiTable(YEAR INT NOT NULL, " +
					"MONTH INT NOT NULL," +
					"DAY INT NOT NULL," +
					"HOUR INT NOT NULL," +
					"MINUTE INT NOT NULL," +
					"RECORD TEXT NOT NULL," +
					"ID INT PRIMARY KEY NOT NULL);";
				SqliteCommand createTable = new SqliteCommand(tableCommand, db);
				createTable.ExecuteReader();
			}
		}

		public static int ReturnMaxUid()
		{
			int MaxId = 0;
			string dbpath = System.IO.Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "nikkis.db");
			using (SqliteConnection db =
			   new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();

				SqliteCommand addRecord = new SqliteCommand(Nikki.GenSQLRetriveMaxUID(), db);
				SqliteDataReader query = addRecord.ExecuteReader();
				while (query.Read())
				{
					if (!query.IsDBNull(0))
					{
						System.Diagnostics.Debug.WriteLine(query.GetString(0));
						MaxId = int.Parse(query.GetString(0));
					}

				}

				db.Close();
			}
			return MaxId;
		}

		public static void AddRecordExecute(string sqlCommand)
		{
			string dbpath = System.IO.Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "nikkis.db");

			using (SqliteConnection db =
			   new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();

				SqliteCommand addRecord = new SqliteCommand(sqlCommand, db);
				addRecord.ExecuteReader();
			}
		}

		public static void RemoveRecordExecute(string sqlCommand)
		{
			string dbpath = System.IO.Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "nikkis.db");

			using (SqliteConnection db =
			   new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();

				SqliteCommand addRecord = new SqliteCommand(sqlCommand, db);
				addRecord.ExecuteReader();
			}
		}

		public static void UpdateRecordExecute(string sqlCommand)
		{
			string dbpath = System.IO.Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "nikkis.db");

			using (SqliteConnection db =
			   new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();

				SqliteCommand addRecord = new SqliteCommand(sqlCommand, db);
				addRecord.ExecuteReader();
			}
		}

		public static ObservableCollection<Nikki> GetAllData()
		{
			ObservableCollection<Nikki> entries = new ObservableCollection<Nikki>();
			string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "nikkis.db");
			using (SqliteConnection db =
			   new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();

				SqliteCommand selectCommand = new SqliteCommand
					(Nikki.GenSQLRetriveAll(), db);

				SqliteDataReader query = selectCommand.ExecuteReader();

				while (query.Read())
				{
					Nikki tempNikki = new Nikki((string)query["RECORD"], int.Parse(query["YEAR"].ToString()), int.Parse(query["MONTH"].ToString()),
						int.Parse(query["DAY"].ToString()), int.Parse(query["HOUR"].ToString()), int.Parse(query["MINUTE"].ToString()), int.Parse(query["ID"].ToString()));
					entries.Add(tempNikki);
				}

				db.Close();
			}

			return entries;
		}


		public static ObservableCollection<Nikki> GetRecordsInDay(string whichYear, string whichMonth, string whichDay)
		{
			ObservableCollection<Nikki> entries = new ObservableCollection<Nikki>();
			string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "nikkis.db");
			using (SqliteConnection db =
			   new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();

				SqliteCommand selectCommand = new SqliteCommand
					(Nikki.GenSQLQueryDayRecord(int.Parse(whichYear), int.Parse(whichMonth), int.Parse(whichDay)), db);

				SqliteDataReader query = selectCommand.ExecuteReader();

				while (query.Read())
				{
					Nikki tempNikki = new Nikki((string)query["RECORD"], int.Parse(query["YEAR"].ToString()), int.Parse(query["MONTH"].ToString()),
						int.Parse(query["DAY"].ToString()), int.Parse(query["HOUR"].ToString()), int.Parse(query["MINUTE"].ToString()), int.Parse(query["ID"].ToString()));
					entries.Add(tempNikki);
				}

				db.Close();
			}
			return entries;
		}

		public static ObservableCollection<Nikki> GetRecordsInMonth(string whichYear, string whichMonth)
		{
			ObservableCollection<Nikki> entries = new ObservableCollection<Nikki>();
			string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "nikkis.db");
			using (SqliteConnection db =
			   new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();

				SqliteCommand selectCommand = new SqliteCommand
					(Nikki.GenSQLQueryMonthRecord(int.Parse(whichYear), int.Parse(whichMonth)), db);

				SqliteDataReader query = selectCommand.ExecuteReader();

				while (query.Read())
				{
					Nikki tempNikki = new Nikki((string)query["RECORD"], int.Parse(query["YEAR"].ToString()), int.Parse(query["MONTH"].ToString()),
						int.Parse(query["DAY"].ToString()), int.Parse(query["HOUR"].ToString()), int.Parse(query["MINUTE"].ToString()), int.Parse(query["ID"].ToString()));
					entries.Add(tempNikki);
				}

				db.Close();
			}
			return entries;
		}


		public static ObservableCollection<int> GetAvailableYear()
		{
			ObservableCollection<int> availableDates = new ObservableCollection<int>();
			string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "nikkis.db");
			using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();
				SqliteCommand selectCommand = new SqliteCommand(Nikki.GenSQLRetiveYears(), db);
				SqliteDataReader query = selectCommand.ExecuteReader();
				while (query.Read())
				{
					availableDates.Add(int.Parse(query["YEAR"].ToString()));
				}
				db.Close();
			}
			return availableDates;
		}

		public static ObservableCollection<int> GetAvailableMonth(string whichYear)
		{
			ObservableCollection<int> availableDates = new ObservableCollection<int>();
			string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "nikkis.db");
			using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();
				SqliteCommand selectCommand = new SqliteCommand(Nikki.GenSQLRetiveMonths(whichYear), db);
				SqliteDataReader query = selectCommand.ExecuteReader();
				while (query.Read())
				{
					availableDates.Add(int.Parse(query["MONTH"].ToString()));
				}
				db.Close();
			}
			return availableDates;
		}

		public static ObservableCollection<int> GetAvailableDays(string whichYear, string whichMonth)
		{
			ObservableCollection<int> availableDates = new ObservableCollection<int>();
			string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "nikkis.db");
			using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
			{
				db.Open();
				SqliteCommand selectCommand = new SqliteCommand(Nikki.GenSQLRetiveDays(whichYear, whichMonth), db);
				SqliteDataReader query = selectCommand.ExecuteReader();
				while (query.Read())
				{
					availableDates.Add(int.Parse(query["DAY"].ToString()));
				}
				db.Close();
			}
			return availableDates;
		}


	}
}
