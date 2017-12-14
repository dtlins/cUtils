using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CUtils.Test
{
    [TestClass]
    public class GuardTest
    {
        [TestMethod]
        public void Guard_Null_ThrowsArgumentNullException()
        {

            object argValue = null;
            var argName = "Arg1";

            Assert.ThrowsException<ArgumentNullException>(() => Guard.ThrowIfNull(argValue, argName));
        }

        [TestMethod]
        public void Guard_NotNull_NoException()
        {
            object argValue = new object();
            var argName = "Arg1";

            AssertEx.DoesNotThrowException<Exception>(() => Guard.ThrowIfNull(argValue, argName));
        }
    }
}
