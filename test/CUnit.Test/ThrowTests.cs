using CUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CUnit.Test
{
    [TestClass]
    public class ThrowTests
    {
        [TestMethod]
        public void If_True_ThrowsException()
        {
            var condition = true;
            var message = "message";

            Assert.ThrowsException<Exception>(() => Throw<Exception>.If(condition, message), message);
        }

        [TestMethod]
        public void If_False_NoException()
        {
            var condition = false;
            var message = "message";

            AssertEx.DoesNotThrowException<Exception>(() => Throw<Exception>.If(condition, message));
        }
    }

    sealed class AssertEx
    {
        public static void DoesNotThrowException<TException>(Action a)where TException : Exception
        {
            try
            {
                a();
            }
            catch (TException)
            {
                Assert.Fail($"Expected no {typeof(TException).Name} to be thrown.");
                throw;
            }
        }
    }
}
