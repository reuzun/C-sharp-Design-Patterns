using System;
namespace DesignPatterns.StructuralPatterns.Adapter.Library
{
	public class AdditionOperation : IOperation
	{
		public AdditionOperation()
		{
		}

		public double DoOperation(double num1, double num2)
		{
			return num1 + num2;
		}
	}
}

