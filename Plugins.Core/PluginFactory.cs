using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Plugins.Core
{
    public class PluginFactory
    {
        public static IEnumerable<IPlugin> Load(string location)
        {
            var pluginCatalog = new PluginLoadContext(location);
            var assembly = pluginCatalog.LoadFromAssemblyName(AssemblyName.GetAssemblyName(location));

            var plugins = from type in assembly.ExportedTypes
                where typeof(IPlugin).IsAssignableFrom(type)
                where !type.IsAbstract
                select (IPlugin)Activator.CreateInstance(type);

            return plugins.ToList();
        }
    }
}