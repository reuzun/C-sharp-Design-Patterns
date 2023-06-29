﻿using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.FactoryMethod;

namespace DesignPatterns.CreationalPatterns
{
	public static class CreationalPatternsProgram
	{
		public static void RunCreationalPatterns(this Runner runner)
		{
			LogInterceptor.Intercept(new Action[] {
				FactoryMethodRunner.Run,
				AbstractFactoryRunner.Run,
				BuilderRunner.Run
			});
		}
	}
}

