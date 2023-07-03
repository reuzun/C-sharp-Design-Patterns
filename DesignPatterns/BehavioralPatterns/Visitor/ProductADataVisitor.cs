using System;
namespace DesignPatterns.BehavioralPatterns.Visitor
{
	public class ProductADataVisitor : IDataVisitor
	{
		public ProductADataVisitor()
		{
		}

		public void VisitNumberData(NumberData data)
		{
			Console.WriteLine("Product A - Number Report: " + data);
		}

		public void VisitStringData(StringData data)
		{
			Console.WriteLine("Product A - String Report: " + data);
		}
	}
}

