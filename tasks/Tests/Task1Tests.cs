using NUnit.Framework;
using System;
using System.Collections.Generic;
using static tasks.Task1;

namespace tasks.Tests
{
    [TestFixture]
    public class Task1Tests
    {


        [Test]
        public void Add_WithOneNumber_ReturnsNumber()
        {

            var result = FunctionFfromX(new string[] { "2", "0", "-4" });


            Assert.AreEqual(new List<string>() { "123.456", "-17.344" }, result);
            result = FunctionFfromX(new string[] { "6", "0", "-4", "0", "-4", "0", "-4" });
            Assert.AreEqual(new List<string>() { "123.456", "-17.344", "123.456", "-17.344", "123.456", "-17.344" }, result);
            Assert.AreEqual(6, result.Count);

            List<string> a = new List<string>();
            a.Add(100.ToString());
            for (int i = -1000; i < -900; i++)
            {
                a.Add(i.ToString());

            }
            Assert.AreEqual(100, FunctionFfromX(a.ToArray()).Count);
        }
        [TestCase(null)]
        public void DistanceInKilometersThrowsArgumentNullException(string[] s)
        {
            Assert.That(() => FunctionFfromX(s), Throws.TypeOf<ArgumentNullException>());
        }

        [TestCase(arg: new string[] { "2", "0", "-4000" })]
        [TestCase(arg: new string[] { "101", "0", "-400" })]
        [TestCase(arg: new string[] { "-222", "0" })]
        [TestCase(arg: new string[] { "2", "0", "-400", "-400", "-400", "-400", "-400", "-400" })]
        [TestCase(arg: new string[] { "2" })]


        public void FunctionFfromXArgumentOutOfRangeException(string[] s)
        {
            Assert.That(() => FunctionFfromX(s), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(arg: new string[] { "2", "0", "giuygugu" })]
        [TestCase(arg: new string[] { "2,", "0", "-4 " })]
        [TestCase(arg: new string[] { "2.", "0", "-4" })]
        [TestCase(arg: new string[] { "2", "0ds", "-4 " })]
        [TestCase(arg: new string[] { "", "0", "-4 " })]
        [TestCase(arg: new string[] { "2", "", "-4 " })]
        [TestCase(arg: new string[] { "", "", "" })]
        [TestCase(arg: new string[] { null, "0", "-4 " })]
        [TestCase(arg: new string[] { "2", null, "0"})]

        public void FunctionFfromXThrowsFormatException(string[] s)
        {
            Assert.That(() => FunctionFfromX(s), Throws.TypeOf<FormatException>());
        }

    }
}