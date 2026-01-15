using System;
namespace ConsoleApp19_1
{
    class Program
    {
        public static void Main()
        {
            TestPerson person = new TestInfo("山田", 20, 170, 60);
        }
    }
    class TestPerson
    {
        string name;
        int age;
        public TestPerson(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("基底クラス");
            Console.WriteLine("名前:" + name + ",年齢" + age);
        }
    }
    class TestInfo : TestPerson
    {
        int height;
        int weight;
        public TestInfo(string name, int age, int height, int weight) : base(name, age)
        {
            this.height = height;
            this.weight = weight;
            Console.WriteLine("派生クラス");
            Console.WriteLine("身長:" + height + ",体重" + weight);
        }
    }
}