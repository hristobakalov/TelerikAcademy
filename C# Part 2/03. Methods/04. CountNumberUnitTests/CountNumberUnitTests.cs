using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.CountNumberUnitTests
{
    [TestClass]
    public class CountNumberUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = {1,5,6,846,324,3,4,6,6,};
            int result = CountNumberInArray.CountNumber(array, 6);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] array = { 1,1,1,1,1, 5, 6, 846,1,1,1,111, 324, 3, 4, 6, 6, };
            int result = CountNumberInArray.CountNumber(array, 1);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] array = { 1, 5, 6, 846, 324, 3, 4, 6, 6,123213,2131231,34535 };
            int result = CountNumberInArray.CountNumber(array, 1323);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] array = {0, 1, 5, 6, 846, 324, 3, 4, 6, 6, 0};
            int result = CountNumberInArray.CountNumber(array, 0);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] array = { 1, 5, 6, 846, 324, 3, 4, 6, 6, };
            int result = CountNumberInArray.CountNumber(array, 324);
            Assert.AreEqual(1, result);
        }
    }
}
