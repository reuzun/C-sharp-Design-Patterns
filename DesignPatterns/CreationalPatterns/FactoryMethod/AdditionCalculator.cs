using System;
namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
	public class AdditionCalculator : BaseCalculator
	{

		public AdditionCalculator(string name, int version) : base(name, version)
		{
			Console.WriteLine("Addition Calculator is created!");
		}

		public int Add(int number1, int number2)
		{
			return number1 + number2;
		}
	}
}

