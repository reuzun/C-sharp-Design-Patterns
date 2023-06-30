using System;
using DesignPatterns.StructuralPatterns.Bridge.Materials;

namespace DesignPatterns.StructuralPatterns.Bridge.Weapons
{
	public class Weapon : IWeapon
	{
		IMaterial material;
		int baseAttack = 10;

		public Weapon(IMaterial material)
		{
			this.material = material;
		}

		public void Attack()
		{
			Console.WriteLine("Attack is: " + baseAttack * material.getAttackMultiplier());
		}
	}
}

