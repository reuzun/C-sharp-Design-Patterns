using System;
using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using Program;

namespace DesignPatterns.CreationalPatterns
{
	public static class CreationalPatternsProgram
	{
		public static void RunCreationalPatterns(this Runner runner)
		{
			LogInterceptor.Intercept(new Action[] {
                FactoryMethodRunner.Run,
                AbstractFactoryRunner.Run
            });
		}
	}
}

