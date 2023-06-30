using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Bridge;

namespace DesignPatterns.CreationalPatterns
{
	public static class StructuralPatternsProgram
	{
		public static void RunStructuralPatterns(this Runner runner)
		{
			LogInterceptor.Intercept(new Action[] {
				AdapterRunner.Run,
				BridgeRunner.Run
			});
		}
	}
}

