using System.Threading.Tasks;

namespace Plugins
{
    public interface IPlugin
    {
        public Task<string> GetSomething();
    }
}
