﻿using DesignPatterns.BehavioralPatterns.Command;
using DesignPatterns.BehavioralPatterns.CoR;
using DesignPatterns.BehavioralPatterns.Mediator;
using DesignPatterns.BehavioralPatterns.Memento;
using DesignPatterns.BehavioralPatterns.State;
using DesignPatterns.BehavioralPatterns.TemplateMethod;
using DesignPatterns.BehavioralPatterns.Visitor;

namespace DesignPatterns.BehavioralPatterns
{
	public static class BehavioralRunner
	{
		public static void RunBehavioralPatterns(this Runner runner)
		{
			LogInterceptor.Intercept(new Action[] {
				CoRRunner.Run,
				CommandRunner.Run,
				MediatorRunner.Run,
				MementoRunner.Run,
				StateRunner.Run,
				TemplateMethodRunner.Run,
				VisitorRunner.Run
			});
		}
	}
}

