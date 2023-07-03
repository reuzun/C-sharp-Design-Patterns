using System;
namespace DesignPatterns.BehavioralPatterns.Visitor
{
	public interface IData
	{
		void Accept(IDataVisitor visitor);
	}
}

