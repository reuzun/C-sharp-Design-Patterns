using System;
namespace DesignPatterns.CreationalPatterns.Singleton
{

	/**
	* Checking lock for each GetInstance is an expensive operation.
	* That is why double lock occurs.
	*/
	public class OneLockThreadSafetySingleton
	{

		private static OneLockThreadSafetySingleton instance;
		private static readonly object singletonLock = new object();


		private OneLockThreadSafetySingleton()
		{
		}

		public static OneLockThreadSafetySingleton GetInstance()
		{
			lock (singletonLock)
			{
				if (instance == null)
				{
					instance = new OneLockThreadSafetySingleton();
				}
				return instance;
			}
		}
	}
}

