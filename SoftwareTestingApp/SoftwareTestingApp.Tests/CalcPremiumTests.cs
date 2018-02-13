using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SoftwareTestingApp.Tests
{
    [TestFixture]
    public class CalcPremiumTests
    {
        [Test]
        public void TestTest()
        {
            var sut = new Insurance();

            var result = sut.CalcPremium(100,"female");

            Assert.That(result, Is.GreaterThan(0));
        }
    }
}
