using NUnit.Framework;
using Stack = InDotNet7.Fundamentals.Stack<object>;

namespace InDotNet7.UnitTests.Fundamentals
{
    [TestFixture]
    public class StackTests
    {
        private Stack _stack;
        private object _obj1;
        private object _obj2;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack();
            _obj1 = new { id = 1 };
            _obj2 = new { id = 2 };
        }

        [Test]
        public void Push_ArgumentIsNull_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _stack.Push(null));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.AreEqual(0, _stack.Count);
        }

        [Test]
        public void Push_WhenCalled_AddToStackList()
        {
            _stack.Push(_obj1);
            Assert.AreEqual(_stack.Count, 1);
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Pop());
        }

        [Test]
        public void Pop_StackIsNotEmpty_ReturnTheRemovedObjectAndStackCountIsReduced()
        {
            _stack.Push(_obj1);
            _stack.Push(_obj2);
            var result = _stack.Pop();

            Assert.AreEqual(_obj2, result);
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => _stack.Peek());
        }

        [Test]
        public void Peek_StackIsNotEmpty_ReturnTheLastMemberOfStack()
        {
            _stack.Push(_obj1);
            _stack.Push(_obj2);
            var result = _stack.Peek();

            Assert.AreEqual(_obj2, result);
            Assert.That(_stack.Count, Is.EqualTo(2));
        }
    }
}
