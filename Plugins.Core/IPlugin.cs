using System.Threading.Tasks;

namespace Plugins.Core
{
    public interface IPlugin
    {
        public Task<string> GetSomething();
    }
}
