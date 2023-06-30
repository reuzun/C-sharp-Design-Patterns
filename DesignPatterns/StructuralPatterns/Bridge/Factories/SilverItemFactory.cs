using System;
using DesignPatterns.StructuralPatterns.Bridge.Materials;
using DesignPatterns.StructuralPatterns.Bridge.Shields;
using DesignPatterns.StructuralPatterns.Bridge.Weapons;

namespace DesignPatterns.StructuralPatterns.Bridge.Factories
{
	public class SilverItemFactory : ItemFactory
	{
		public SilverItemFactory()
		{
		}

		public IShield CreateShield()
		{
			return new Shield(new SilverMetarial());
		}

		public IWeapon CreateWeapon()
		{
			return new Weapon(new SilverMetarial());
		}
	}
}

