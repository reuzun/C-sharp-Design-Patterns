using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
	public class GoldWeapon : IWeapon
	{
		public GoldWeapon()
		{
		}

        public void Attack()
        {
			Console.WriteLine("GoldWeapon: Attack");
        }
    }
}

