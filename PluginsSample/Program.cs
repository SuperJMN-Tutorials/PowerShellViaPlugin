using System;
using System.Threading.Tasks;
using Plugins.Core;

namespace PluginsSample
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var plugins = PluginFactory.Load("..\\..\\..\\..\\Plugins.MyService\\bin\\Debug\\net5.0\\Plugins.MyService.dll");

            foreach (var plugin in plugins)
            {
                var result = await plugin.GetSomething();
                Console.WriteLine(result);
            }
        }
    }
}