using System;
namespace DesignPatterns.CreationalPatterns.Singleton
{
	public class SingletonRunner
	{
		public SingletonRunner()
		{
		}

		[Logger("Singleton")]		
		public static void Run()
		{
			NonThreadSafeSingleton nonThreadSafeSingleton
				= NonThreadSafeSingleton.GetInstance();

			OneLockThreadSafetySingleton oneLockThreadSafetySingleton
				= OneLockThreadSafetySingleton.GetInstance();

			DoubleCheckLockThreadSafetySingleton doubleCheckLockThreadSafetySingleton
				= DoubleCheckLockThreadSafetySingleton.GetInstance();

			LazyInitiliazeSingleton lazyInitiliazeSingleton
				= LazyInitiliazeSingleton.GetInstance();

			Console.WriteLine(nonThreadSafeSingleton == NonThreadSafeSingleton.GetInstance());
			Console.WriteLine(oneLockThreadSafetySingleton == OneLockThreadSafetySingleton.GetInstance());
			Console.WriteLine(doubleCheckLockThreadSafetySingleton == DoubleCheckLockThreadSafetySingleton.GetInstance());
			Console.WriteLine(lazyInitiliazeSingleton == LazyInitiliazeSingleton.GetInstance());
		}
	}
}

