using System;

namespace task1
{
    class Person
    {
        private string name;
        private int age;
        public void Name()
        {
            Console.WriteLine($"name : {name}");   
        }   
        public void Age()
        {

            Console.WriteLine($"age : {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Pesho = new Person();
            Pesho.name = "Pesho";
            Pesho.age = 20;
            Pesho.Name();
            Pesho.Age();
            Console.ReadKey();
        }
    }
}
