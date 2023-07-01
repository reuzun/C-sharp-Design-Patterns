using System;
namespace DesignPatterns.StructuralPatterns.Proxy
{
	public class ComplexCalculatorProxy : IComplexCalculator
	{
		IComplexCalculator calculator;
		IDictionary<DoubleDoubleData, double> cache;

		public ComplexCalculatorProxy(IComplexCalculator complexCalculator)
		{
			calculator = complexCalculator;
			this.cache = new Dictionary<DoubleDoubleData, double>();
		}

		public double CalculateComplex(double num1, double num2)
		{
			DoubleDoubleData ddData = new(num1, num2);
			this.cache.TryGetValue(ddData, out double result);
			if (result != 0)
			{
				return result;
			}
			result = calculator.CalculateComplex(num1, num2);
			this.cache.Add(ddData, result);
			return result;
		}
	}
}

