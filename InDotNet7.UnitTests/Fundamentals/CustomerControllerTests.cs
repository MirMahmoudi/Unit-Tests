using InDotNet7.Fundamentals;
using NUnit.Framework;

namespace InDotNet7.UnitTests.Fundamentals
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _customerController;

        [SetUp]
        public void SetUp()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = _customerController.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());
            Assert.That(result, Is.TypeOf(typeof(NotFound)));
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void GetCustomer_IdIsNotZero_ReturnOk(int id)
        {
            var result = _customerController.GetCustomer(id);

            Assert.That(result, Is.TypeOf<Ok>());
            Assert.That(result, Is.TypeOf(typeof(Ok)));
        }
    }
}
