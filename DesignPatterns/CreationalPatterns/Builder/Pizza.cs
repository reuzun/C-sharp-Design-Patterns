using System;
namespace DesignPatterns.CreationalPatterns.Builder
{
	public class Pizza
	{
		public int radius { get; set; }
		public bool containsGarlic { get; set; } = false;
		public bool containsTomato { get; set; } = false;
		public bool containsCheddar { get; set; } = false;
		public float price { get; set; }

		public Pizza()
		{
		}
	}
}

