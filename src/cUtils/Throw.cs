using System;

namespace CUtils
{
    /// <summary>
    /// Throws any exception
    /// </summary>
    /// <typeparam name="TException"></typeparam>
    public class Throw<TException> where TException : Exception
    {
        /// <summary>
        /// If <paramref name="condition"/> is met, <typeparamref name="TException"/> is thrown.
        /// </summary>
        /// <param name="condition"></param>
        public static void If(bool condition)
        {
            ThrowIf(condition, message: null);
        }

        /// <summary>
        /// If <paramref name="condition"/> is met, <typeparamref name="TException"/> is thrown.
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

        /// <summary>
        /// Throw with no message.
        /// </summary>
        public static void WithNoMessage()
        {
            throw (TException)Activator.CreateInstance(typeof(TException));
        }

        /// <summary>
        /// Throw with message.
        /// </summary>
        /// <param name="message"></param>
        public static void WithMessage(string message)
        {
            throw (TException)Activator.CreateInstance(typeof(TException), message);
        }
    }
}
