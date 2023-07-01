using System;
namespace DesignPatterns.BehavioralPatterns.Mediator
{
	public class ChatRoom
	{

		List<BasePerson> people;

		public ChatRoom()
		{
			people = new();
		}

		public void AddPerson(BasePerson person)
		{
			this.people.Add(person);
			person.SetChatRoom(this);
		}

		public void Publish(string message)
		{
			people.ForEach((BasePerson p) =>
			{
				p.GetMessage(message);
			});
		}
	}
}

