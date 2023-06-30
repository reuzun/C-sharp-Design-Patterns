using System;
namespace DesignPatterns.StructuralPatterns.Adapter
{
	public class MyMultiplication : IMyOperation
	{
		public MyMultiplication()
		{
		}

		public double Operate(double num1, double num2)
		{
			return num1 * num2;
		}
	}
}

