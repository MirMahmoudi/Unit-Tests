using System;
using InDotNetFramework48.Fundamentals;
using NUnit.Framework;

namespace InDotNetFramework48.UnitTests.Fundamentals
{
    [TestFixture]
    public class PhoneNumberTests
    {
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Parse_NumberIsNullOrEmptyOrWhiteSpace_ThrowAnArgumentException(string number)
        {
            Assert.That(() => PhoneNumber.Parse(number), Throws.ArgumentException);

            Assert.Catch<ArgumentException>(() =>
                PhoneNumber.Parse(number), "Phone number cannot be blank.");

            Assert.Throws<ArgumentException>(() => 
                    PhoneNumber.Parse(number), "Phone number cannot be blank.");
        }

        [Test]
        [TestCase("1")]
        [TestCase("123")]
        [TestCase("12345678910")]
        public void Parse_NumberLengthIsNot10_ThrowAnArgumentException(string number)
        {
            Assert.That(() => PhoneNumber.Parse(number), Throws.ArgumentException);

            Assert.Catch<ArgumentException>(() =>
                PhoneNumber.Parse(number), "Phone number should be 10 digits long.");

            Assert.Throws<ArgumentException>(() =>
                PhoneNumber.Parse(number), "Phone number should be 10 digits long.");
        }

        [Test]
        public void Parse_NumberLengthIs10_ReturnNewPhoneNumberWithAreaMajorAndMinor()
        {
            var phoneNumber = PhoneNumber.Parse("0123456789");

            Assert.That(phoneNumber, Is.InstanceOf<PhoneNumber>());
            Assert.AreEqual(phoneNumber.Area, "012");
            Assert.AreEqual(phoneNumber.Major, "345");
            Assert.AreEqual(phoneNumber.Minor, "6789");
        }

        [Test]
        [TestCase(null, null, null, "()-")]
        [TestCase("", "", "", "()-")]
        [TestCase(" ", " ", " ", "( ) - ")]
        [TestCase("a", "b", "c", "(a)b-c")]
        [TestCase("012", "345", "6789", "(012)345-6789")]
        public void ToString_WhenCalled_ReturnFormattedString(
            string area, string major, string minor, string expectedResult)
        {
            var phoneNumber = new PhoneNumber(area, major, minor);
            var result = phoneNumber.ToString();

            Assert.AreEqual(expectedResult, result);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
