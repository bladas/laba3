using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }

    class Family
    {
        public List<Person> People = new List<Person>();

        public void  AddMember(Person member)
        {
            Console.WriteLine("Input the member name and age");
          member.Name = Console.ReadLine();
          member.Age = Convert.ToInt32(Console.ReadLine());
            People.Add(member);
        }

        public Person GetOldestMember()
        {

            int temp = 0;
            var person = new Person();
            foreach (var member in People)
            {
                if( temp < member.Age)
                {
                    temp = member.Age;
                }
            }
            foreach (var member in People)
            {
                if (member.Age == temp)
                {
                    person = member;
                    break;
                }
            }
               
                
            return person;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var N = Convert.ToInt32(Console.ReadLine());
            Family family = new Family();
              Person person = new Person();
            
            do
            {
              
               family.AddMember(person);
                 N--;
            }
            while (N > 0);

           
            Console.WriteLine($" Name = {family.GetOldestMember().Name} Age = {family.GetOldestMember().Age}");

            Console.ReadKey();



        }
    }
}
