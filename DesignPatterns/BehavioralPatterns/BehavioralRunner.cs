using System;
using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Bridge;
using DesignPatterns.StructuralPatterns.Composite;
using DesignPatterns.StructuralPatterns.Decorator;
using DesignPatterns.StructuralPatterns.Flyweight;
using DesignPatterns.StructuralPatterns.Proxy;

namespace DesignPatterns.BehavioralPatterns
{
	public static class BehavioralRunner
	{
		public static void RunBehavioralPatterns(this Runner runner)
		{
			LogInterceptor.Intercept(new Action[] {

			});
		}
	}
}

