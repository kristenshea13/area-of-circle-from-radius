using System;

namespace radius
{
    class Program
    {
        static void Main(string[] args)
        {
            

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
