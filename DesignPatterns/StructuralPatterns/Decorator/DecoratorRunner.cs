using System;
namespace DesignPatterns.StructuralPatterns.Decorator
{
	public class DecoratorRunner
	{
		public DecoratorRunner()
		{
		}

		[Logger("Decorator")]
		public static void Run()
		{
			IWeapon weapon = new Weapon();
			IWeapon goldenWeapon = new GoldenWeaponDecorator(weapon);

			Console.WriteLine($"Weapon Attack: {weapon.AttackValue()}");
			Console.WriteLine($"GoldenWeapon Attack: {goldenWeapon.AttackValue()}");
		}
	}
}

