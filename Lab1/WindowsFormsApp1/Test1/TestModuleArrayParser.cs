using System;

using WindowsFormsApp1.Modules;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1
{
    public class TestModuleArrayParser
    {
        [TestMethod]
        public void TestMethodStrToArr()
        {
            CollectionAssert.AreEqual(new string[] { "123", "45", "6", "789", "3" }, ArrayParser.StrToArr("123 45 6 789 3"));
            CollectionAssert.AreEqual(new string[] { "1", "2", "3", "4", "5" }, ArrayParser.StrToArr("1 2 3 4 5"));
        }
        [DataTestMethod]
        [DataRow("123", true)]
        [DataRow("12d3", false)]
        [DataRow("12пр3", false)]
        [DataRow("12!&?#3", false)]
        public void TestMethodIsNumberContains(string str, bool expected)
        {
            Assert.AreEqual(expected, ArrayParser.IsNumberContains(str));
        }

        [TestMethod]
        public void TestMethodStrArrToIntArr()
        {
            CollectionAssert.AreEqual(new int[] { 123, 45, 6, 789, 3 }, ArrayParser.StrArrToIntArr(new string[] { "123", "45", "6", "789", "3" }));
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, ArrayParser.StrArrToIntArr(new string[] { "1", "2", "3", "4", "5" }));
        }
    }
}
