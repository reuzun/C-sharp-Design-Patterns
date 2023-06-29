using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
	public class GoldShield : IShield
	{
		public GoldShield()
		{
		}

		public void Defence()
		{
			Console.WriteLine("GoldShield: Defence");
		}
	}
}

