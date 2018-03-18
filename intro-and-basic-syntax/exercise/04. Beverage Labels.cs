using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here we read the variables from the Console.
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            // Here we calculate the calories and sugar.
            double kcals = volume * energy / 100.0;
            double sugars = volume * sugar / 100.0;
            // Here we print the result.
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcals}kcal, {sugars}g sugars");


        }
    }
}
