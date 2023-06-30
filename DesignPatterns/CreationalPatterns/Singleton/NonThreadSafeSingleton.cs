using System;
namespace DesignPatterns.CreationalPatterns.Singleton
{
	public class NonThreadSafeSingleton
	{
		private static NonThreadSafeSingleton instance;

		NonThreadSafeSingleton()
		{
		}

		public static NonThreadSafeSingleton GetInstance()
		{
			if(instance == null)
			{
				instance = new NonThreadSafeSingleton();
			}
			return instance;
		}
	}
}

