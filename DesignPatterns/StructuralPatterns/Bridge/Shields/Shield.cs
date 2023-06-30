using System;
using DesignPatterns.StructuralPatterns.Bridge.Materials;

namespace DesignPatterns.StructuralPatterns.Bridge.Shields
{
	public class Shield : IShield
	{ 

		IMaterial material;
		public int defence = 100;

		public Shield(IMaterial material)
		{
			this.material = material;
		}

		public void Defence()
		{
			Console.WriteLine("Defence is: " + this.defence * material.getDefenceMultiplier());
		}
	}
}

