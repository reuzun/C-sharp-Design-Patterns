using System;
using DesignPatterns.StructuralPatterns.Adapter.Library;

namespace DesignPatterns.StructuralPatterns.Adapter
{
	public class AdapterRunner
	{
		public AdapterRunner()
		{
		}

		[Logger("Adapter")]
		public static void Run()
		{
			Calculator calculator = new();
			IOperation addition = new AdditionOperation();

			Console.WriteLine(calculator.Calculate(5, 5, addition));
			

			MyMultiplication multiplication = new();

			// I have multiplication operator but the interface
			// does not match with the libraries interface so
			// we should use an adapter.

			LibraryOperationAdapter adapter = new LibraryOperationAdapter(multiplication);
			Console.WriteLine(calculator.Calculate(5, 5, adapter));
			
		}
	}
}

