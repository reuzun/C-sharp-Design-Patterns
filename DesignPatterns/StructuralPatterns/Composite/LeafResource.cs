using System;
namespace DesignPatterns.StructuralPatterns.Composite
{
	public class LeafResource : IResource
	{
		public string Name { get; }

		public LeafResource(string name)
		{
			this.Name = name;
		}

		public void Print(int depth, int count)
		{
			Console.WriteLine(new string('-', depth) + Name);
		}
	}
}

