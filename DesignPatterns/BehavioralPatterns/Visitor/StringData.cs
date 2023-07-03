using System;
namespace DesignPatterns.BehavioralPatterns.Visitor
{
	public class StringData : IData
	{
		public StringData()
		{
		}

		public void Accept(IDataVisitor visitor)
		{
			visitor.VisitStringData(this);
		}
	}
}

