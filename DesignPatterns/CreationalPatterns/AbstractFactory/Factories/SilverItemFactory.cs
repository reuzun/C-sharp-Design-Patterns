using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
	public class SilverItemFactory : ItemFactory
	{
		public SilverItemFactory()
		{
		}

		public IShield CreateShield()
		{
			return new SilverShield();
		}

		public IWeapon CreateWeapon()
		{
			return new SilverWeapon();
		}
	}
}

