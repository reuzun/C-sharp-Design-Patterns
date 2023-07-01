using System;
namespace DesignPatterns.StructuralPatterns.Proxy
{
	public class ComplexCalculator : IComplexCalculator
	{
		public ComplexCalculator()
		{
		}

		public double CalculateComplex(double num1, double num2)
		{
			Console.WriteLine("Calculating...");
			Thread.Sleep(2500);
			return num1 + num2;
		}
	}
}

