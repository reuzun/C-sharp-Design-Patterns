using System;
using DesignPatterns.CreationalPatterns.FactoryMethod.Products;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Factories
{
	public abstract class BaseCalculatorFactory
	{

		public abstract ICalculator GetCalculator();

		public double DoCalculation(double num1, double num2)
		{
			var calculator = this.GetCalculator();
			return calculator.Calculate(num1, num2);
		}

	}
}

