using InDotNet7.Fundamentals;
using NUnit.Framework;

namespace InDotNet7.UnitTests.Fundamentals
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _errorLogger;

        [SetUp]
        public void Setup()
        {
            _errorLogger = new ErrorLogger();
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowANullException(string error)
        {
            Assert.That( () => _errorLogger.Log(error), Throws.ArgumentNullException);
            Assert.Catch<ArgumentNullException>((() => _errorLogger.Log(error)));
            Assert.Throws<ArgumentNullException>((() => _errorLogger.Log(error)));
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            _errorLogger.Log("abc");
            Assert.That(_errorLogger.LastError, Is.EqualTo("abc"));
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var id = Guid.Empty;
            _errorLogger.ErrorLogged += (sender, argsGuid) => { id = argsGuid; };
            _errorLogger.Log("a");

            Assert.That( id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
