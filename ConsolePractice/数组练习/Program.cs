
using System;
namespace ArrayPractice
{
    class ArrayApp
    {
        public static void Main()
        {
            Console.WriteLine("Please input total studens number:");
            int StudentNum = int.Parse(Console.ReadLine());
            float[] scoreArray;
            scoreArray = new float[StudentNum];
            for (int i = 0; i < scoreArray.Length; i++)
            {
                Console.WriteLine("Please input No." + (i + 1) + " studens's score:");
                float score = float.Parse(Console.ReadLine());
                if (score >= 0 && score <= 100) 
                {
                    scoreArray[i] = score;
                }
                else i--;//此处可不用i--，将13行中的i++自增，移动到19行。
            }

        }
    }
}