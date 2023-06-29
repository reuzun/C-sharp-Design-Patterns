using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
	public class GoldItemFactory : ItemFactory
	{
		public GoldItemFactory()
		{
		}

        public IShield CreateShield()
        {
            return new GoldShield();
        }

        public IWeapon CreateWeapon()
        {
            return new GoldWeapon();
        }
    }
}

