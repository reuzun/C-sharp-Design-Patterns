using System;
namespace DesignPatterns.StructuralPatterns.Composite
{
	public interface IResource
	{
		string Name { get; }
		void Print(int depth, int count = 1);
	}
}

