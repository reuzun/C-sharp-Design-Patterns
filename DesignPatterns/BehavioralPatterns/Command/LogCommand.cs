using System;
namespace DesignPatterns.BehavioralPatterns.Command
{
	public class LogCommand : ICommand
	{
		string Log { get; set; }

		public LogCommand(string log)
		{
			Log = log;
		}

		public void Execute()
		{
			Console.WriteLine("Log Command: " + Log);
		}
	}
}

