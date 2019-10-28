using System;

namespace _15
{
    static class DrawingTool
    {
        static public class Square
        {
            static public void Draw(int n)
            {
                for(int i=0;i<n;i++)
                {
                    for(int j=0;j<n;j++)
                    {
                        if (j == 0)
                            Console.Write("|");
                        if (i == 0 || i == n - 1)
                            Console.Write("-");
                        else
                            Console.Write(" ");

                        if (j == n - 1)
                            Console.Write("|");
                    }
                    Console.Write("\n");
                }
            }
        }
        public static class Rectangle
        {
            static public void Draw(int width,int height)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j == 0)
                            Console.Write("|");
                        if (i == 0 || i == height - 1)
                            Console.Write("-");
                        else
                            Console.Write(" ");

                        if (j == width - 1)
                            Console.Write("|");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s == "Square")
            {
                int n = Convert.ToInt32(Console.ReadLine());
                DrawingTool.Square.Draw(n);
            }
            if (s == "Rectangle")
            {
                int width = Convert.ToInt32(Console.ReadLine());
                int height = Convert.ToInt32(Console.ReadLine());
                DrawingTool.Rectangle.Draw(width, height);
            }
            Console.ReadKey();
        }
    }
}
