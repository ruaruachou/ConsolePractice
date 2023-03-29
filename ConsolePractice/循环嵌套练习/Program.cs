using System;
namespace Lottery
{
    class LotteryApp 
    {
       private static void Main()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                   
                }
                for (int k = 0; k < 4-i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}