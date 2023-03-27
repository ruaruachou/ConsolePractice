
using System;
namespace ArrayPractice
{
    class ArrayApp
    {
        public static void Main()
        {
            float[] scoreArray = getArray();
            float max = GetMax(scoreArray);
            Console.WriteLine("The max score is" + max);
        }
        //在数组中寻找最大值的方法
        private static float GetMax(float[]array)
        {
            float max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        //形成数组的方法
        private static float[] getArray()
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
                else i--;//此处可不用i--，将33行中的i++自增，移动到39行方括号中。
            }
            return scoreArray;
        }
    }
}