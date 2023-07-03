using System;
namespace DesignPatterns.BehavioralPatterns.Memento
{
	public class TelevisionState
	{

		public int CurrentChannelNo { get; set; } = 1;
		public int Volume { get; set; } = 10;

		public TelevisionState(int currentChannelNo, int volume)
		{
			CurrentChannelNo = currentChannelNo;
			Volume = volume;
		}
	}
}

