using System;
namespace DesignPatterns.CreationalPatterns.FactoryMethod.Products
{
	public class AdditionCalculator : ICalculator
	{
		public AdditionCalculator()
		{
		}

		public double Calculate(double num1, double num2)
		{
			return num1 + num2;
		}
	}
}

