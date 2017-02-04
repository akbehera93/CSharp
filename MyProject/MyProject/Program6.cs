/*In a company, worker efficiency is determined on the basis of the time required for a worker to complete a specific job.
If the time taken by the worker is between 2 - 3 hours, then the worker is said to be highly efficient.
If the time required by the worker is 3 - 4 hours, then the worker is ordered to increase their speed.
If the time taken is 4 - 5 hours then the worker is given training to improve his speed and if the time taken by
the worker is more than 5 hours then the worker must leave the company. If the time taken by the worker is input
through the keyboard then find the efficiency of the worker.*/
using System;
namespace MyProject
{
    class Program6
    {
        static void Main()
        {
            Console.Write("Enter the working hours of a Worker of your company:");
            int hours;
            hours = int.Parse(Console.ReadLine());
            if (hours >= 2 && hours <= 3)
                Console.WriteLine("Your worker is highly efficient");
            else if (hours > 3 && hours <= 4)
                Console.Write("Your worker should increase his/her working speed");
            else if (hours > 4 && hours <= 5)
                Console.WriteLine("Your worker should be trained to improve his/her speed");
            else if (hours > 5)
                Console.WriteLine("Your worker should leave the company");
            else
                Console.WriteLine("INVALID INPUT");
            Console.ReadLine();
        }
    }
}
