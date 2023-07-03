using System;
namespace DesignPatterns.BehavioralPatterns.Visitor
{
	public class ProductBDataVisitor : IDataVisitor
	{
		public ProductBDataVisitor()
		{
		}

		public void VisitNumberData(NumberData data)
		{
			Console.WriteLine("Product B - Number Report: " + data);
		}

		public void VisitStringData(StringData data)
		{
			Console.WriteLine("Product B - String Report: " + data);
		}
	}
}

