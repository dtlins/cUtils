using System;
using System.Collections.Generic;
using System.Text;

namespace cUtils
{
    public static class Throw<TException> where TException : Exception
    {
        public static void If(bool condition, string message)
        {
            if (condition)
                throw (TException)Activator.CreateInstance(typeof(TException), message);
        }
    }
}
