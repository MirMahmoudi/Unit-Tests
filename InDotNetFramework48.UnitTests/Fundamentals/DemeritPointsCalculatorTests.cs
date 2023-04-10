using System;
using InDotNetFramework48.Fundamentals;
using NUnit.Framework;

namespace InDotNetFramework48.UnitTests.Fundamentals
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _demeritPointsCalculator;

        [SetUp]
        public void Setup()
        {
            _demeritPointsCalculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowOutOfRangeException(int speed)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                _demeritPointsCalculator.CalculateDemeritPoints(speed));

            Assert.That(() =>
                _demeritPointsCalculator.CalculateDemeritPoints(speed),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

            Assert.Catch<ArgumentOutOfRangeException>(() =>
                _demeritPointsCalculator.CalculateDemeritPoints(speed));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(71, 1)]
        [TestCase(115, 10)]
        public void CalculateDemeritPoints_SpeedIsIsInRange_ReturnDemeritPoints(int speed, int demeritPoints)
        {
            var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(demeritPoints));
        }
    }
}
