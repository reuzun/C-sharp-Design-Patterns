using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
	public interface ItemFactory
	{
        IWeapon CreateWeapon();
        IShield CreateShield();
	}
}

