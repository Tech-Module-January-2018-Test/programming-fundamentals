// Confirmed by SVVelev
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC_01.Debit_Card_Number
{
	class Program
	{
		static void Main(string[] args)
		{
            // Here we read the numbers from the Console.
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());
			int fourthNumber = int.Parse(Console.ReadLine());
            // Here we print the numbers in the required format.
			Console.WriteLine($"{firstNumber:D4} {secondNumber:D4} {thirdNumber:D4} {fourthNumber:D4}");
		}
	}
}
