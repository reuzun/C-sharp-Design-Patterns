using System;
namespace DesignPatterns.BehavioralPatterns.Command
{
	public class StockBuyCommand : ICommand
	{
		StockService stockService;
		string stockName;
		int count;

		public StockBuyCommand(StockService stockService, string stockName, int count)
		{
			this.stockService = stockService;
			this.stockName = stockName;
			this.count = count;
		}

		public void Execute()
		{
			this.stockService.BuyStock(stockName, count);
		}
	}
}

