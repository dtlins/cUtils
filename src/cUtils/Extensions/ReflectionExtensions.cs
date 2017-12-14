using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CUtils.Extensions
{
    /// <summary>
    /// Reflection Extension Methods.
    /// </summary>
    public static class ReflectionExtensions
    {
#if NET40 || NET45 || NET46
        /// <summary>
        /// Loads all assemblies with a matching prefix or the current assembly prefix by default.
        /// </summary>
        /// <param name="appDomain"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static IEnumerable<Assembly> LoadAllAssemblies(this AppDomain appDomain, string prefix = null)
        {
            if (string.IsNullOrWhiteSpace(prefix)) prefix = GetAssemblyPrefix();
            string[] assemblyMatch = new[] { $"{ prefix }*.dll" };

            return Directory.EnumerateFiles(appDomain.BaseDirectory, "*.dll", SearchOption.AllDirectories)
                      .Where(filename => assemblyMatch.Any(pattern => Regex.IsMatch(filename, pattern)))
                      .Select(Assembly.LoadFrom);

            string GetAssemblyPrefix()
            {
                var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
                return assemblyName.Substring(0, assemblyName.LastIndexOf('.')) + '.';
            }
        }
#endif
    }
}
