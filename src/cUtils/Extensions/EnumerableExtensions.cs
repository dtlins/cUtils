using System;
using System.Collections.Generic;
using System.Linq;

namespace CUtils.Extensions
{
    /// <summary>
    /// Extension methods for Enumerables
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Apply Action on each member of Enumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <param name="action"></param>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            Guard.ThrowIfNull(action, nameof(action));

            foreach (T item in enumerable) { action(item); }
        }
    }
}
