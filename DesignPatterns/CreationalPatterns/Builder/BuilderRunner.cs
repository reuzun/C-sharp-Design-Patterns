using System;
namespace DesignPatterns.CreationalPatterns.Builder
{
	public class BuilderRunner
	{
		public BuilderRunner()
		{
		}

		[Logger("Builder Running Started", "Builder Running End")]
		public static void Run()
		{
			PizzaBuilder pizzaBuilder = new PizzaBuilder();
			Pizza pizzaWithGarlic = pizzaBuilder
				.SetRadius(20)
				.AddGarlic()
				.Build();

			Pizza pizzaWithTomatoAndCheddar = pizzaBuilder
				.SetRadius(20)
				.AddTomato()
				.AddCheddar()
				.Build();

			Console.WriteLine($"Pizza with garlic {pizzaWithGarlic.containsGarlic}");
			Console.WriteLine($"Pizza with cheddar and tomato {pizzaWithTomatoAndCheddar.containsCheddar} && {pizzaWithTomatoAndCheddar.containsTomato}");
		}
	}
}