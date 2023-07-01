using System;
namespace DesignPatterns.BehavioralPatterns.CoR
{
	public class Hero : BaseHero
	{
		public Hero(int attackValue) : base(attackValue)
		{
		}

		public override void Kill(Monster monster)
		{
			if (this.AttackValue > monster.Health)
			{
				Console.WriteLine("I've killed the monster!");
			}
			else if (this.NextHero != null)
			{
				Console.WriteLine("I can't kill it. Delegating to a stronger hero.");
				this.NextHero.Kill(monster);
			}
			else
			{
				Console.WriteLine("No way to kill such a strong monster!");
			}
		}
	}
}

