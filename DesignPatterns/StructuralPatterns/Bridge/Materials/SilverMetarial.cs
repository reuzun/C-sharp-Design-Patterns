using System;
namespace DesignPatterns.StructuralPatterns.Bridge.Materials
{
	public class SilverMetarial : IMaterial
	{
		public SilverMetarial()
		{
		}

		public float getAttackMultiplier()
		{
			return 1.2f;
		}

		public float getDefenceMultiplier()
		{
			return 1.15f;
		}
	}
}

