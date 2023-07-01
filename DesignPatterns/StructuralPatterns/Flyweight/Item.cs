using System;
namespace DesignPatterns.StructuralPatterns.FlyWeight
{
	public class Item
	{
		string Name { get; set; }
		ItemDetails Details { get; set; }

		public Item(string name, ItemDetails details)
		{
			this.Name = name;
			this.Details = details;
		}
	}
}

