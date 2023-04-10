using InDotNet7.Fundamentals;
using NUnit.Framework;

namespace InDotNet7.UnitTests.Fundamentals
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var htmlFormatter = new HtmlFormatter();
            var result = htmlFormatter.FormatAsBold("abc");

            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

        }
    }
}
