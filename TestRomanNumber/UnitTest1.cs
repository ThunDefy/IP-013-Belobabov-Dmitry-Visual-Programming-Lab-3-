using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;


namespace TestRomanNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test—onstructor()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(3999);
            string expected1 = "X";
            string expected2 = "MMMCMXCIX";

            Assert.AreEqual(expected1, n1.ToString());
            Assert.AreEqual(expected2, n2.ToString());
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(0));
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(6666));
        }

        [TestMethod]
        public void TestAdd()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(20);
            var n3 = new RomanNumber(3990);
            var n4 = new RomanNumber(3);
            var expected1 = new RomanNumber(30);
            var expected2 = new RomanNumber(3993);

            RomanNumber actual1 = n1 + n2;
            RomanNumber actual2 = n3 + n4;

            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());
            Assert.ThrowsException<RomanNumberException>(() => n3 + n2);
            Assert.ThrowsException<RomanNumberException>(() => n3 + (n2-n2));
        }

        [TestMethod]
        public void TestSub()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(20);
            var n3 = new RomanNumber(3990);
            var n4 = new RomanNumber(3);
            var expected1 = new RomanNumber(10);
            var expected2 = new RomanNumber(3987);

            RomanNumber actual1 = n2 - n1;
            RomanNumber actual2 = n3 - n4;

            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());
            Assert.ThrowsException<RomanNumberException>(() => n1 - n2);
            Assert.ThrowsException<RomanNumberException>(() => n4 - n3);
            Assert.ThrowsException<RomanNumberException>(() => n4 - (n3-n3));
            Assert.ThrowsException<RomanNumberException>(() => n3 - n3);
        }

        [TestMethod]
        public void TestMul()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(200);
            var n3 = new RomanNumber(3990);
            var n4 = new RomanNumber(3);
            var expected1 = new RomanNumber(2000);
            var expected2 = new RomanNumber(600);

            RomanNumber actual1 = n2 * n1;
            RomanNumber actual2 = n2 * n4;

            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());
            Assert.ThrowsException<RomanNumberException>(() => n3 * n2);
            Assert.ThrowsException<RomanNumberException>(() => n3 * (n2-n2));
        }

        [TestMethod]
        public void TestDiv()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(200);
            var n3 = new RomanNumber(3990);
            var n4 = new RomanNumber(3);
            var expected1 = new RomanNumber(19);
            var expected2 = new RomanNumber(66);

            RomanNumber actual1 = n3 / n2;
            RomanNumber actual2 = n2 / n4;

            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());
            Assert.ThrowsException<RomanNumberException>(() => n4 / n3);
            Assert.ThrowsException<RomanNumberException>(() => n4 / (n3-n3));
        }

        [TestMethod]
        public void TestToString()
        {
            var n1 = new RomanNumber(10);
            var n2 = new RomanNumber(3999);
            string expected1 = "X";
            string expected2 = "MMMCMXCIX";

            string actual1 = n1.ToString();
            string actual2 = n2.ToString();

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void TestClone()
        {
            RomanNumber n1 = new RomanNumber(10);
            RomanNumber n2 = new RomanNumber(3999);
            RomanNumber expected1 = new RomanNumber(10);
            RomanNumber expected2 = new RomanNumber(3999);

            RomanNumber actual1 = (RomanNumber)n1.Clone();
            RomanNumber actual2 = (RomanNumber)n2.Clone();

            Assert.AreEqual(expected1.ToString(), actual1.ToString());
            Assert.AreEqual(expected2.ToString(), actual2.ToString());
            Assert.AreNotSame(expected1, n1);
            Assert.AreNotSame(expected2, n2);
        }

        [TestMethod]
        public void TestCompareTo()
        {
            RomanNumber n1 = new RomanNumber(5);
            RomanNumber n2 = new RomanNumber(20);
            int expected1 = 0;

            int actual1 = n1.CompareTo(n1);
            int actual2 = n1.CompareTo(n2);

            Assert.AreNotEqual(expected1, actual2);
            Assert.AreEqual(expected1, actual1);
            Assert.ThrowsException<RomanNumberException>(() => n1.CompareTo(expected1));
        }
    }
}