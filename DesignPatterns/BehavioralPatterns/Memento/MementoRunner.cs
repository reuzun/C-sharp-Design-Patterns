using System;
namespace DesignPatterns.BehavioralPatterns.Memento
{
	public class MementoRunner
	{
		public MementoRunner()
		{
		}

		[Logger("Memento")]
		public static void Run()
		{
			Television tv = new Television(); // Volume: 10

			tv.IncreaseVolume(); // Volume: 20
			tv.IncreaseVolume(); // Volume: 30
			tv.IncreaseVolume(); // Volume: 40

			Console.WriteLine(tv.GetVolume()); // 40

			tv.ReDo();
			Console.WriteLine(tv.GetVolume()); // 30

			tv.ReDo();
			Console.WriteLine(tv.GetVolume()); // 20

		}
	}
}

