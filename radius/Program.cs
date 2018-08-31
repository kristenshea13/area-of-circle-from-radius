using System;

namespace radius
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Write a program that prompts the user for a number representing the radius, 
            //and then calculates the area of a circle with that radius and prints the result.
            //Extend your program further by using a while or do -while loop, so that when the 
            //user enters a negative number they are re-prompted.

            Console.WriteLine("Calculate the area of a circle.");
            Console.Write("Please enter the radius: ");
            int radius = int.Parse(Console.ReadLine());

            do
            {
                
                Console.Write("Invalid entry. \n Enter radius: ");
                
                radius = int.Parse(Console.ReadLine());
            }
            while (radius < 0);
           

            Console.WriteLine($"Area of circle: {CircleArea(radius)}");

            Console.ReadLine();

        }


        private static double CircleArea(int radius)
        {

            double radiusSqu = Math.Pow(radius, 2);
            return radiusSqu * Math.PI;

        }


    }
}
