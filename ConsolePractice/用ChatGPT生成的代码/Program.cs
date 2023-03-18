using System;

namespace CalendarApplication
{

    class CalendarApp
    {
        private static int GetWeekByDay(int year, int month, int day)
        {
            return (int)(new DateTime(year, month, day)).DayOfWeek;
        }

        private static int GetDaysByMonth(int year, int month)
        {
            if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 2:
                        return IsLeapYear(year) ? 29 : 28;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        return 30;
                    default:
                        return 31;
                }
            }
            return 0;
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        private static void PrintMonthCalendar(int year, int month)
        {
            Console.WriteLine($"{year}年{month}月");
            Console.WriteLine("Su\tMo\tTu\tWe\tTh\tFr\tSa");

            int weekDay = GetWeekByDay(year, month, 1);
            for (int i = 0; i < weekDay; i++)
            {
                Console.Write("\t");
            }

            int days = GetDaysByMonth(year, month);
            for (int dayNum = 1; dayNum <= days; dayNum++)
            {
                //打印日期
                Console.Write(dayNum + "\t");
                weekDay = (weekDay + 1) % 7;
                if (weekDay == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        private static void PrintYearCalendar(int year)
        {
            for (int month = 1; month <= 12; month++)
            {
                PrintMonthCalendar(year, month);
            }
        }

        private static void Main()
        {
            Console.WriteLine("请输入年份");
            int year = int.Parse(Console.ReadLine());
            PrintYearCalendar(year);
        }
    }
}