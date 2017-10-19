using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUtils.Test
{
    [TestClass]
    public class EmailValidatorTest
    {
        [TestMethod]
        public void IsValid_True()
        {
            Assert.IsTrue(EmailValidator.IsValid("someone@somewhere.com"));
            Assert.IsTrue(EmailValidator.IsValid("someone@somewhere.co.uk"));
            Assert.IsTrue(EmailValidator.IsValid("someone+tag@somewhere.net"));
            Assert.IsTrue(EmailValidator.IsValid("futureTLD@somewhere.fooo"));
            Assert.IsTrue(EmailValidator.IsValid("email@example.com"));
            Assert.IsTrue(EmailValidator.IsValid("firstname.lastname@example.com"));
            Assert.IsTrue(EmailValidator.IsValid("email@subdomain.example.com"));
            Assert.IsTrue(EmailValidator.IsValid("firstname+lastname@example.com"));
            Assert.IsTrue(EmailValidator.IsValid("email@123.123.123.123"));
            Assert.IsTrue(EmailValidator.IsValid("1234567890@example.com"));
            Assert.IsTrue(EmailValidator.IsValid("email@example-one.com"));
            Assert.IsTrue(EmailValidator.IsValid("_______@example.com"));
            Assert.IsTrue(EmailValidator.IsValid("email@example.name"));
            Assert.IsTrue(EmailValidator.IsValid("email@example.museum"));
            Assert.IsTrue(EmailValidator.IsValid("email@example.co.jp"));
            Assert.IsTrue(EmailValidator.IsValid("firstname-lastname@example.com"));
        }

        [TestMethod]
        public void IsValid_False()
        {
            Assert.IsFalse(EmailValidator.IsValid("fdsa"));
            Assert.IsFalse(EmailValidator.IsValid("fdsa@"));
            Assert.IsFalse(EmailValidator.IsValid("fdsa@fdsa"));
            Assert.IsFalse(EmailValidator.IsValid("fdsa@fdsa."));
            Assert.IsFalse(EmailValidator.IsValid("plainaddress"));
            Assert.IsFalse(EmailValidator.IsValid("#@%^%#$@#$@#.com"));
            Assert.IsFalse(EmailValidator.IsValid("@example.com"));
            Assert.IsFalse(EmailValidator.IsValid("Joe Smith <email@example.com>"));
            Assert.IsFalse(EmailValidator.IsValid("email.example.com"));
            Assert.IsFalse(EmailValidator.IsValid("email@example@example.com"));
            Assert.IsFalse(EmailValidator.IsValid(".email@example.com"));
            Assert.IsFalse(EmailValidator.IsValid("email.@example.com"));
            Assert.IsFalse(EmailValidator.IsValid("email..email@example.com"));
            Assert.IsFalse(EmailValidator.IsValid("あいうえお@example.com"));
            Assert.IsFalse(EmailValidator.IsValid("email@example.com (Joe Smith)"));
            Assert.IsFalse(EmailValidator.IsValid("email@example"));
            Assert.IsFalse(EmailValidator.IsValid("email@-example.com"));
            Assert.IsFalse(EmailValidator.IsValid("email@example..com"));
            Assert.IsFalse(EmailValidator.IsValid("Abc..123@example.com"));
            Assert.IsFalse(EmailValidator.IsValid("“(),:;<>[\\]@example.com"));
            Assert.IsFalse(EmailValidator.IsValid("just\"not\"right@example.com"));
            Assert.IsFalse(EmailValidator.IsValid("this\\ is\"really\"not\allowed@example.com"));
        }
    }
}
