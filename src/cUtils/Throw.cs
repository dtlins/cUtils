using System;

namespace CUtils
{
    /// <summary>
    /// Throws <typeparamref name="TException"/>.
    /// </summary>
    /// <typeparam name="TException"></typeparam>
    public static class Throw<TException> where TException : Exception
    {
        /// <summary>
        /// If <paramref name="condition"/> is met, exception is thrown.
        /// </summary>
        /// <param name="condition"></param>
        public static void If(bool condition)
        {
            ThrowIf(condition, message: null);
        }

        /// <summary>
        /// If <paramref name="condition"/> is met, exception is thrown.
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message">Exception message</param>
        public static void If(bool condition, string message)
        {
            ThrowIf(condition, message);
        }

        static void ThrowIf(bool condition, string message = null)
        {
            if (!condition) return;

            if (string.IsNullOrWhiteSpace(message))
                throw (TException)Activator.CreateInstance(typeof(TException));
            else
                throw (TException)Activator.CreateInstance(typeof(TException), message);
        }
    }
}
