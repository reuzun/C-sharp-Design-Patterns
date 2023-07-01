using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Bridge;
using DesignPatterns.StructuralPatterns.Composite;
using DesignPatterns.StructuralPatterns.Decorator;
using DesignPatterns.StructuralPatterns.Flyweight;
using DesignPatterns.StructuralPatterns.Proxy;

namespace DesignPatterns.CreationalPatterns
{
	public static class StructuralPatternsProgram
	{
		public static void RunStructuralPatterns(this Runner runner)
		{
			LogInterceptor.Intercept(new Action[] {
				AdapterRunner.Run,
				BridgeRunner.Run,
				CompositeRunner.Run,
				DecoratorRunner.Run,
				FlyweightRunner.Run,
				ProxyRunner.Run
			});
		}
	}
}

