using System.Management.Automation;
using System.Threading.Tasks;
using Plugins.Core;

namespace Plugins.MyService
{
    public class MyService : IPlugin
    {
        public async Task<string> GetSomething()
        {
            var ps = PowerShell.Create();
            ps.AddScript("Get-Disk");
            var result = await ps.InvokeAsync();

            if (ps.HadErrors)
            {
                return string.Join(";", ps.Streams.Error);
            }

            return "The call succeeded!";
        }
    }
}
