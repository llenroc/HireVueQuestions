using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams;
using System.Collections.Generic;

namespace AnagramsTests
{
    [TestClass]
    public class UnitTest1
    {
        private bool IsMatch(List<string> list1, List<string> list2)
        {
            bool isMatch = false;

            if(list1.Count == list2.Count)
            {
                for(int i = 0; i < list1.Count; i++)
                {
                    if(!list1[i].Equals(list2[i])) { break; }
                }

                isMatch = true;
            }

            return isMatch;
        }

        [TestMethod]
        public void PublicTest0()
        {
            List<string> stringList = new List<string>() { "code", "doce", "ecod", "framer", "frame" };
            List<string> desiredStringList = new List<string>() { "code", "frame", "framer" };

            //get result
            List<string> results = Program.funWithAnagrams(stringList);

            //test result
            Assert.IsTrue(IsMatch(desiredStringList, results));
        }

        [TestMethod]
        public void PublicTest1()
        {
            List<string> stringList = new List<string>() { "poke", "pkoe", "okpe", "ekop" };
            List<string> desiredStringList = new List<string>() { "poke" };

            //get result
            List<string> results = Program.funWithAnagrams(stringList);

            //test result
            Assert.IsTrue(IsMatch(desiredStringList, results));
        }

        [TestMethod]
        public void PublicTest2()
        {
            List<string> stringList = new List<string>() { "code", "aaagmnrs", "anagrams", "doce" };
            List<string> desiredStringList = new List<string>() { "aaagmnrs", "code" };

            //get result
            List<string> results = Program.funWithAnagrams(stringList);

            //test result
            Assert.IsTrue(IsMatch(desiredStringList, results));
        }

        [TestMethod]
        public void PrivateTest1()
        {
            List<string> stringList = new List<string>() { "aaa", "bbb", "ccc" };
            List<string> desiredStringList = new List<string>() { "aaa", "bbb", "ccc" };

            //get result
            List<string> results = Program.funWithAnagrams(stringList);

            //test result
            Assert.IsTrue(IsMatch(desiredStringList, results));
        }
    }
}
