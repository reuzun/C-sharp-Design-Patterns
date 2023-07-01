using System;
namespace DesignPatterns.BehavioralPatterns.CoR
{
	public interface IHero
	{
		void SetNextHero(IHero hero);
		void Kill(Monster monster);
	}
}

