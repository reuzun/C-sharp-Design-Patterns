using System;
namespace DesignPatterns.BehavioralPatterns.CoR
{
	public class StrongHero : Hero
	{
		public StrongHero(int attackValue) : base(attackValue * 2)
		{
			Console.WriteLine("IM STRONG HERO. I can kill any monster!");
		}

		public override void Kill(Monster monster)
		{
			Console.WriteLine("Strong Attackkk... The Monster is DEAD!");
		}
	}
}

