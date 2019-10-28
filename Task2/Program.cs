using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{   
    class Person
    {
        private string name;
        private int age;
        public Person()
        {
            name = "No name";
            age = 1;
        }
        public Person(int age)
        {
            this.age = age;
            name = "No name";
        }
        public Person(string name , int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
