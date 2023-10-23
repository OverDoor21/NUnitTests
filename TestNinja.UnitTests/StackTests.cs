using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {

        [Test]
        public void Push_ArgIsNull_ThrowArgNullExceptiom()
        {
            var stack = new Stack<string>(); 
            Assert.That(() => stack.Push(null),
                Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArg_AddTheObjectToTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Stack<string>();
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_emptyStack_throwInvalidOperationException()
        {
            var stack = new Stack<string>();
            Assert.That(()
                => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithFewObjects_ReturnsObjectOnTheTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Pop_StackWithFewObjects_RemovesObjectOnTheTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Pop();
            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);

        }

        [Test]
        public void Peek_StackWithObjects_ReturnObjectOnTopTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

           var result = stack.Peek();

            Assert.That(result, Is.EqualTo("c"));

        }

        [Test]
        public void Peek_StackWithObjects_DOesntRomoveTheObjectOntopOfTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));

        }

    }
}

