using System;
namespace DesignPatterns.StructuralPatterns.Decorator
{
	public class Weapon : IWeapon
	{
		public Weapon()
		{
		}

		public double AttackValue()
		{
			return 10;
		}
	}
}

