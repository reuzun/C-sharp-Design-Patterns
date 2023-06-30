using System;
namespace DesignPatterns.CreationalPatterns.Singleton
{
	public class LazyInitiliazeSingleton
	{
		private static readonly LazyInitiliazeSingleton instance = new LazyInitiliazeSingleton();

		// Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
		static LazyInitiliazeSingleton() { }

		public LazyInitiliazeSingleton()
		{
		}

		public static LazyInitiliazeSingleton GetInstance()
		{
			return instance;
		}
	}
}

