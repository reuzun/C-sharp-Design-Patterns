using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
	public class SilverWeapon : IWeapon
	{
		public SilverWeapon()
		{
		}

		public void Attack()
		{
			Console.WriteLine("SilverWeapon: Attack");
		}
	}
}

