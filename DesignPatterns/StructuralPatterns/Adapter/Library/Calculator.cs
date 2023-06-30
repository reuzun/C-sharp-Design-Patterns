using System;
namespace DesignPatterns.StructuralPatterns.Adapter.Library
{
	public class Calculator
	{
		public Calculator()
		{
		}

		public double Calculate(double num1, double num2, IOperation operation)
		{
			return operation.DoOperation(num1, num2);
		}
	}
}

