using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeedleHaystack;
using System.Collections.Generic;

namespace NeedleHaystackTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PublicTest1()
        {
            //init input
            List<string> haystack = new List<string>() {"apple", "banana","pear"};
            List<string> needle = new List<string>() { "banana", "pear" };

            //get result
            int result = Program.findSequence(haystack, needle);

            //test result
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void PublicTest2()
        {
            //init input
            List<string> haystack = new List<string>() { "apple", "banana", "pear" };
            List<string> needle = new List<string>() { "four", "five" };

            //get result
            int result = Program.findSequence(haystack, needle);

            //test result
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void PrivateTest1()
        {
            //init input
            List<string> haystack = new List<string>();
            List<string> needle = new List<string>();

            //get result
            int result = Program.findSequence(haystack, needle);

            //test result
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void PrivateTest2()
        {
            //init input
            List<string> haystack = new List<string>();
            List<string> needle = new List<string>() { "apple" };

            //get result
            int result = Program.findSequence(haystack, needle);

            //test result
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void PrivateTest3()
        {
            //init input
            List<string> haystack = new List<string>() { "apple", "banana", "pear" };
            List<string> needle = new List<string>();

            //get result
            int result = Program.findSequence(haystack, needle);

            //test result
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void PrivateTest4()
        {
            //init input
            List<string> haystack = new List<string>() { "apple", "banana", "pear" };
            List<string> needle = new List<string>() { "apple" };

            //get result
            int result = Program.findSequence(haystack, needle);

            //test result
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void PrivateTest5()
        {
            //init input
            List<string> haystack = new List<string>() { "apple", "banana", "pear" };
            List<string> needle = new List<string>() { "apple", "pear" };

            //get result
            int result = Program.findSequence(haystack, needle);

            //test result
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void PrivateTest6()
        {
            //init input
            List<string> haystack = new List<string>() { "eleven","twelve","thirteen",
                "thirteen","fourteen","fifteen","sixteen" };
            List<string> needle = new List<string>() { "thirteen", "fourteen", "fifteen" };

            //get result
            int result = Program.findSequence(haystack, needle);

            //test result
            Assert.AreEqual(3, result);
        }
    }
}
