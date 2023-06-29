using System;
namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
	public class MultiplicationCalculator : BaseCalculator
	{
        public MultiplicationCalculator(string name, int version) : base(name, version)
        {
            Console.WriteLine("Multiplication Calculator is created!");
        }

        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}

