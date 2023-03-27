using System;
namespace Lottery
{
    class LotteryApp
    {
        static Random random = new Random();

        public static void Main()
        {
            int[] buyNum = BuyNum();//调用购买彩票的方法
            Console.WriteLine();
            int[] ChoicenNmuArray = getRandom();//调用生成彩票的方法
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(ChoicenNmuArray[i]);//打印7个中奖号码
            }
            string result = RewardLevel(ChoicenNmuArray, buyNum);//打印中奖结果
            Console.WriteLine(result);
        }
        private static int[] getRandom()//随机产生一注彩票（1-34间的7个随机数）
        {
            //生成34个元素的数组
            int[] allNumArray = new int[34];
            //生成前6个元素的数组，用于存放中奖号码
            int[] rndNumArrayRed = new int[6];
            //给数组中依次添加1-34的数值作为元素
            for (int i = 0; i < allNumArray.Length; i++)
            {
                allNumArray[i] = i + 1;
            }
            //取6个不重复红色球数字
            for (int i = 0; i < rndNumArrayRed.Length; i++)
            {
                int rndIndexNum = random.Next(i, allNumArray.Length);//生成随机数
                rndNumArrayRed[i] = allNumArray[rndIndexNum];//把随机数给存放随机数的数组
                allNumArray[rndIndexNum] = allNumArray[i];//在生成随机数的数组中，将使用过的随机数放到比i小的位置，使其不再被访问
            }
            Array.Sort(rndNumArrayRed);
            //创建一个包含所有7个号码的数组
            int[] rndNumArray = new int[7];
            Array.Copy(rndNumArrayRed, rndNumArray, 6);
            rndNumArray[6] = random.Next(1, 17);
            return rndNumArray;
        }
        //购买7个号码,且前6个红球号码不能重复
        private static int[] BuyNum()
        {
            int[] BuyNum = new int[7];
            for (int i = 0; i < BuyNum.Length - 1; i++)
            {
                Console.WriteLine("Please input No." + (i + 1) + " between 1-34");
                BuyNum[i] = int.Parse(Console.ReadLine());
                bool isExist = Array.IndexOf(BuyNum, BuyNum[i]) <i;//即当有重复值时，返回true
                if (BuyNum[i] < 1 || BuyNum[i] > 34 || isExist)//如果超出范围，或输入了重复值，则要求重新输入
                {
                    i--;
                }
            }
            //选择一个1-16之间的数作为蓝色球 
            int No7 = -1;
            do
            {
                Console.WriteLine("Please input No.7 between 1-16");
                No7 = int.Parse(Console.ReadLine());
                if (No7 >= 1 && No7 <= 16)
                {
                    break;
                }
            } while (No7 < 1 || No7 > 16);
            //此处可用while(True)死循环，在满足条件后break

            BuyNum[6] = No7;
            return BuyNum;
        }
        //一等奖：6红1蓝。二等奖6红。三等奖5+1。四等奖5+0或4+1。五等奖4+0或3+1.六等奖2+1或1+1或0+1.
        private static string RewardLevel(int[] ChoicenNum, int[] BuyNum)
        {
            //创建2个用于判断红色球的数组，并复制原数组的前6个元素进去
            int[] ChoicenNumRed = new int[ChoicenNum.Length - 1];
            int[] BuyNumRed = new int[BuyNum.Length - 1];
            Array.Copy(ChoicenNum, ChoicenNumRed, ChoicenNum.Length - 1);
            Array.Copy(BuyNum, BuyNumRed, BuyNum.Length - 1);
            //创建2个int数用于统计猜中的数量
            int RedCorrect = 0;
            int BlueCorrect = 0;
            for (int i = 0; i < ChoicenNumRed.Length; i++)
            {
                if (Array.IndexOf(ChoicenNumRed, BuyNumRed[i]) > 0) { RedCorrect++; }
            }
            if (ChoicenNum[6] == BuyNum[6]) { BlueCorrect = 1; }
            //根据猜中的数量返回中奖情况
            string RewardLevel;
            if (RedCorrect == 6 && BlueCorrect == 1) { RewardLevel = "一等奖"; }
            else if (RedCorrect == 6 && BlueCorrect == 0) { RewardLevel = "二等奖"; }
            else if (RedCorrect == 5 && BlueCorrect == 1) { RewardLevel = "三等奖"; }
            else if (RedCorrect == 5 && BlueCorrect == 0) { RewardLevel = "四等奖"; }
            else if (RedCorrect == 4 && BlueCorrect == 1) { RewardLevel = "四等奖"; }
            else if (RedCorrect == 4 && BlueCorrect == 0) { RewardLevel = "五等奖"; }
            else if (RedCorrect == 3 && BlueCorrect == 1) { RewardLevel = "五等奖"; }
            else if (RedCorrect == 2 && BlueCorrect == 1) { RewardLevel = "六等奖"; }
            else if (RedCorrect == 1 && BlueCorrect == 1) { RewardLevel = "六等奖"; }
            else if (RedCorrect == 0 && BlueCorrect == 1) { RewardLevel = "六等奖"; }
            else RewardLevel = "未中奖";
            return RewardLevel;
        }
    }
}