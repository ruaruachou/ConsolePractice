namespace ClassPractice
{
    class Wife
    {
        //数据成员
        private string name;
        private string sex;
        private int age;

        //方法成员
        private void SetName(string name)
        {
            this.name = name;
        }
        private void SetAge(int age)
        {
            this.age = age;
        }
        public string GetName()
        {
            return name; 
        }
        public int GetAge()
        {
            return age;
        }
        static void Main()
        {
            Wife beautyfulWife;
            beautyfulWife = new Wife();//实例化wife对象
            beautyfulWife.SetName("新垣结衣");
            beautyfulWife.SetAge(34);

            Console.WriteLine(beautyfulWife.GetName());
            Console.WriteLine(beautyfulWife.GetAge());
        }
    }
}