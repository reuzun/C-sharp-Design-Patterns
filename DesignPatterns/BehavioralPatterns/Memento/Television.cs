using System;
namespace DesignPatterns.BehavioralPatterns.Memento
{
	public class Television
	{

		TelevisionState state;
		Stack<TelevisionState> oldStates;

		public Television()
		{
			state = new TelevisionState(1, 10);
			oldStates = new Stack<TelevisionState>();
		}

		public void ReDo()
		{
			this.state = oldStates.Pop();
		}


		public void IncreaseVolume()
		{
			this.oldStates.Push(new TelevisionState(this.state.CurrentChannelNo, this.state.Volume));
			this.state.Volume += 10;
		}

		public void NextChannel()
		{
			this.oldStates.Push(new TelevisionState(this.state.CurrentChannelNo, this.state.Volume));
			this.state.CurrentChannelNo += 1;
		}

		public int GetVolume()
		{
			return this.state.Volume;
		}
	}
}

