using System;
namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
	public class SilverShield : IShield
	{
		public SilverShield()
		{
		}

        public void Defence()
        {
			Console.WriteLine("SilverShield: Defence");
        }
    }
}

