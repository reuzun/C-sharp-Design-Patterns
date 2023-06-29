using System;
namespace DesignPatterns
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class LoggerAttribute : Attribute
    {

        private string beforeMessage;
        private string afterMessage;

        public LoggerAttribute(string beforeMessage, string afterMessage)
        {
            this.beforeMessage = beforeMessage;
            this.afterMessage = afterMessage;
        }

        public void PrintBeforeMessage()
        {
            printMessage(beforeMessage);
        }

        public void PrintAfterMessage()
        {
            Console.WriteLine();
            printMessage(afterMessage);
        }

        private void printMessage(string message)
        {
            Console.WriteLine("---" + message + "---\n");
        }
    }
}

