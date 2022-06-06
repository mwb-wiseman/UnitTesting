using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    // To test a test, go to the function that is being tested and intentionally change the line that is supposed to be being tested (e.g. the return value)

    [TestFixture]
    internal class MathTests
    {
        private Math _math;

        // SetUp - called before each test
        // TearDown - called after each test (usually with Integration tests, rather than Unit tests)

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        // Ignore attribute better alternative to commenting out test - will still show on TestRunner report, along with reason you gave for ignoring
        [Ignore("Insert reason I want to ignore")]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            // var math = new Math();

            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        // Can have different TestCases for each scenario rather than separate TestMethods each time
        // Not really available in MSTest - NUnit feature
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            // var math = new Math();

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5); // Don't use 1 as otherwise array only has 1 entry

            // Assert.That(result, Is.Not.Empty); // Too general in this case

            // Assert.That(result.Count(), Is.EqualTo(3));

            // Assert.That(result, Does.Contain(1));
            // Assert.That(result, Does.Contain(3));
            // Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 })); // shorthand of above, doens't check order

            // Some other useful assertions
            // Assert.That(result, Is.Ordered);
            // Assert.That(result, Is.Unique);
        }
    }
}
