using System;
using System.Collections;
using System.Collections.Generic;

namespace _13
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public List<Person> Parents;
        public List<Person> Children;
        public string birthDate;
        public Person()
        {
            Parents = new List<Person>();
            Children = new List<Person>();
            birthDate = "";
            FirstName = "";
            LastName = "";
        }
        public void getInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {birthDate}");
            Console.WriteLine($"Parents:");
            for (int i = 0; i < Parents.Count; i++)
                Console.WriteLine($"{Parents[i].FirstName} {Parents[i].LastName} {Parents[i].birthDate}");
            Console.WriteLine($"Children:");
            for(int i=0;i<Children.Count;i++)
                Console.WriteLine($"{Children[i].FirstName} {Children[i].LastName} {Children[i].birthDate}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List < Person >a = new List<Person>();
            Person t = new Person();
            bool q = false;
            while(!q)
            { 
            string s1 = Console.ReadLine();
            string[] s2 = s1.Split(" ");
            switch (s2.Length)
            {
                    case 1:
                        t.birthDate = s2[0];
                        q = true;
                        break;                        
                    case 2:
                        q = true;
                        t.FirstName = s2[0];
                        t.LastName = s2[1];
                        break;
                    default:
                        Console.WriteLine("Wrong first command!");
                        continue;
            }
            }
            a.Add(t);
            

            while (true)
            {
                string s1 = Console.ReadLine();
                if (s1 == "End")
                    break;
                string[] s2 = s1.Split(" ");
                switch (s2.Length)
                {
                    case 5:// FirstName LastName - FirstName LastName
                        {
                            bool found1 = false;
                            bool found2 = false;
                            for (int i = 0; i < a.Count; i++)
                            {
                                if (a[i].FirstName == s2[0] && a[i].LastName == s2[1])
                                {
                                    found1 = true;
                                    break;
                                }
                            }
                            for (int i = 0; i < a.Count; i++)
                            {
                                if (a[i].FirstName == s2[3] && a[i].LastName == s2[4])
                                {
                                    found2 = true;
                                    break;
                                }
                            }
                            if (!found1)
                            {
                                Person t1 = new Person();
                                t1.FirstName = s2[0];
                                t1.LastName = s2[1];
                                a.Add(t1);
                            }
                            if (!found2)
                            {
                                Person t1 = new Person();
                                t1.FirstName = s2[3];
                                t1.LastName = s2[4];
                                a.Add(t1);
                            }
                            for (int i = 0; i < a.Count; i++)
                            {
                                if (a[i].FirstName == s2[0] && a[i].LastName == s2[1])
                                    for (int j = 0; j < a.Count; j++)
                                        if (a[j].FirstName == s2[3] && a[j].LastName == s2[4])
                                        {
                                            a[i].Children.Add(a[j]);
                                            a[j].Parents.Add(a[i]);
                                        }
                            }
                        }
                        break;
                    case 4:
                        if(s2[2]=="-")// FirstName LastName - day/month/year
                        {
                            bool found1 = false;
                            for(int i=0;i<a.Count;i++)
                            {
                                if (a[i].FirstName == s2[0] && a[i].LastName == s2[1])
                                {
                                    found1 = true;
                                    break;
                                }                                    
                            }
                            bool found2 = false;
                            for(int i=0;i<a.Count;i++)
                            {
                                if (a[i].birthDate == s2[3])
                                { 
                                    found2 = true;
                                    break;
                                }
                            }
                            if(!found1)
                            {
                                Person t1 = new Person();
                                t1.FirstName = s2[0];
                                t1.LastName = s2[1];
                                a.Add(t1);
                            }
                            if (!found2)
                            {
                                Person t1 = new Person();
                                t1.birthDate = s2[3];
                                a.Add(t1);
                            }
                            for(int i=0;i<a.Count;i++)
                                if (a[i].FirstName == s2[0] && a[i].LastName == s2[1])
                                    for(int j=0;j<a.Count;j++)             
                                        if(a[j].birthDate==s2[3])
                                        {
                                            a[i].Children.Add(a[j]);
                                            a[j].Parents.Add(a[i]);
                                        }

                        }
                        if(s2[1]=="-")// day/month/year - FirstName LastName
                        {
                            bool found1 = false;
                            for(int i=0;i<a.Count;i++)
                            {
                                if (a[i].birthDate == s2[0])
                                {
                                    found1 = true;
                                    break;
                                }
                            }
                            bool found2 = false;
                            for(int i=0;i<a.Count;i++)
                            {
                                if (a[i].FirstName == s2[2] && a[i].LastName==s2[3])
                                {
                                    found2 = true;
                                    break;
                                }
                            }
                            if(!found1)
                            {
                                Person t1 = new Person();
                                t1.birthDate = s2[0];
                                a.Add(t1);
                            }
                            if (!found2)
                            {
                                Person t1 = new Person();
                                t1.FirstName = s2[2];
                                t1.LastName = s2[3];
                                a.Add(t1);
                            }
                            for(int i=0;i<a.Count;i++)
                                if (a[i].birthDate == s2[0])
                                    for(int j=0;j<a.Count;j++)
                                        if (a[j].FirstName == s2[2] && a[j].LastName == s2[3])
                                        {
                                            a[i].Children.Add(a[j]);
                                            a[j].Parents.Add(a[i]);
                                        }

                        }
                        break;
                    case 3:
                        if(s2[1]=="-")// day/month/year - day/month/year
                        {
                            bool found1 = false;
                            bool found2 = false;
                            for(int i=0;i<a.Count;i++)
                            { 
                                if(a[i].birthDate==s2[0])
                                {
                                    found1 = true;
                                }
                                if(a[i].birthDate==s2[2])
                                {
                                    found2 = true;
                                }
                            }
                            if(!found1)
                            {
                                Person t1 = new Person();
                                t1.birthDate = s2[0];
                                a.Add(t1);
                            }
                            if (!found2)
                            {
                                Person t1 = new Person();
                                t1.birthDate = s2[2];
                                a.Add(t1);
                            }
                            for(int i=0;i<a.Count;i++)
                                if(a[i].birthDate==s2[0])
                                    for(int j=0;j<a.Count;j++)
                                        if(a[j].birthDate==s2[2])
                                        {
                                            a[i].Children.Add(a[j]);
                                            a[j].Parents.Add(a[i]);
                                        }
                        }
                        else// FirstName LastName day/month/year
                        {
                            bool found_name = false;
                            bool found_date = false;
                            for(int i=0;i<a.Count;i++)
                            {
                                if (a[i].FirstName == s2[0] && a[i].LastName == s2[1])
                                    found_name = true;
                                if (a[i].birthDate == s2[2])
                                    found_date = true;
                            }
                            if(!found_name&&!found_date)
                            {
                                Person t1 = new Person();
                                t1.FirstName = s2[0];
                                t1.LastName = s2[1];
                                t1.birthDate = s2[2];
                                a.Add(t1);
                            }
                            if(found_name&&!found_date)
                            {
                                for (int i = 0; i < a.Count; i++)
                                    if (a[i].FirstName == s2[0] && a[i].LastName == s2[1])
                                        a[i].birthDate = s2[2]; 
                            }
                            if (!found_name && found_date)
                            {
                                for(int i=0;i<a.Count;i++)
                                    if (a[i].birthDate == s2[2])
                                    {
                                        a[i].FirstName = s2[0];
                                        a[i].LastName = s2[1];
                                    }
                            }
                            if(found_name&&found_date)
                            {
                                //bool done = false;
                                for(int i=0;i<a.Count;i++)
                                    if (a[i].FirstName == s2[0] && a[i].LastName == s2[1])
                                        for(int j=0;j<a.Count;j++)
                                            if (a[j].birthDate == s2[2]&&a[i]!=a[j])
                                            {
                                                if (a[j].Parents.Count != 0)
                                                {
                                                    for(int k=0;k<a[j].Parents.Count;k++)
                                                    { 
                                                    bool exists=false;//Присутсвует ли родитель j в i
                                                        for (int z = 0; z < a[i].Parents.Count; z++)
                                                            if (a[j].Parents[k] == a[i].Parents[z])
                                                                exists = true;
                                                        if (exists)
                                                            continue;
                                                        else
                                                            a[i].Parents.Add(a[j].Parents[k]);
                                                    }
                                                }
                                                if(a[j].Children.Count!=0)
                                                {
                                                    for(int k = 0; k < a[j].Parents.Count; k++)
                                                    {
                                                        bool exists = false;
                                                        for (int z = 0; z < a[i].Parents.Count; z++)
                                                            if (a[j].Children[k] == a[i].Children[z])
                                                                exists=true;
                                                        if (exists)
                                                            continue;
                                                        else
                                                            a[i].Children.Add(a[j].Children[k]);
                                                    }
                                                }
                                                for(int k=0;k<a.Count;k++)
                                                {
                                                    for (int z = 0; z < a[k].Children.Count; z++)
                                                        if (a[k].Children[z].birthDate == a[j].birthDate)
                                                            a[k].Children[z] = a[i];
                                                    for (int z = 0; z < a[k].Parents.Count; z++)
                                                        if (a[k].Parents[z].birthDate == a[j].birthDate)
                                                            a[k].Parents[z] = a[i];
                                                }
                                                a[i].birthDate = a[j].birthDate;
                                                a.RemoveAt(j);
                                                break;
                                            }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong first command!");
                        continue;

                }
                //for(int i=0;i<a.Count;i++) //Тестирование каждой команды
                //{
                    //Console.WriteLine("\n");
                    //a[i].getInfo();
                    //Console.WriteLine("\n");
                //}
               // Console.ReadKey();
               // Console.Clear();
            }
            for (int i = 0; i < a.Count; i++)
                if ((a[i].FirstName == t.FirstName && a[i].LastName == t.LastName) || t.birthDate == a[i].birthDate)
                    a[i].getInfo();

            Console.ReadKey();
        }
    }
}
