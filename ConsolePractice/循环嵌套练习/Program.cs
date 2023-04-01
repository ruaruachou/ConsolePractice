using System;
namespace DoubleLoop
{
    class DoubleLoopApp
    {
        private static void Main()
        {
            int[] array = new int[] { 2, 8, 6, 1 ,1};
            bool isReaped=false;
            isReaped=IsReap(array);
            if (isReaped == true) { Console.WriteLine("repeated"); }
            
        }
        private static bool IsReap(int[] targetArray)
        {
            bool isReaped=false;
            for (int i = 0; i < targetArray.Length; i++)//i=2
            {
                for (int j = 1; j<targetArray.Length-i ; j++)//length=3
                {
                    if (targetArray[i] == targetArray[i + j ]) isReaped = true;
                    
                }
            }
            return isReaped;

        }
    }
}