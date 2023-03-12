namespace GradeApplication
{
    class HGradeApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("您好，请输入成绩！");
            float grade = float.Parse(Console.ReadLine());
            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("Perfect");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 60 && grade < 80)
            {
                Console.WriteLine("Qualified");
            }
            else if (grade >= 0 && grade < 60)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}