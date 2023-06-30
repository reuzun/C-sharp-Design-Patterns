using System;
using DesignPatterns.CreationalPatterns.FactoryMethod.Factories;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
	public class FactoryMethodRunner
	{
		[Logger("FactoryMethod")]
		public static void Run()
		{
			BaseCalculatorFactory additionFactory = new AdditionCalculatorFactory();

			Console.WriteLine("3 + 5 = " + additionFactory.DoCalculation(3, 5));
		}
	}
}

