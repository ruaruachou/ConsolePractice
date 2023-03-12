namespace CalendarApplication
{
    class CalendarApp
    {
        static void Main(string[] args)
        {


            private static int GetWeekByDay(int year, int month, int day)
            {
                DateTime dt = new DateTime(year, month, day);
                return (int)dt.DayOfWeek;
            }
            private static int GetDaysByMonth(int year, int month)
            {
                if (month >= 1 && month <= 12)
                {
                    switch (month)
                    {
                        case 2:
                            if (IsLeapYear(year) = true) //此处可用三元表达式 if IsLeapYear(year)?29:28;
                                return 29;
                            else return 28;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            return 30;
                        default:
                            return 31;
                    }
                }
                else return 0; //此处可用短路语句放上去，减少一个else
            }
            private static bool IsLeapYear(int year)
            {
                if (year % 4 == 0 && year % 400 == 0 || year % 400 == 0)
                    return true;
                else return false;
            }
            private static void PrintMonthCalendar()
            {
                Console.WriteLine("Su\tMo\tTu\tWd\tTh\tFr\tSa");
            }
        }
    }
}