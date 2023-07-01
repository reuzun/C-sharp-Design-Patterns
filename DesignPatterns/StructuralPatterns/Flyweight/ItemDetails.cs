using System;
namespace DesignPatterns.StructuralPatterns.FlyWeight
{
	public class ItemDetails
	{
		public string NamePrefix { get; set; }
		public string Color { get; set; }
		public double BoostMultiplier { get; set; }

		public ItemDetails(string namePrefix, string color, double boostMultiplier)
		{
			NamePrefix = namePrefix;
			Color = color;
			BoostMultiplier = boostMultiplier;
		}

	}
}

