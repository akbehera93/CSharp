//program that takes coordinates (x, y) of a center of a circle and its radius from the user, the program will determine whether a point lies inside the circle, on the circle or outside the circle.
using System;
namespace MyProject
{
    class Program3
    {
        static void Main()
        {
            //equation of a circle is (x-a)^2+(y-b)^2=r^2
            int x, y, a, b;
            int radius;
            Console.WriteLine("Enter the x coordinate of the point");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate of the point");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the radius of the circle");
            radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the centroid");
            Console.WriteLine("Enter the a coordinate of the centroid");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the b coordinate of the centroid");
            b = int.Parse(Console.ReadLine());
            if ((((x - a) * (x - a)) + ((y - b) * (y - b))) == (radius * radius))
                Console.WriteLine("The point ("+x+","+y+") lies on the circle");
            else if ((((x - a) * (x - a)) + ((y - b) * (y - b))) > (radius * radius))
                Console.WriteLine("The point (" + x + "," + y + ") lies outside the circle");
            else if ((((x - a) * (x - a)) + ((y - b) * (y - b))) < (radius * radius))
                Console.WriteLine("The point (" + x + "," + y + ") lies inside the circle");
            else
                Console.WriteLine("An error occured due to some invalid input or calculation");
            Console.ReadLine();
        }
    }
}
