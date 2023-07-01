using System;
using DesignPatterns;
using DesignPatterns.BehavioralPatterns;
using DesignPatterns.CreationalPatterns;

namespace Program
{
	public class ProgramClass
	{
		public static void Main(string[] args)
		{
			Runner runner = new Runner();
			Console.WriteLine("-+-+-+-+-+-+Creational Patterns+-+-+-+-+-+-+-\n");
			runner.RunCreationalPatterns();
			Console.WriteLine("-+-+-+-+-+-+Structural Patterns+-+-+-+-+-+-+-\n");
			runner.RunStructuralPatterns();
			Console.WriteLine("-+-+-+-+-+-+Behavioral Patterns+-+-+-+-+-+-+-\n");
			runner.RunBehavioralPatterns();
		}
	}
}

