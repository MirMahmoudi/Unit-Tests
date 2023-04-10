using System;
using InDotNetFramework48.Fundamentals;
using NUnit.Framework;

namespace InDotNetFramework48.UnitTests.Fundamentals
{
    [TestFixture]
    public class DateHelperTests
    {
        [Test]
        [TestCase(1999, 12, 1)]
        [TestCase(2020, 12, 20)]
        [TestCase(2022, 12, 31)]
        public void FirstOfNextMonth_GetDateWithMonth12_ReturnFirstDayOfNewYear(int year, int month, int day)
        {
            var dateTime = new DateTime(year, month, day);
            var result = DateHelper.FirstOfNextMonth(dateTime);

            Assert.That(result, Is.EqualTo(new DateTime(year + 1, 1, 1)));
        }

        [Test]
        [TestCase(1999, 1, 1)]
        [TestCase(2020, 8, 20)]
        [TestCase(2022, 11, 30)]
        public void FirstOfNextMonth_GetDateWithOtherMonth_ReturnFirstDayOfNextMonthAtTheSameYear(int year, int month, int day)
        {
            var dateTime = new DateTime(year, month, day);
            var result = DateHelper.FirstOfNextMonth(dateTime);

            Assert.That(result, Is.EqualTo(new DateTime(year, month + 1, 1)));
        }
    }
}
