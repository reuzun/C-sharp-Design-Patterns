using System;
using DesignPatterns.StructuralPatterns.FlyWeight;

namespace DesignPatterns.StructuralPatterns.Flyweight
{
	public class FlyweightRunner
	{
		public FlyweightRunner()
		{
		}

		[Logger("Flyweight")]
		public static void Run() {
			Random rnd = new Random();
			ItemDetailsFlyweightFactory factory = new ItemDetailsFlyweightFactory();
			Func<ItemDetails> greenify = () => factory.GetFlightWeightItemDetails("G", "Green", 1.1);
			Func<ItemDetails> bluefy = () =>factory.GetFlightWeightItemDetails("B", "Blue", 1.2);
			for (int i = 0; i < 100_000; i++)
			{
				ItemDetails details = rnd.NextDouble() > 0.5 ? greenify() : bluefy();
				Item item = new Item("Random_String", details);
				User u = new User(item);
			}
			Console.WriteLine("Cache used instead of distinct creation: " + ItemDetailsFlyweightFactory.CacheRetrieveCount);
		}
	}
}

