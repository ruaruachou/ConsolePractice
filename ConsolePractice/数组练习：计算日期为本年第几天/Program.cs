
using System;
namespace AGetDayOrder
{
    class GetDayOrderApp
    {
        private static int GetDayOrder(int year, int month, int day)
        {
            int[] dayOfMonthNotLeapYear = new int[12] { 31, 28, 31, 30, 31, 30, 31, 30, 30, 31, 30, 31 };
            int[] dayOfMonthIsLeapYear = new int[12] { 31, 29, 31, 30, 31, 30, 31, 30, 30, 31, 30, 31 };
            int dayOrder = day;
            if (year % 4 == 0 && year % 400 == 0 || year % 400 == 0)
            {
                for (int i = 0; i < month - 1; i++)
                {
                    dayOrder += dayOfMonthIsLeapYear[i];
                }
            }
            else
                for (int i = 0; i < month - 1; i++)
                {
                    dayOrder += dayOfMonthNotLeapYear[i];
                }
            return dayOrder;
        }
        public static void Main()
        {
            Console.WriteLine("Please input year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input day:");
            int day = int.Parse(Console.ReadLine());
            int dayOrder = GetDayOrder(year, month, day);
            Console.WriteLine("The day order is No." + dayOrder);

            //private static int GetDayOrder(int year, int month, int day)
            //{
            //    int[] dayOfMonthNotLeapYear = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //    int[] dayOfMonthIsLeapYear = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //    int dayOrder = day;
            //    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            //    {
            //        for (int i = 0; i < month - 1; i++)
            //        {
            //            dayOrder += dayOfMonthIsLeapYear[i];
            //        }
            //    }
            //    else
            //    {
            //        for (int i = 0; i < month - 1; i++)
            //        {
            //            dayOrder += dayOfMonthNotLeapYear[i];
            //        }
            //    }
            //    return dayOrder;
            }

        }
    }


