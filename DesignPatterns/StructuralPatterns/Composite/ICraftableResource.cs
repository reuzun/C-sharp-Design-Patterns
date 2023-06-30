using System;
namespace DesignPatterns.StructuralPatterns.Composite
{
	public interface ICraftableResource : IResource
	{
		void AddRequiredResource(IResource resource, int count);
	}
}

