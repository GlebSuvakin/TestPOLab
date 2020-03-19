using System;

using WindowsFormsApp1.Modules;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1

{
    [TestClass]
    public class TestModuleCheck
    {
        [DataTestMethod]
        [DataRow(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, true)]
        [DataRow(new int[] { 9, 8, 7, 6 }, false)]
        [DataRow(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12 }, false)]
        public void TestMethodCheckArrayDimension(int[] arr, bool expected)
        {
            Assert.AreEqual(expected, Check.CheckArrayDimension(arr));
        }

        [DataTestMethod]
        [DataRow(new int[] { 97, 8, 7, 6356 }, false)]
        [DataRow(new int[] { 95678, 8, 7, 6 }, false)]
        [DataRow(new int[] { 1009, 1013, 1019, 1021, }, true)]
        public void TestMethodCheckCapacity(int[] arr, bool expected)
        {
            Assert.AreEqual(expected, Check.CheckCapacity(arr));
        }

        [DataTestMethod]
        [DataRow(new int[] { 9, 8, 7, 6 }, true)]
        [DataRow(new int[] { 9, 8, -7, 6 }, false)]
        public void TestMethodCheckPositiveNumber(int[] arr, bool expected)
        {
            Assert.AreEqual(expected, Check.CheckPositiveNumber(arr));
        }
    }
}
