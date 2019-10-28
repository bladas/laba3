using System;
namespace _8
{
    public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public Tire []tire=new Tire[4];
        
            public Car(string model,int speed, int power, int weight, string type,int t1_age,int t2_age,int t3_age,int t4_age, double t1_pressure, double t2_pressure, double t3_pressure, double t4_pressure)
        {
            this.model = model;
            engine = new Engine(speed, power);
            cargo = new Cargo(weight, type);
            tire[0] = new Tire(t1_age, t1_pressure);
            tire[1] = new Tire(t2_age, t2_pressure);
            tire[2] = new Tire(t3_age, t3_pressure);
            tire[3] = new Tire(t4_age, t4_pressure);
        }
        
    }

    public class Engine
    {
        public int speed;
        public int power;
        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }
    }
    public class Cargo
    {
        public int weight;
        public string type;
        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }
    }
    public class Tire
    {
        public int age;
        public double pressure;
        public Tire(int age,double pressure)
        {
            this.age = age;
            this.pressure = pressure;
        }
    }

    class Program
    {
        public static void noDots(ref string a)
        {
            int n = a.Length;
            char[] b = new char[n];
            for (int i = 0; i < n; i++)
            {
                if (a[i] == '.')
                    b[i] = ',';
                else
                    b[i] = a[i];
            }
            a = "";
            for (int i = 0; i < n; i++)
                a += b[i];            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of cars: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Print information about a car in the format “<Model> <EngineSpeed> <EnginePower>" +
                " <CargoWeight><CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure>" +
                " <Tire3Age><Tire4Pressure> <Tire4Age>");
            Car[] a = new Car[n];
            for(int i=0;i<n;i++)
            { 
            string start = Console.ReadLine();
                noDots(ref start);
            string[] starto = start.Split(" ");
                string model = starto[0];
                int speed = Int32.Parse(starto[1]);
                int power= Int32.Parse(starto[2]);
                int weight= Int32.Parse(starto[3]);
                string type=starto[4];
                double p1 = Convert.ToDouble(starto[5]);
                double p2 = Convert.ToDouble(starto[7]);
                double p3 = Convert.ToDouble(starto[9]);
                double p4 = Convert.ToDouble(starto[11]);
                int a1 = Convert.ToInt32(starto[6]);
                int a2 = Convert.ToInt32(starto[8]);
                int a3 = Convert.ToInt32(starto[10]);
                int a4 = Convert.ToInt32(starto[12]);
                a[i] = new Car(model,speed,power,weight,type,a1,a2,a3,a4,p1,p2,p3,p4);
                
            }
            Console.WriteLine("Print command(\"fragile\" or \"flamable\")");
            string c = Console.ReadLine();
            switch (c)  
            { 
            case "fragile":
                
                for(int i=0;i<n;i++)
                    {if(a[i].cargo.type == "fragile") { 
                        bool bad_tire = false;
                        for(int j = 0; j < 4; j++)
                        {
                            if(a[i].tire[j].pressure<1)
                            {
                                bad_tire = true;
                                break;
                            }
                        }
                        if (bad_tire)
                        Console.WriteLine(a[i].model);
                        }
                    }
                break;
            case "flamable":
                    for(int i=0;i<n;i++)
                    {
                        if(a[i].cargo.type=="flamable"&&a[i].engine.power>250)                        
                            Console.WriteLine(a[i].model);                        
                    }
                break;
                default:
                    Console.WriteLine("Неверная команда!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
