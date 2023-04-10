using InDotNet7.Fundamentals;
using NUnit.Framework;

namespace InDotNet7.UnitTests.Fundamentals
{
    [TestFixture]
    public class ReservationTests
    {
        private Reservation _reservation;

        [SetUp]
        public void Setup()
        {
            _reservation = new Reservation();
        }

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            var user = new User() { IsAdmin = true };
            var result = _reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result is true);
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_UserIsTheSameWhoReserved_ReturnTrue()
        {
            var user = new User();
            _reservation.MadeBy = user;
            var result = _reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNotAdminAndTheSameUser_ReturnFalse()
        {
            var user = new User();
            var result = _reservation.CanBeCancelledBy(user);

            Assert.IsFalse(result);
            Assert.That(result, Is.False);
            Assert.That(result is false);
            Assert.That(result == false);
        }
    }
}
