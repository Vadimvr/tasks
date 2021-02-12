using NUnit.Framework;
using System;
using static tasks.Task2;

namespace tasks.Tests
{
    [TestFixture]
    public class Task2Tests
    {


        [TestCase(arg: new string[] { "4 6", "2000", "2000", "1000", "1000" }, ExpectedResult = 2000.000)]
        [TestCase(arg: new string[] { "4 4", "3000", "3000", "1000", "1000" }, ExpectedResult = 1500.000)]
        [TestCase(arg: new string[] { "4 4", "1000", "1000", "1000", "1000" }, ExpectedResult = 1000.000)]
        [TestCase(arg: new string[] { "4 6", "1000", "1000", "1000", "1000" }, ExpectedResult = 1500.000)]
        [TestCase(arg: new string[] { "4 8", "1000", "1000", "1000", "1000" }, ExpectedResult = 2000.000)]
        [TestCase(arg: new string[] { "4 16", "1000", "1000", "1000", "1000" }, ExpectedResult = 4000.000)]

        public double DistanceInKilometersTests(string[] s)
              => DistanceInKilometers(s);


        [TestCase(null)]
        public void DistanceInKilometersThrowsArgumentNullException(string[] s)
        {
            Assert.That(() => DistanceInKilometers(s), Throws.TypeOf<ArgumentNullException>());
        }

        [TestCase(arg: new string[] { "4", "2000", "2000", "1000", "1000" })]
        [TestCase(arg: new string[] { "4 45", "3000", "3000", "1000", "1000" })]
        [TestCase(arg: new string[] { "4 45", "8000", "3000", "1000", "1000" })]
        [TestCase(arg: new string[] { "4 4", "-1000", "3000", "1000", "1000" })]
        [TestCase(arg: new string[] { "-4 4", "1000", "3000", "1000", "1000" })]
        [TestCase(arg: new string[] { "3 4", "1000", "3000", "1000", "1000" })]
        [TestCase(arg: new string[] { "4 2", "1000", "3000", "1000", "1000" })]
        [TestCase(arg: new string[] { "", "2000", "2000", "1000", "1000" })]

        public void DistanceInKilometersThrowsArgumentOutOfRangeException(string[] s)
        {
            Assert.That(() => DistanceInKilometers(s), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(arg: new string[] { "4 ", "2000", "2000", "1000", "1000" })]

        public void ProductOfNumberThrowsFormatException(string[] s)
        {
            Assert.That(() => DistanceInKilometers(s), Throws.TypeOf<FormatException>());
        }

        [TestCase(arg: new string[] { "4 4", "3000", "3000", "1000" })]

        public void ProductOfNumberThrowsArgumentException(string[] s)
        {
            Assert.That(() => DistanceInKilometers(s), Throws.TypeOf<ArgumentException>());
        }




    }
}