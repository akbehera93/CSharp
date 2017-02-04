//prove a line is straight is not
using System;
namespace MyProject
{
    class Program2
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, y1, y2, y3;
            int slope1, slope2, slope3;
            Console.WriteLine("Enter x and y coordinates of the first point");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x and y coordinates of the second point");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x and y coordinates of the third point");
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());
            slope1 = (y2 - y1) / (x2 - x1);
            slope2 = (y3 - y1) / (x3 - x1);
            slope3 = (y3 - y2) / (x3 - x2);
            if(slope1==slope2 && slope1==slope3)
            {
                Console.WriteLine("All the points fall on one straight line");
            }
            else
            {
                Console.WriteLine("All the points do not lie on one straight line");
            }
            Console.ReadKey();
        }
    }
}
