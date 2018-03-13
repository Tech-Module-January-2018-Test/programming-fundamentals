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

			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());
			int fourthNumber = int.Parse(Console.ReadLine());

			Console.WriteLine($"{firstNum:D4} {secondNum:D4} {thirdNum:D4} {fourthNum:D4}");
		}
	}
}
