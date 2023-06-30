using System;
namespace DesignPatterns.StructuralPatterns.Bridge.Materials
{
	public class GoldMaterial : IMaterial
	{
		public GoldMaterial()
		{
		}

		public float getAttackMultiplier()
		{
			return 1.5f;
		}

		public float getDefenceMultiplier()
		{
			return 1.4f;
		}
	}
}

