using System;

namespace _9
{
    class Rectangle
    {
        public string id;
        public double width;
        public double height;
        public double x;
        public double y;
        double x1
        {
            get
            {
                return x + width;
            }
        }
        double y1
        {
            get
            {
                return y - height;
            }
        }
        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }
        public Rectangle()
        {

        }
        public bool Intersect(Rectangle b)
        {
            if ((this.y1 <= b.y && this.y1 >= b.y1) || (this.y >= b.y1 && this.y <= b.y) || (this.x1 >= b.x && this.x1 <= b.y1) || (this.x >= b.x && this.x <= b.x1))
                return true;
            else
                return false;                    
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of rectangles and number of intersection checks:");
            string s1 = Console.ReadLine();
            string[] s11 = s1.Split(" ");
            int n = Convert.ToInt32(s11[0]);
            int m = Convert.ToInt32(s11[1]);
            Rectangle[] a = new Rectangle[n];
            Console.WriteLine("Input info about rectangles: id, width, height and coordinates:");
            for(int i=0;i<n;i++)
            {
                string s2 = Console.ReadLine();
                string[] s22 = s2.Split(" ");
                a[i] = new Rectangle();
                a[i].id = s22[0];
                a[i].width =Convert.ToDouble(s22[1]);
                a[i].height = Convert.ToDouble(s22[2]);
                a[i].x = Convert.ToDouble(s22[3]);
                a[i].y = Convert.ToDouble(s22[4]);
            }
            Console.WriteLine("Input IDs of rectangles you'd like to check: ");
            for(int i = 0; i < m; i++)
            {
                string s3 = Console.ReadLine();
                string[] s33 = s3.Split(" ");
                bool good = false;
                for(int j=0;j<n;j++)
                {
                    if(a[j].id==s33[0]);
                    {
                        for(int z = 0; z < n; z++)
                        {
                            if (a[z].id == s33[1])
                            { 
                                Console.WriteLine(a[j].Intersect(a[z]));
                                good = true;
                            }
                            if (good)
                                break;
                        }
                       
                    }
                    if (good)
                        break;
             
                }
                if (!good)
                    Console.WriteLine("Invalid ID");
            }
            Console.ReadKey();
        }
    }
}
