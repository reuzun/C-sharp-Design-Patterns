using System;
namespace DesignPatterns.BehavioralPatterns.Mediator
{
	public abstract class BasePerson
	{
		string Username { get; set; }
		ChatRoom room;

		public BasePerson(string username)
		{
			this.Username = username;
		}

		public void SetChatRoom(ChatRoom room)
		{
			this.room = room;
		}

		public void GetMessage(string message)
		{
			Console.WriteLine($"{Username} Got Message: {message}");
		}

		public void SendMessage(string message)
		{
			this.room.Publish(message);
		}
	}
}

