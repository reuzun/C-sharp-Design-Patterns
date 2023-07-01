using System;
using System.Collections;

namespace DesignPatterns.StructuralPatterns.FlyWeight
{
	public class ItemDetailsFlyweightFactory
	{
		IDictionary<string, ItemDetails> dictionary = new Dictionary<string, ItemDetails>();
		public static int CacheRetrieveCount = 0;

		public ItemDetailsFlyweightFactory()
		{
		}

		public ItemDetails GetFlightWeightItemDetails(string prefix, string color, double multiplier)
		{
			dictionary.TryGetValue(prefix, out ItemDetails details);
			if (details != null)
			{
				CacheRetrieveCount++;
				return dictionary[prefix];
			}
			details = new ItemDetails(prefix, color, multiplier);
			dictionary.Add(prefix, details);
			return details;
		}
	}
}

