using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here we read number from the Console 
            double miles = double.Parse(Console.ReadLine());

            // Here we make calculations.
            double km = miles * 1.60934;
            
            // Here we print the result in required format.
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
