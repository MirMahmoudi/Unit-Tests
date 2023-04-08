using InDotNetFramework48.Fundamentals;
using NUnit.Framework;

namespace InDotNetFramework48.UnitTests.Fundamentals
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutPut_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("fizzBuzz").IgnoreCase);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutPut_InputIsDivisibleBy3_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(18);
            Assert.That(result, Is.EqualTo("fizz").IgnoreCase);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutPut_InputIsDivisibleBy5_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);
            Assert.That(result, Is.EqualTo("buzz").IgnoreCase);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutPut_InputIsNotDivisibleBy3Or5_ReturnTheActualNumber()
        {
            var result = FizzBuzz.GetOutput(14);
            Assert.That(result, Is.EqualTo("14"));
        }
    }
}
