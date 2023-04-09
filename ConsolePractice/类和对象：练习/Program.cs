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
        }
    }
}