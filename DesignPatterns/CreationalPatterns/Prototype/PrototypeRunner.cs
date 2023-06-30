using System;
namespace DesignPatterns.CreationalPatterns.Prototype
{
	public class PrototypeRunner
	{
		public PrototypeRunner()
		{
		}

		[Logger("Prototype Running Started", "Prototype Running End")]
		public static void Run()
		{
			Car c1 = new Car("A", "2000");
			Car c2 = new Car("B", "3000");
			Car c3 = new Car("C", "4000");

			List<Car> cars = new() { c1, c2, c3 };

			Human h1 = new Human("UserA", cars);
			Human clone = (Human)h1.Clone();

			Console.WriteLine("Main Objects car[0] model changed!");
			h1.cars[0].model = "Changed";

			Console.WriteLine(h1.cars[0].model);
			Console.WriteLine(clone.cars[0].model);

		}
	}
}

