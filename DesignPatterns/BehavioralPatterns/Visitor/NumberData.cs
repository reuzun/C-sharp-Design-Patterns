using System;
namespace DesignPatterns.BehavioralPatterns.Visitor
{
	public class NumberData : IData
	{
		public NumberData()
		{
		}

		public void Accept(IDataVisitor visitor)
		{
			visitor.VisitNumberData(this);
		}
	}
}

