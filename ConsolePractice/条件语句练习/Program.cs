using System;
namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {

            Console.WriteLine("您好，请输入第一个数字！");
            string strNum1 = Console.ReadLine();
            int num1 = int.Parse(strNum1);
            Console.WriteLine("您好，请输入第二个数字！");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("您好，请输入运算符");
            string op = Console.ReadLine();

            float result = 0;
            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }
            if (op == "+" || op == "-" || op == "*" || op == "/")
            {
                Console.WriteLine("您输入的结果为" + result);
            }
            else
            {
                Console.WriteLine("您的输入有误");
            }
        }
    }
}