using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using DesignPatterns.CreationalPatterns.Prototype;
using DesignPatterns.CreationalPatterns.Singleton;
using DesignPatterns.StructuralPatterns.Adapter;

namespace DesignPatterns.CreationalPatterns
{
	public static class StructuralPatternsProgram
	{
		public static void RunStructuralPatterns(this Runner runner)
		{
			LogInterceptor.Intercept(new Action[] {
				AdapterRunner.Run
			});
		}
	}
}

