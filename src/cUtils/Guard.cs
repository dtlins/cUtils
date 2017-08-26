using System;
using System.Diagnostics;

namespace CUtils
{
    /// <summary>
    /// Argument validation class.
    /// </summary>
    public static class Guard
    {
        /// <param name="argumentValue"></param>
        /// <param name="argumentName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        [DebuggerHidden]
        public static void ThrowIfNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
                throw new ArgumentNullException(argumentName);
        }
    }
}
