using System;
namespace DesignPatterns.BehavioralPatterns.State
{
	public class StateRunner
	{
		public StateRunner()
		{
		}

		[Logger("State")]
		public static void Run()
		{
			VideoPlayer player = new VideoPlayer();

			player.PlayButtonClickedEvent();
			player.PlayButtonClickedEvent();
			player.PlayButtonClickedEvent();
			player.PlayButtonClickedEvent();
		}
	}
}

