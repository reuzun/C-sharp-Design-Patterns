using System;
using System.Linq;

namespace DesignPatterns.BehavioralPatterns.Command
{
	public class CommandRunner
	{
		public CommandRunner()
		{
		}

		[Logger("Command")]
		public static void Run()
		{
			Queue<ICommand> commandQueue = new Queue<ICommand>();
			StockService stockService = new StockService();

			commandQueue.Enqueue(new LogCommand("New Log Command is working..."));
			commandQueue.Enqueue(new StockBuyCommand(stockService, "QUY1", 15));
			commandQueue.Enqueue(new StockBuyCommand(stockService, "QUY2", 16));
			commandQueue.Enqueue(new StockBuyCommand(stockService, "QUY3", 17));
			commandQueue.Enqueue(new LogCommand("Last Log Command is working..."));

			while(commandQueue.Count > 0)
			{
				commandQueue.Dequeue().Execute();
				Thread.Sleep(500);
			}
		}
	}
}

