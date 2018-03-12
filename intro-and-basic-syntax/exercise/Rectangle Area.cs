using System;

namespace Problem_02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = width * height;

            Console.WriteLine("{0:0.00}", result);
        }
    }
}
