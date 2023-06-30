using System;
using DesignPatterns.StructuralPatterns.Bridge.Materials;
using DesignPatterns.StructuralPatterns.Bridge.Shields;
using DesignPatterns.StructuralPatterns.Bridge.Weapons;

namespace DesignPatterns.StructuralPatterns.Bridge.Factories
{
	public class GoldItemFactory : ItemFactory
	{
		public GoldItemFactory()
		{
		}

		public IShield CreateShield()
		{
			return new Shield(new GoldMaterial());
		}

		public IWeapon CreateWeapon()
		{
			return new Weapon(new GoldMaterial());
		}
	}
}

