namespace SecondCount
{
    class SecondCountApp
    {
        //根据分钟计算秒数
        private static int GetSecondsByMin(int min)
        {
            return min * 60;
        }
        //根据小时数、分钟数计算秒数
        private static int GetSecsByHoursMin(int hour,int min)
        {
            return GetSecondsByMin(min + hour * 60);
        }

        //根据天数、小时数、分钟数计算秒数
        private static int GetSecsByDayHoursMins(int day,int hour,int min)
        {
            return GetSecsByHoursMin(min,hour + day * 24);//注意，本行的方法中只需要min和hour两个参数

        }
        private static void Main()
        {
            Console.WriteLine("Please input DayNum");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input HourNum");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input MinNum");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSecsByDayHoursMins(day, hour, min));

        }
    }
}