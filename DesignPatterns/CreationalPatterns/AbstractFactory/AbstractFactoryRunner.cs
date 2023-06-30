using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
	public class AbstractFactoryRunner
	{
		public AbstractFactoryRunner()
		{
		}

		[Logger("AbstractFactory")]
		public static void Run()
		{
			ItemFactory silverFactory = new SilverItemFactory();
			IWeapon silverWeapon = silverFactory.CreateWeapon();
			IShield silverShield = silverFactory.CreateShield();

			silverWeapon.Attack();
			silverShield.Defence();

			ItemFactory goldFactory = new GoldItemFactory();
			IWeapon goldWeapon = goldFactory.CreateWeapon();
			IShield goldShield = goldFactory.CreateShield();

			goldWeapon.Attack();
			goldShield.Defence();
		}
	}
}

