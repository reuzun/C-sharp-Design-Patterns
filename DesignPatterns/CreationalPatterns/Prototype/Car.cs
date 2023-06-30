using System;
namespace DesignPatterns.CreationalPatterns.Prototype
{
	public class Car
	{
		public string model { get; set; }
		public string year { get; set; }

		public Car()
		{
		}

		public Car(string model, string year)
		{
			this.model = model;
			this.year = year;
		}
	}
}

