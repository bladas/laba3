using System;

namespace _10
{
    class Car
    {
        public string model;
        public Engine engine;
        public string weight;//
        public string color;//
        public void info()
        {
            Console.Write($"{model}:\n");
            engine.info();
            Console.Write($"  Weight: {weight}\n  Color: {color}\n");
        }
    }
    class Engine
    {
        public string model;
        public string power;
        public string displacement;//
        public string efficiency;//
        public void info()
        {
            Console.Write($"  {model}:\n    Power: {power}\n" +
                $"    Displacement: {displacement}\n" +
                $"    Efficiency: {efficiency}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number of engines: ");
            int n =Int32.Parse(Console.ReadLine());
            Engine[] a = new Engine[n];
            for(int i=0;i<n;i++)
            {
                
                a[i] = new Engine();
                string t;
                Console.Write($"Input model of {i + 1}. engine: ");
            e1:
                t = Console.ReadLine();
                if (t == "")
                {
                    Console.WriteLine("Error. Field is obligatory.");
                    goto e1;
                }
                else
                    a[i].model = t;
                Console.Write($"Input power of {i + 1}. engine: ");
            e2:
                t = Console.ReadLine();
                if (t == "")
                {
                    Console.WriteLine("Error. Field is obligatory.");
                    goto e2;
                }
                else
                    a[i].power = t;
                Console.Write($"Input displacement of {i + 1}. engine: ");
                t = Console.ReadLine();
                if (t == "")
                    a[i].displacement = "n/a";
                else
                    a[i].displacement = t;
                Console.Write($"Input efficiency of {i + 1}. engine: ");
                t = Console.ReadLine();
                if (t == "")
                    a[i].efficiency = "n/a";
                else
                    a[i].efficiency = t;
            }
            Console.Write("Input a number of cars: ");
            int m =Int32.Parse( Console.ReadLine());
            Car[] b = new Car[m];
            for(int i=0;i<m;i++)
            {
                b[i] = new Car();
                string t;
                Console.Write($"Input model of {i + 1}. car: ");
                e1:
                t = Console.ReadLine();
                if (t == "")
                {
                    Console.WriteLine("Error. Field is obligatory.");
                    goto e1;
                }
                else
                    b[i].model = t;
                Console.Write($"Input engine of {i + 1}. car: ");
                e2:
                t = Console.ReadLine();
                if (t == "")
                {
                    Console.WriteLine("Error. Field is obligatory.");
                    goto e2;
                }
                else
                {
                    bool exists = false;
                    for (int j = 0; j < n; j++)
                    { 
                        if (a[j].model == t)
                        { 
                            exists = true;
                            b[i].engine = a[j];
                            break;
                        }
                    }
                    if(!exists)
                    {
                        Console.WriteLine("Error.Model don't exist.");
                            goto e2;
                    }
                }
                Console.Write($"Input weight of {i + 1}. car: ");
                t = Console.ReadLine();
                if (t == "")
                    b[i].weight = "n/a";
                else
                    b[i].weight = t;
                Console.Write($"Input color of {i + 1}. car: ");
                t = Console.ReadLine();
                if (t == "")
                    b[i].color = "n/a";
                else
                    b[i].color = t;
            }
            Console.Clear();
            for (int i = 0; i < m; i++)
                b[i].info();
            Console.ReadKey();
        }
    }
}
