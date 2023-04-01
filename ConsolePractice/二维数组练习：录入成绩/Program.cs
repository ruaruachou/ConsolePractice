using System;
namespace ScoreRecord
{
    class ScoreRecord
    {
        static void Main()
        {
            float[,] newArray = CreatScoreArray();
        }
        private static float[,]CreatScoreArray()
        {
            int studentNum;
            int subjectNum;
            Console.WriteLine("Please input students' number!");
            studentNum=int.Parse(Console.ReadLine());
            Console.WriteLine("Please input subject's number!");
            subjectNum = int.Parse(Console.ReadLine());
            float[,] scoreArray = new float[studentNum, subjectNum];
            for (int i = 0; i < scoreArray.GetLength(0); i++)
            {
                for (int j = 0; j < scoreArray.GetLength(1); j++)
                {
                    Console.WriteLine("Please input No.{0} student' No.{1} subject!", i+1, j+1);
                    scoreArray[i, j] = float.Parse(Console.ReadLine());
                }
            }
            return scoreArray;
        }
    }
}