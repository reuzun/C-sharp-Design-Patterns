using System;
namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
	public class FactoryMethodRunner
	{
		[Logger("FactoryMethod Running Started", "FactoryMethod Running End")]
		public static void Run()
		{
			BaseCalculator additionCalculator =
				new AdditionCalculator("AdditionCalculator", 1);
			BaseCalculator multiplicationCalculator =
				new MultiplicationCalculator("MultiplicationCalculator", 2);

            additionCalculator.Print();
            multiplicationCalculator.Print();
        }
    }
}

