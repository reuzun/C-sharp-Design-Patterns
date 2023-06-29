using System;
namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
	public abstract class BaseCalculator
	{
        private string Name { get; set; }
        private int Version { get; set; }

        public BaseCalculator(string name, int version)
        {
            this.Name = name;
            this.Version = version;
        }

        public string Print()
        {
            return $"v:{Name}-{Version}";
        }
    }
}

