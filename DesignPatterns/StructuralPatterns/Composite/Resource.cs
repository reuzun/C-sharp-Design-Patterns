namespace DesignPatterns.StructuralPatterns.Composite
{
	public class Resource : ICraftableResource
	{
		public string Name { get; }
		private Dictionary<IResource, int> requiredResources = new Dictionary<IResource, int>();

		public Resource(string name)
		{
			this.Name = name;
		}

		public void AddRequiredResource(IResource component, int count)
		{
			if (requiredResources.ContainsKey(component))
			{
				requiredResources[component] += count;
			}
			else
			{
				requiredResources[component] = count;
			}
		}

		public void Print(int depth, int count)
		{
			Console.WriteLine(new string('-', depth) + Name + $" x{count}");

			foreach (KeyValuePair<IResource, int> requiredResource in requiredResources)
			{
				if (requiredResource.Key is Resource)
				{
					requiredResource.Key.Print(depth + 2, requiredResource.Value);
				}
				else
				{
					Console.WriteLine(new string('-', depth + 2) + requiredResource.Key.Name + " x" + requiredResource.Value);
				}
			}
		}
	}
}

