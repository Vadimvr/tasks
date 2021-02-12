using NUnit.Framework;
using System;
using static tasks.Task4;

namespace tasks.Tests
{ 
    [TestFixture]
    public class Task4Tests
    {
        [TestCase(2, 2, ExpectedResult = 8)]
        [TestCase(1,3, ExpectedResult = 7)]
        [TestCase(1, 1, ExpectedResult = 3)]
        [TestCase(1000, 1000, ExpectedResult = 1002000)]
        

        public int ReverseMiceTests(int white , int black)
            => ReverseMice(white, black);


        [TestCase(-1, 0)]
        [TestCase(3, 10000)]
        [TestCase(10000, 1)]
        [TestCase(0, 0)]
        public void ReverseMiceTestsThrows(int white, int black)
        {
            Assert.That(() => ReverseMice( white,  black), Throws.TypeOf<ArgumentOutOfRangeException>());
        }


        [TestCase(null, 0)]
        [TestCase(null, null)]
        [TestCase(0, null)]
        public void ReverseMiceTestsThrowsArgumentNullException(int white, int black)
        {
            Assert.That(() => ReverseMice(white, black), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}