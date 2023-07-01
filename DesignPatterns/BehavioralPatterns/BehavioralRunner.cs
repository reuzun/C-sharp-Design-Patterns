using DesignPatterns.BehavioralPatterns.Command;
using DesignPatterns.BehavioralPatterns.CoR;

namespace DesignPatterns.BehavioralPatterns
{
	public static class BehavioralRunner
	{
		public static void RunBehavioralPatterns(this Runner runner)
		{
			LogInterceptor.Intercept(new Action[] {
				CoRRunner.Run,
				CommandRunner.Run
			});
		}
	}
}

