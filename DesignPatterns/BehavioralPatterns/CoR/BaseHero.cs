using System;
namespace DesignPatterns.BehavioralPatterns.CoR
{
	public abstract class BaseHero : IHero
	{
		protected IHero? NextHero { get; set; } = null;
		protected int AttackValue { get; set; }

		protected BaseHero(int attackValue)
		{
			AttackValue = attackValue;
		}

		public virtual void Kill(Monster monster)
		{
			if(NextHero != null)
			{
				NextHero.Kill(monster);
			}
		}

		public void SetNextHero(IHero hero)
		{
			this.NextHero = hero;
		}
	}
}

