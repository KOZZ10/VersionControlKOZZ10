using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [Test]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            var accountcontroller = new AccountController();
            var ActualResult = accountcontroller.ValidateEmail(email);
            Assert.AreEqual(expectedResult, ActualResult);
        }

    }
}
