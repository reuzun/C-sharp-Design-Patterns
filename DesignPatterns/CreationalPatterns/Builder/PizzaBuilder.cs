using System;
namespace DesignPatterns.CreationalPatterns.Builder
{
	public class PizzaBuilder
	{
		public Pizza pizza;

		public PizzaBuilder()
		{
			pizza = new Pizza();
		}

		public PizzaBuilder SetRadius(int radius)
		{
			pizza.radius = radius;
			return this;
		}

		public PizzaBuilder AddGarlic()
		{
			pizza.containsGarlic = true;
			return this;
		}

		public PizzaBuilder AddTomato()
		{
			pizza.containsTomato = true;
			return this;
		}

		public PizzaBuilder AddCheddar()
		{
			pizza.containsCheddar = true;
			return this;
		}

		public PizzaBuilder setPrice(float price)
		{
			pizza.price = price;
			return this;
		}

		public Pizza Build(bool reset = true)
		{
			var pizzaPtr = this.pizza;
			if (reset == true)
			{
				this.pizza = new Pizza();
			}
			return pizzaPtr;
		}
	}
}

