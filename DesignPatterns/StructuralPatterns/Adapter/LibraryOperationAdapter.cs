using System;
using DesignPatterns.StructuralPatterns.Adapter.Library;

namespace DesignPatterns.StructuralPatterns.Adapter
{
	public class LibraryOperationAdapter : IOperation
	{

		IMyOperation myOperator;

		public LibraryOperationAdapter(IMyOperation myOperator)
		{
			this.myOperator = myOperator;
		}

		public double DoOperation(double num1, double num2)
		{
			return myOperator.Operate(num1, num2);
		}
	}
}

