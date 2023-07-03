using System;
namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
	public class ConcreteTemplate2Method : BaseTemplateMethod
	{
		public ConcreteTemplate2Method()
		{
		}

		public override void Step2()
		{
			Console.WriteLine("Concrete 2 Private Step2 is worked!");
		}
	}
}

