using System.Management.Automation;
using System.Threading.Tasks;

namespace Plugins.MyService
{
    public class MyService : IPlugin
    {
        public async Task<string> GetSomething()
        {
            var ps = PowerShell.Create();
            ps.AddScript("Get-Disk");
            var result = await ps.InvokeAsync();

            return result.ToString();
        }
    }
}
