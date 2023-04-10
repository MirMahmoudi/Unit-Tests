using NUnit.Framework;
using Math = InDotNet7.Fundamentals.Math;

namespace InDotNet7.UnitTests.Fundamentals
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
            Assert.AreEqual(result, 3);
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterNumber(int a , int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.AreEqual(expectedResult, result);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUoToLimit()
        {
            var result = _math.GetOddNumbers(7);

            Assert.That(result, Is.EquivalentTo(new int[]{1, 3, 5, 7}));
            Assert.AreEqual(result, new int[]{1, 3, 5, 7});
        }
    }
}
