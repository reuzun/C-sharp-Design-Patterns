using System;
using DesignPatterns.StructuralPatterns.Bridge.Factories;
using DesignPatterns.StructuralPatterns.Bridge.Shields;
using DesignPatterns.StructuralPatterns.Bridge.Weapons;

namespace DesignPatterns.StructuralPatterns.Bridge
{
	public class BridgeRunner
	{
		public BridgeRunner()
		{
		}

		[Logger("Bridge")]
		public static void Run() {
			SilverItemFactory silverFactory = new SilverItemFactory();

			IWeapon silverWeapon = silverFactory.CreateWeapon();
			IShield silverShield = silverFactory.CreateShield();

			GoldItemFactory goldFactory = new GoldItemFactory();

			IWeapon goldWeapon = goldFactory.CreateWeapon();
			IShield goldShield = goldFactory.CreateShield();

			silverWeapon.Attack();
			silverShield.Defence();

			goldWeapon.Attack();
			goldShield.Defence();

		}

	}
}

