using System;
namespace DesignPatterns.BehavioralPatterns.Mediator
{
	public class MediatorRunner
	{
		public MediatorRunner()
		{
		}

		[Logger("Mediator")]
		public static void Run()
		{
			Person p1 = new("Person1");
			Person p2 = new("Person2");
			ChatRoom chatRoom = new();

			// Alternatively, chatRoom.RegisterPerson();
			chatRoom.AddPerson(p1);
			chatRoom.AddPerson(p2);

			Console.WriteLine("Person1 Writes: Hello");
			p1.SendMessage("Hello");
			Console.WriteLine();

			Console.WriteLine("Person2 Writes: Hello, too.");
			p2.SendMessage("Hello, too.");
			Console.WriteLine();

			Console.WriteLine("Chatroom sends notification!");
			chatRoom.Publish("ChatRoom Notification");
		}
	}
}

