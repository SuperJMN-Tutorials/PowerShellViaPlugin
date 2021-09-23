using System.Threading.Tasks;
using Plugins;

namespace ConsoleApp2
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var plugins = PluginFactory.Load("C:\\Users\\JMN\\source\\repos\\ConsoleApp2\\ClassLibrary1\\bin\\Debug\\net5.0\\Plugins.MyService.dll");

            foreach (var plugin in plugins)
            {
                var r = await plugin.GetSomething();
            }
        }
    }
}