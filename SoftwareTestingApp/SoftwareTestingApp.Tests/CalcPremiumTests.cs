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
        [TestCase(25, "female", 5.0)]
        public void TestPremiumCalculator(int age, string gender, double expected)
        {
            var sut = new Insurance();
            var result = sut.CalcPremium(age, gender);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
