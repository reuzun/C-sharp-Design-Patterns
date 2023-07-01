using System;
namespace DesignPatterns.BehavioralPatterns.CoR
{
	public class CoRRunner
	{
		public CoRRunner()
		{
		}

		[Logger("CoR")]
		public static void Run()
		{
			Monster monster = new(150);
			IHero weakHero = new Hero(75);
			IHero normalHero = new Hero(140);
			IHero strongHero = new StrongHero(100);

			weakHero.SetNextHero(normalHero);
			normalHero.SetNextHero(strongHero);

			weakHero.Kill(monster);
		}
	}
}

