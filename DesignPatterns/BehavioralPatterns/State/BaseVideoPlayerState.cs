using System;
namespace DesignPatterns.BehavioralPatterns.State
{
	public abstract class BaseVideoPlayerState
	{
		protected VideoPlayer player;

		public BaseVideoPlayerState(VideoPlayer player)
		{
			this.player = player;
		}

		public abstract void ClickPlayBtn();
	}
}

