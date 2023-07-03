using System;
namespace DesignPatterns.BehavioralPatterns.State
{
	public class VideoPlayer
	{
		public BaseVideoPlayerState state;

		public VideoPlayer()
		{
			this.state = new PlayingVideoPlayerState(this);
		}

		public void PlayButtonClickedEvent()
		{
			this.state.ClickPlayBtn();
		}
	}
}

