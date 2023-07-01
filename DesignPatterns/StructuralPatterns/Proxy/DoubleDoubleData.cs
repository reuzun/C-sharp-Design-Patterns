using System;
namespace DesignPatterns.StructuralPatterns.Proxy
{
	public class DoubleDoubleData
	{
		double double1;
		double double2;

		public DoubleDoubleData(double double1, double double2)
		{
			this.double1 = double1;
			this.double2 = double2;
		}

		public override bool Equals(object? obj)
		{
			return obj is DoubleDoubleData data &&
				   double1 == data.double1 &&
				   double2 == data.double2;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(double1, double2);
		}
	}
}

