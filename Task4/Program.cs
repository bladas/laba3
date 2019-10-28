using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{   
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person()
        {

        }

    }


    class Program
    {
        
        static void Main(string[] args)
        {
            var N = Convert.ToInt32(Console.ReadLine());                     
            List<Person> people = new List<Person>();
            List<Person> sortedPeoplebyAge = new List<Person>();

            do
            {
             int Age = Convert.ToInt32(Console.ReadLine());
             string  Name = Console.ReadLine();
               people.Add(new Person { age = Age , name = Name });
               N--;
            }
            while (N > 0);

            foreach (var picha in people)
            {
                if (picha.age >= 30)
                {
                    sortedPeoplebyAge.Add(picha);
                }
            }

            var sortedPeopleByAlfavite = from p in sortedPeoplebyAge orderby p.name select p;

            foreach (var p in sortedPeopleByAlfavite)
            {
                Console.WriteLine($"{p.name} {p.age}");
            }

            Console.ReadKey();


        }
    }
}
