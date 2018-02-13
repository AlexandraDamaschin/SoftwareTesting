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
        [TestCase(20, "female", 5.0)]
        [TestCase(57, "female", 0.375)]
        [TestCase(16, "female", 0)]
        [TestCase(16, "male", 0)]
        public void TestPremiumCalculator(int age, string gender, double expected)
        {
            var sut = new Insurance();
            var result = sut.CalcPremium(age, gender);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
