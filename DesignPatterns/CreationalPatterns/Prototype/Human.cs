using System;
namespace DesignPatterns.CreationalPatterns.Prototype
{
	public class Human : ICloneable
	{
		public string name { get; set; }
		public List<Car> cars;

		public Human(string name)
		{
			this.name = name;
			this.cars = new();
		}

		public Human(string name, List<Car> cars)
		{
			this.name = name;
			this.cars = cars;
		}

		public object Clone()
		{
			Human clone = new Human(name);
			List<Car> cars = new();
			foreach (Car car in this.cars)
			{
				Car carClone = new Car(car.model, car.year);
				cars.Add(carClone);
			}
			clone.cars = cars;
			return clone;
		}
	}
}

