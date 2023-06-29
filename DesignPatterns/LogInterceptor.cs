using System;
using System.Reflection;

namespace DesignPatterns
{
	public class LogInterceptor
	{
		public LogInterceptor()
		{
		}

        public static void Intercept(Action method)
        {
            LoggerAttribute? attribute =
                method.GetMethodInfo().GetCustomAttribute<LoggerAttribute>();

            if (attribute == null)
            {
                method();
                return;
            }

            attribute.PrintBeforeMessage();

            method();

            attribute.PrintAfterMessage();
        }

        public static void Intercept(params Action[] methods)
        {
            foreach(Action method in methods)
            {
                Intercept(method);
            }
        }
    }
}

