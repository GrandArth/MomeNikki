using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MomeNikki
{
	public class Nikki
	{
		public int UniqueId { get; set; }
		public static int NextID = 0;
		public string RecordText { get; set; }
		public int RecordYear { get; set; }
		public int RecordMonth { get; set; }
		public int RecordDay { get; set; }
		public int RecordHour { get; set; }
		public int RecordMinute { get; set; }

		public Nikki(string nikkiText, int nikkiYear, int nikkiMonth,
			int nikkiDay, int nikkiHour, int nikkiMinute)
		{
			if (nikkiText != null)
			{
				RecordText = nikkiText;
				RecordYear = nikkiYear;
				RecordMonth = nikkiMonth;
				RecordDay = nikkiDay;
				RecordHour = nikkiHour;
				RecordMinute = nikkiMinute;
				UniqueId = Nikki.NextID;
			}
		}

		public Nikki(string nikkiText, int nikkiYear, int nikkiMonth,
	int nikkiDay, int nikkiHour, int nikkiMinute, int nikkiID)
		{
			if (nikkiText != null)
			{
				RecordText = nikkiText;
				RecordYear = nikkiYear;
				RecordMonth = nikkiMonth;
				RecordDay = nikkiDay;
				RecordHour = nikkiHour;
				RecordMinute = nikkiMinute;
				UniqueId = nikkiID;
			}
		}

		public static string orderSql = " \n ORDER BY YEAR,MONTH,DAY,HOUR,MINUTE,ID ASC";

		public string GenSQLAddtoTable()
		{
			return "INSERT INTO NikkiTable (YEAR,MONTH,DAY,HOUR,MINUTE,RECORD,ID)" +
				$"VALUES ({RecordYear},{RecordMonth},{RecordDay},{RecordHour},{RecordMinute},'{RecordText}',{UniqueId})";
		}

		public static string GenSQLQueryIDRecord(int queryId)
		{
			return $"SELECT * FROM NikkiTable WHERE ID = {queryId}";
		}

		public static string GenSQLQueryYearRecord(int queryYear)
		{
			return $"SELECT * FROM NikkiTable WHERE YEAR = {queryYear} " + orderSql;
		}

		public static string GenSQLQueryMonthRecord(int queryYear, int queryMonth)
		{
			return $"SELECT * FROM NikkiTable WHERE YEAR = {queryYear} AND MONTH = {queryMonth}" + orderSql;
		}

		public static string GenSQLQueryDayRecord(int queryYear, int queryMonth, int queryDay)
		{
			return $"SELECT * FROM NikkiTable WHERE YEAR = {queryYear} AND MONTH = {queryMonth} AND DAY = {queryDay}" + orderSql;
		}

		public static string GenSQLRemoveByID(int queryId)
		{
			return $"DELETE FROM NikkiTable WHERE ID = {queryId}";
		}

		public string GenSQLRemoveSelf()
		{
			return $"DELETE FROM NikkiTable WHERE ID = {UniqueId}";
		}

		public string GenSqlUpdateSelf()
		{
			return $"UPDATE NikkiTable SET YEAR = {RecordYear},MONTH = {RecordMonth},DAY={RecordDay},HOUR={RecordHour},MINUTE={RecordMinute},RECORD='{RecordText}' WHERE ID = {UniqueId}";
		}
		public static string GenSQLRetriveAll()
		{
			return "SELECT * FROM NikkiTable" + orderSql;
		}


		public static string GenSQLRetiveYears()
		{
			return "SELECT DISTINCT YEAR FROM NikkiTable ORDER BY YEAR ASC";
		}
		public static string GenSQLRetiveMonths(string whichYear)
		{
			return $"SELECT DISTINCT MONTH FROM NikkiTable WHERE YEAR = {whichYear} ORDER BY MONTH ASC";
		}
		public static string GenSQLRetiveDays(string whichYear, string whichMonth)
		{
			return $"SELECT DISTINCT DAY FROM NikkiTable WHERE YEAR = {whichYear} AND MONTH = {whichMonth} ORDER BY DAY ASC";
		}

		public static string GenSQLRetriveMaxUID()
		{

			return $"SELECT MAX(ID) FROM NikkiTable";
		}
	}
}
