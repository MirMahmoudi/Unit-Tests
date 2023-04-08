using InDotNet7.Fundamentals;
using NUnit.Framework;

namespace InDotNet7.UnitTests.Fundamentals
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("fizzBuzz").IgnoreCase);
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy3_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(9);
            Assert.That(result, Is.EqualTo("fizz").IgnoreCase);
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy5_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);
            Assert.That(result, Is.EqualTo("buzz").IgnoreCase);
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnTheActualNumber()
        {
            var result = FizzBuzz.GetOutput(14);
            Assert.That(result, Is.EqualTo("14").IgnoreCase);
        }
    }
}
