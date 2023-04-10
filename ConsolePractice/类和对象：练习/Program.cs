namespace ClassPractice
{
    class Wife
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        private string sex;
        private int age;
        public int Age
        {
            get
            { return age; }
            set
            {
                if (value >= 0 && value <= 40)
                    this.age = value;
                else throw new Exception("年龄不符");
            }
        }
        public Wife(string name,int age)
        {
            this.Age = age;
            this.Name = name;   
        }
        public Wife(string name)
        {
            this.Name = name;
        }
        public Wife()
        {

        }
        static void Main()
        {
            Wife w01 = new Wife();
            w01.Name = "长泽雅美";
            w01.Age = 30;

            Wife w02 = new Wife("新垣结衣", 35);
            Wife w03 = new Wife("石原里美", 30);
            Wife w04 = new Wife("桥本环奈", 25);
            Wife[]wifeArray = new Wife[4];
            wifeArray[0] = w01;
            wifeArray[1] = w02;
            wifeArray[2] = w03;
            wifeArray[3] = w04;

            Wife youngest = GetWifeByMinAge(wifeArray);

        }
        private static Wife GetWifeByMinAge(Wife[]wives)
        {
            Wife youngestWife = wives[0];
            for (int i = 1; i < wives.Length; i++)
            {
                if (youngestWife.Age > wives[i].Age)
                {
                    youngestWife = wives[i];
                }
            }
            return youngestWife;
        }
    }
}