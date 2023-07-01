using System;
namespace DesignPatterns.StructuralPatterns.Decorator
{
	public class GoldenWeaponDecorator : IWeapon
	{
		IWeapon weapon;

		public GoldenWeaponDecorator(IWeapon weapon)
		{
			this.weapon = weapon;
		}

		public double AttackValue()
		{
			return this.weapon.AttackValue() * 1.2;
		}
	}
}

