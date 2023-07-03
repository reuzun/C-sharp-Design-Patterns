using System;
namespace DesignPatterns.BehavioralPatterns.Visitor
{
	public interface IDataVisitor
	{
		void VisitStringData(StringData data);
		void VisitNumberData(NumberData data);
	}
}

