using System;
namespace DesignPatterns
{
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	public class LoggerAttribute : Attribute
	{

		private string message;

		public LoggerAttribute(string message)
		{
			this.message = message;
		}

		public void PrintBeforeMessage()
		{
			Console.WriteLine("---" + message + " is Running---\n");
		}

		public void PrintAfterMessage()
		{
			Console.WriteLine();
			Console.WriteLine("---" + message + " is Finished---\n");
		}
	}
}

