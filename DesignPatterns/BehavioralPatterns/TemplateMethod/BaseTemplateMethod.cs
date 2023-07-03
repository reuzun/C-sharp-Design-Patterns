using System;
namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
	public abstract class BaseTemplateMethod
	{
		public BaseTemplateMethod()
		{
		}

		public void Step1()
		{
			Console.WriteLine("Common Step 1 is worked!");
		}

		public abstract void Step2();

		public void Step3()
		{
			Console.WriteLine("Common Step 3 is worked!");
		}

		public void DoClassJob()
		{
			Step1();
			Step2();
			Step3();
		}
	}
}

