using System;
namespace DesignPatterns.StructuralPatterns.Proxy
{
	public class ProxyRunner
	{
		public ProxyRunner()
		{
		}

		[Logger("Proxy")]
		public static void Run()
		{
			IComplexCalculator calculator = new ComplexCalculator();
			IComplexCalculator proxyCalculator = new ComplexCalculatorProxy(calculator);

			proxyCalculator.CalculateComplex(1, 5);
			proxyCalculator.CalculateComplex(2, 5);
			proxyCalculator.CalculateComplex(1, 5);
		}
	}
}

