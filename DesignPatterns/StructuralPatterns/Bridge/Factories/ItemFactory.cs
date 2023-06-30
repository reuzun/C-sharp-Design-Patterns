using System;
using DesignPatterns.StructuralPatterns.Bridge.Shields;
using DesignPatterns.StructuralPatterns.Bridge.Weapons;

namespace DesignPatterns.StructuralPatterns.Bridge.Factories
{
	public interface ItemFactory
	{
		IWeapon CreateWeapon();
		IShield CreateShield();
	}
}

