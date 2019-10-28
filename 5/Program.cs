using System;

namespace _5
{
    static public class DateModifier
    {
        static public double Difference(string a,string b)
        {
            int[] a1 = new int[3];
            int[] b1 = new int[3];
            string[] pre_a = a.Split(" ");
            string[] pre_b = b.Split(" ");
            for(int i=0;i<3;i++)
            {
                a1[i] =Int32.Parse( pre_a[i]);
                b1[i] =Int32.Parse( pre_b[i]);
            }
            DateTime x = new DateTime(a1[0], a1[1], a1[2]);
            DateTime y = new DateTime(b1[0], b1[1], b1[2]);
            if((y - x).TotalDays>=0)
            return (y - x).TotalDays;
            else
                return (x - y).TotalDays;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Формат записи: Год Месяц День");
            Console.Write("Введите первую дату: ");
            string a = Console.ReadLine();
            Console.Write("Введите вторую дату: ");
            string b = Console.ReadLine();
            Console.Write("Разница между датами в днях: ");
            Console.Write(DateModifier.Difference(a, b));
        }
    }
}
