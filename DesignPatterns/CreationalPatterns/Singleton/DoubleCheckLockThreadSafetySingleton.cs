using System;
namespace DesignPatterns.CreationalPatterns.Singleton
{
	/**
	 * This class converts lock checking to null checking which is cheaper.
	 */
	public class DoubleCheckLockThreadSafetySingleton
	{

		private static DoubleCheckLockThreadSafetySingleton instance;
		private static readonly object singletonLock = new object();

		private DoubleCheckLockThreadSafetySingleton() { }


		public static DoubleCheckLockThreadSafetySingleton GetInstance()
		{
			if(instance == null)
			{
				lock (singletonLock)
				{
					if(instance == null)
					{
						instance = new DoubleCheckLockThreadSafetySingleton();
					}
				}
			}
			return instance;
		}
	}
}

