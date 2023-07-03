using System;
namespace DesignPatterns.BehavioralPatterns.State
{
	public class PausedVideoPlayerState : BaseVideoPlayerState
	{
		public PausedVideoPlayerState(VideoPlayer player) : base(player)
		{
		}

		public override void ClickPlayBtn()
		{
			Console.WriteLine("Video is playing...");
			this.player.state = new PlayingVideoPlayerState(this.player);
		}
	}
}

