using System;
namespace DesignPatterns.BehavioralPatterns.State
{
	public class PlayingVideoPlayerState : BaseVideoPlayerState
	{
		public PlayingVideoPlayerState(VideoPlayer player) : base(player)
		{
		}

		public override void ClickPlayBtn()
		{
			Console.WriteLine("Video is Pausing...");
			this.player.state = new PausedVideoPlayerState(this.player);
		}
	}
}

