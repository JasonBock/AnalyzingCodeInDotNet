using System;

namespace ZuneBug
{
	// This is a conversion of the C code that caused the leap year bug.
	public static class RealTimeClock
	{
		static readonly byte[] monthtable = new byte[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
		static readonly byte[] monthtable_leap = new byte[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
		private const int ORIGINYEAR = 1980;
		private const int JAN1WEEK = 2; // Jan 1 1980 is a Tuesday

		private static int GetDayOfWeek(uint days) => (int)(((days - 1) + JAN1WEEK) % 7);

		public static DateTime ConvertDays(uint days)
		{
			int dayofweek, month, year;
			var month_tab = new byte[12];

			//Calculate current day of the week
			dayofweek = GetDayOfWeek(days);

			year = ORIGINYEAR;

			while (days > 365)
			{
				if (IsLeapYear(year) != 0)
				{
					if (days > 366)
					{
						days -= 366;
						year += 1;
					}
				}
				else
				{
					days -= 365;
					year += 1;
				}
			}


			// Determine whether it is a leap year
			month_tab = ((IsLeapYear(year) != 0) ? monthtable_leap : monthtable);

			for (month = 0; month < 12; month++)
			{
				if (days <= month_tab[month])
					break;
				days -= month_tab[month];
			}

			month += 1;
			return new DateTime((int)year, (int)month, (int)days);
		}

		static int IsLeapYear(int Year)
		{
			var Leap = 0;
			if ((Year % 4) == 0)
			{
				Leap = 1;
				if ((Year % 100) == 0)
				{
					Leap = ((Year % 400) != 0) ? 0 : 1;
				}
			}

			return Leap;
		}
	}
}