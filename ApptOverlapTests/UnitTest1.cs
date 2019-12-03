using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApptOverlap;

namespace ApptOverlapTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PublicTest1()
        {
            bool result = Program.isOverlapping(1, 2, 2, 4);

            Assert.AreEqual(System.Convert.ToBoolean(0), result);
        }

        [TestMethod]
        public void PublicTest2()
        {
            bool result = Program.isOverlapping(1, 3, 2, 4);

            Assert.AreEqual(System.Convert.ToBoolean(1), result);
        }

        [TestMethod]
        public void PrivateTest1()
        {
            bool result = Program.isOverlapping(1, 2, 1, 2);

            Assert.AreEqual(System.Convert.ToBoolean(1), result);
        }

        [TestMethod]
        public void PrivateTest2()
        {
            bool result = Program.isOverlapping(1, 2, 1, 3);

            Assert.AreEqual(System.Convert.ToBoolean(1), result);
        }

        [TestMethod]
        public void PrivateTest3()
        {
            bool result = Program.isOverlapping(1, 3, 2, 3);

            Assert.AreEqual(System.Convert.ToBoolean(1), result);
        }

        [TestMethod]
        public void PrivateTest4()
        {
            bool result = Program.isOverlapping(1, 4, 2, 3);

            Assert.AreEqual(System.Convert.ToBoolean(1), result);
        }

        [TestMethod]
        public void PrivateTest5()
        {
            bool result = Program.isOverlapping(2, 3, 1, 4);

            Assert.AreEqual(System.Convert.ToBoolean(1), result);
        }

        [TestMethod]
        public void PrivateTest6()
        {
            bool result = Program.isOverlapping(2, 4, 1, 2);

            Assert.AreEqual(System.Convert.ToBoolean(0), result);
        }

        [TestMethod]
        public void PrivateTest7()
        {
            bool result = Program.isOverlapping(2, 4, 1, 3);

            Assert.AreEqual(System.Convert.ToBoolean(1), result);
        }

        [TestMethod]
        public void PrivateTest8()
        {
            bool result = Program.isOverlapping(3, 4, 5, 6);

            Assert.AreEqual(System.Convert.ToBoolean(0), result);
        }
    }
}
