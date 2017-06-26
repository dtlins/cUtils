using System;
using System.Collections.Generic;
using System.Text;

namespace cUtils
{
    /// <summary>
    /// Throws <typeparamref name="TException"/> if condition is met.
    /// </summary>
    /// <typeparam name="TException"></typeparam>
    public static class Throw<TException> where TException : Exception
    {
        /// <summary>
        /// If <paramref name="condition"/> is met, exception is thrown.
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message">Exception message</param>
        public static void If(bool condition, string message)
        {
            if (condition)
                throw (TException)Activator.CreateInstance(typeof(TException), message);
        }
    }
}
