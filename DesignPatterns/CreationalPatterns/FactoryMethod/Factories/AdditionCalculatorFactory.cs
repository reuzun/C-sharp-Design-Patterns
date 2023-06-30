using System;
using DesignPatterns.CreationalPatterns.FactoryMethod.Products;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Factories
{
	public class AdditionCalculatorFactory : BaseCalculatorFactory
	{
		public AdditionCalculatorFactory()
		{
		}

		public override ICalculator GetCalculator()
		{
			return new AdditionCalculator();
		}
	}
}

