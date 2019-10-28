using System;
using System.Collections;
using System.Collections.Generic;
namespace _14
{
    public class Cat
    {
        public string name;
    }
    public class Siamese : Cat
    {
        int earSize;
        public Siamese(string name,int earSize) {
            this.name = name;
            this.earSize = earSize;
        }
        public Siamese()
        {

        }
        public void Info()
        {
            Console.WriteLine($"{this.GetType().Name} {name} {earSize}");
        }
    }
    public class Cymric : Cat
    {
        public float furLength;
        public Cymric(string name,float furLength)
        {
            this.name = name;
            this.furLength = furLength;
        }
        public Cymric()
        {

        }
        public void Info()
        {
            Console.WriteLine($"{this.GetType().Name} {name} {furLength.ToString("0.00")}");
        }
    }
    public class StreetExtraordinaire : Cat
    {
        public int decibelsOfMeows;
        public StreetExtraordinaire(string name,int decibelsOfMeows)
        {
            this.name = name;
            this.decibelsOfMeows = decibelsOfMeows;
        }
        public StreetExtraordinaire() { }

        public void Info()
        {
            Console.WriteLine($"{this.GetType().Name} {name} {decibelsOfMeows}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Cat> a = new List<Cat>();
            while(true)
            {
                string s1 = Console.ReadLine();
                string[] s2 = s1.Split(" ");
                if (s2[0] == "End" && s2.Length == 1)
                    break;
                else if(s2.Length==3&&double.Parse(s2[2])>=0)
                {
                    bool unique = true;
                    for(int i = 0; i < a.Count; i++)
                    {
                        if (a[i].name == s2[1])
                            unique = false;
                    }
                    if (unique)
                    {
                    if (s2[0] == "Siamese")
                    {
                            Cat t = new Cat();
                            t = new Siamese(s2[1],Int32.Parse(s2[2]));
                            a.Add(t);
                    }
                    else if (s2[0] == "Cymric")
                    {
                        Cat t = new Cat();
                        t = new Cymric(s2[1], float.Parse(s2[2]));
                        a.Add(t);
                    }
                    else if (s2[0] == "StreetExtraordinaire")
                    {
                        Cat t = new Cat();
                        t = new StreetExtraordinaire(s2[1],Int32.Parse(s2[2]));
                        a.Add(t);
                    }
                    }
                    else {
                        Console.WriteLine("Name is not unique!");
                        continue;
                            }
                }
                else
                {
                    Console.WriteLine("Wrong command!");
                    continue;
                }                                  
            }
            while (true)
            {
                string s3=Console.ReadLine();
                if (s3 == "End")
                    break;
                for (int i = 0; i < a.Count; i++)
                    if (s3 == a[i].name)
                    {
                        string tip = a[i].GetType().Name;
                        if(tip=="Siamese")
                        {
                            Siamese t = new Siamese();
                            t = (Siamese)a[i];
                            t.Info();
                        }
                        if (tip == "Cymric")
                        {
                            Cymric t = new Cymric();
                            t = (Cymric)a[i];
                            t.Info();
                        }
                        if (tip == "StreetExtraordinaire")
                        {
                            StreetExtraordinaire t = new StreetExtraordinaire();
                            t = (StreetExtraordinaire)a[i];
                            t.Info();
                        }
                    }
            }
            Console.ReadKey();
        }
    }
}
