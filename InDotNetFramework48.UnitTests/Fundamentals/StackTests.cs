using System;
using InDotNetFramework48.Fundamentals;
using NUnit.Framework;

namespace InDotNetFramework48.UnitTests.Fundamentals
{
    [TestFixture]
    public class StackTests
    {
        private Stack<object> _stack;
        private object _obj1;
        private object _obj2;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<object>();
            _obj1 = new { name = "a" };
            _obj2 = new { name = "b" };
        }

        [Test]
        public void Push_ArgumentIsNull_ThrowNullException()
        {
            Assert.Throws<ArgumentNullException>((() =>
                    _stack.Push(null)));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_WhenCalled_AddToStackList()
        {
            _stack.Push(_obj1);
            Assert.AreEqual(1, _stack.Count);
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>((() => _stack.Pop()));
        }

        [Test]
        public void Pop_StackIsNotEmpty_ReturnTheRemovedObjectAndStackCountIsReduced()
        {
            _stack.Push(_obj1);
            _stack.Push(_obj2);
            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo(_obj2));
            Assert.AreEqual(_stack.Count, 1);
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>((() => _stack.Peek()));
        }

        [Test]
        public void Peek_StackIsNotEmpty_ReturnTheLastMemberOfStack()
        {
            _stack.Push(_obj1);
            _stack.Push(_obj2);
            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo(_obj2));
            Assert.AreEqual(_stack.Count, 2);
        }
    }
}
