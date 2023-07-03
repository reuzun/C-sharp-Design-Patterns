using System;
namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
	public class TemplateMethodRunner
	{
		public TemplateMethodRunner()
		{
		}

		[Logger("Template Method")]
		public static void Run()
		{
			BaseTemplateMethod concrete1TemplateMethod = new Concrete1TemplateMethod();
			BaseTemplateMethod concrete2TemplateMethod = new Concrete1TemplateMethod();

			concrete1TemplateMethod.DoClassJob();
			concrete2TemplateMethod.DoClassJob();
		}
	}
}

