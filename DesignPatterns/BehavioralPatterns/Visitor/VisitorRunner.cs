using System;
namespace DesignPatterns.BehavioralPatterns.Visitor
{
	public class VisitorRunner
	{
		public VisitorRunner()
		{
		}

		[Logger("Visitor")]
		public static void Run()
		{
			IData stringData = new StringData();
			IData numberData = new NumberData();

			IDataVisitor productAVisitor = new ProductADataVisitor();
			IDataVisitor productBVisitor = new ProductBDataVisitor();

			numberData.Accept(productAVisitor);
			stringData.Accept(productAVisitor);
			numberData.Accept(productBVisitor);
			stringData.Accept(productBVisitor);

		}
	}
}

