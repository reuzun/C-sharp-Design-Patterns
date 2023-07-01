using System;
namespace DesignPatterns.BehavioralPatterns.Command
{
	public class StockService
	{
		public StockService()
		{
		}

		public void BuyStock(string stockName, int count) {

			Console.WriteLine("Stock Service is running command.");

			Console.WriteLine($"{stockName} x{count} has bought sucessfully.");

			Console.WriteLine("Stock Service has finished the command.");

		}
	}
}

