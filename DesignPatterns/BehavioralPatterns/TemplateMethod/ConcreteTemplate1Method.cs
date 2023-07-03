using System;
namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
	public class Concrete1TemplateMethod : BaseTemplateMethod
	{
		public Concrete1TemplateMethod()
		{
		}

		public override void Step2()
		{
			Console.WriteLine("Concrete 1 Private Step2 is worked!");
		}
	}
}

