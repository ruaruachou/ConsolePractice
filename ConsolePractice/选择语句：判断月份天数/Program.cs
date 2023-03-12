namespace GetDaysByMonthApplication
{
    class GetDaysByMonth
    {
        static void Main(string[] args)
        {
            int month;
            int day;
            Console.WriteLine("Please input month!");
            month = int.Parse(Console.ReadLine());

            if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 2:
                        day = 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day = 30;
                        break;
                    default:
                        day = 31;
                        break;
                }
                Console.WriteLine("{0} month has {1} days", month, day);
            }
            else
            {
                Console.WriteLine("error");
            }




        }
    }
}