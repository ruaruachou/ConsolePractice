namespace LoopApplication
{
    class Loop
    {
        static void Main(string[] args)
        {
            //float thickness = 0.00001f;
            //for (int i = 0; i < 30; i++)
            //{
            //    thickness *= 2;
            //}
            //Console.WriteLine(thickness);

            /*小球掉落练习
            double height = 100;
            double totalHeight = 0;
            int times = 0;
            while (height > 0.01)
            {
                height /=2;
                totalHeight += height*2;
                times++;
            }
            Console.WriteLine("The total height is {0}" , totalHeight);
            Console.WriteLine("The total times is " + times);
            */
            Random random = new Random();
            int num=random.Next(1, 101);
            int inputNum = 0;
            int count = 0;
            while(inputNum != num)
            {
                inputNum = int.Parse(Console.ReadLine());
                count++;
                if (inputNum > num)
                    Console.WriteLine("大了");
                else if (inputNum < num)
                    Console.WriteLine("小了");
                else
                    Console.WriteLine("对了,总共猜了"+count+"次");
            }//这里也可以while(true)，在else后加break
        }
    }
}