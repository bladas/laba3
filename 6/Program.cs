using System;

namespace _6
{
    class Employee
    {
        public string name; //
        public double salary; //
        public string position;//
        public string department;//
        public string email;
        public int age;
        public void show()
        {
            Console.WriteLine($"{this.name} {this.salary.ToString("0.00")} {this.position} {this.department} {this.email} {this.age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество работников: ");
            int n=Int32.Parse( Console.ReadLine());
            Employee[] a = new Employee[n];
            for (int i = 0; i < n; i++)
                a[i] = new Employee();
            for(int i=0;i<n;i++)
            {
                
                Console.Write($"Введите имя {i+1}-го работника: ");
                s1:
                string t = Console.ReadLine();
                if (t == "")
                { 
                    Console.WriteLine("Ошибка! Поле обязательное!");
                    goto s1;
                }
                else
                    a[i].name = t;

                Console.Write($"Введите зарплату {i + 1}-го работника: ");
                s2:
                t = Console.ReadLine();
                if (t == "")
                {
                    Console.WriteLine("Ошибка! Поле обязательное!");
                    goto s2;
                }
                else
                    a[i].salary = Math.Round(Convert.ToDouble(t),2);   //Math.Round((Double)d, 2);
                Console.Write($"Введите должность {i + 1}-го работника: ");
                s3:
                t = Console.ReadLine();
                if (t == "")
                {
                    Console.WriteLine("Ошибка! Поле обязательное!");
                    goto s3;
                }
                else
                    a[i].position = t;
                Console.Write($"Введите департамент {i + 1}-го работника: ");
            s4:
                t = Console.ReadLine();
                if (t == "")
                {
                    Console.WriteLine("Ошибка! Поле обязательное!");
                    goto s4;
                }
                else
                    a[i].department = t;
                Console.Write($"Введите эл.почту {i + 1}-го работника: ");
                t= Console.ReadLine(); ;
                if (t == "")
                    a[i].email = "n/a";
                else
                    a[i].email = t;
                Console.Write($"Введите возраст {i + 1}-го работника: ");
                t = Console.ReadLine();
                if (t == "")
                    a[i].age = -1;
                else
                    a[i].age = Convert.ToInt32(t);
            }
            //for(int i=0;i<n;i++)    //
            //{                       //
                //a[i].show();        //
            //}                       //

            string[] deps = new string[n];
            int k = 0;
            for(int i=0;i<n;i++)
            {
                bool good = true;
                for (int j = 0; j < k; j++)
                    if (a[i].department == deps[j])
                        good = false;
                if(good)
                { 
                deps[k] = a[i].department;
                k++;
                }
            }
            double[] deps_sum = new double[k];
            for (int i = 0; i < k; i++)
                deps_sum[i] = 0;


            for(int j=0;j<k;j++)
                for(int i=0;i<n;i++)
                {
                    if (deps[j] == a[i].department)
                        deps_sum[j] += a[i].salary;
                }
            //for (int i = 0; i < k; i++)
                //Console.WriteLine($"{deps[i]} {deps_sum[i]}");
            string best_dep = deps[0];
            double best_salary = deps_sum[0];
            for(int i=0;i<k;i++)
            {
                if(deps_sum[i] > best_salary)
                {
                    best_salary = deps_sum[i];
                    best_dep = deps[i];
                }
            }
            Console.Clear();
            Console.WriteLine($"Найбольшая средняя зарплата: {best_dep}");
            for(int i=0;i<n;i++)
                for(int j=i+1;j<n;j++)
                {
                    if(a[i].salary<a[j].salary)
                    {
                        Employee t = a[j];
                        a[j] = a[i];
                        a[i] = t;
                    }
                }

            for(int i=0;i<n;i++)
            {
                if (a[i].department == best_dep)
                    a[i].show();
            }
            Console.ReadKey();


        }
    }
}
