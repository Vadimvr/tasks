using NUnit.Framework;
using System;
using static tasks.Task3;

namespace tasks.Tests
{
    [TestFixture]
    public class Task3Tests
    {
        [TestCase("3 4 12", ExpectedResult = 81)]
        [TestCase("3 5 13", ExpectedResult = 75)]
        [TestCase("3 2 99", ExpectedResult = 5559060566555523)]
        [TestCase("2 3 96", ExpectedResult = 1853020188851841)]
        [TestCase("2 7 96", ExpectedResult = 281474976710656)]


        public long ProductOfNumberTests(string s)
            => ProductOfNumber(s);


        [TestCase("-2 2 10")]
        [TestCase("2 -2 10")]
        [TestCase("-2 2 -10")]
        [TestCase("0 2 101")]
        public void ProductOfNumberThrowsArgumentOutOfRangeException(string s)
        {
            Assert.That(() => ProductOfNumber(s), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase("3,2 2 12")]
        public void ProductOfNumberThrowsFormatException(string s)
        {
            Assert.That(() => ProductOfNumber(s), Throws.TypeOf<FormatException>());
        }

        [TestCase("3 2")]
        [TestCase("3212")]

        public void ProductOfNumberThrowsArgumentException(string s)
        {
            Assert.That(() => ProductOfNumber(s), Throws.TypeOf<ArgumentException>());
        }




        [TestCase(null)]
        public void ProductOfNumberThrowsArgumentNullException(string s)
        {
            Assert.That(() => ProductOfNumber(s), Throws.TypeOf<ArgumentNullException>());
        }
    }
}