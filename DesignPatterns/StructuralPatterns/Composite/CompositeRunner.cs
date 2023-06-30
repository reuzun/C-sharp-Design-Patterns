using System;
namespace DesignPatterns.StructuralPatterns.Composite
{
	public class CompositeRunner
	{
		public CompositeRunner()
		{
		}

		[Logger("Composite")]
		public static void Run()
		{
			IResource wood = new LeafResource("Wood");
			IResource stone = new LeafResource("Stone");
			ICraftableResource arrow = new Resource("Arrow");
			arrow.AddRequiredResource(wood, 3);
			arrow.AddRequiredResource(stone, 2);
			ICraftableResource bow = new Resource("WoodBow");
			bow.AddRequiredResource(wood, 5);
			ICraftableResource stoneBow = new Resource("StoneBow");
			stoneBow.AddRequiredResource(bow, 1);
			stoneBow.AddRequiredResource(arrow, 3);
			stoneBow.AddRequiredResource(stone, 10);

			stoneBow.Print(0);
		}
	}
}

