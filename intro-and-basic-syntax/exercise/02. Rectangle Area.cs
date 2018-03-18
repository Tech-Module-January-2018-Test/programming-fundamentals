using System;

namespace Problem_02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
			// Here we parse the variables to double
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;

			// Here we print the result
            Console.WriteLine("{0:0.00}", area);
        }
    }
}
