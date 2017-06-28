using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace CUtils.Test
{
    [TestClass]
    public class ThrowTests
    {
        [TestMethod]
        public void If_True_ThrowsExceptionWithMessage()
        {
            var condition = true;
            var message = "message";

            Assert.ThrowsException<Exception>(() => Throw<Exception>.If(condition, message), message);
        }

        [TestMethod]
        public void If_True_ThrowsExceptionNoMessage()
        {
            var condition = true;

            Assert.ThrowsException<Exception>(() => Throw<Exception>.If(condition));
        }

        [TestMethod]
        public void If_False_NoException()
        {
            var condition = false;
            var message = "message";

            AssertEx.DoesNotThrowException<Exception>(() => Throw<Exception>.If(condition, message));
        }
    }

    [ExcludeFromCodeCoverage]
    sealed class AssertEx
    {
        public static void DoesNotThrowException<TException>(Action a) where TException : Exception
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
