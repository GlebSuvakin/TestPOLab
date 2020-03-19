using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Modules;

namespace Test1
{
    [TestClass]
    public class TestModuleNewMassLess
    {
        [DataTestMethod]
        [DataRow (7, true)]
        [DataRow(31, true)]
        [DataRow(8, false)]
        public void TestMethodIsSimple(int a, bool expected)
        {
            Assert.AreEqual(expected, NewMassLess.IsSimple(a));
        }

        [DataTestMethod]
        [DataRow(1009, true)]
        [DataRow(1013, true)]
        [DataRow(9533, false)]
        public void TestMethodIsLess(int b, bool expected)
        {
            Assert.AreEqual(expected, NewMassLess.IsLess(b));
        }
    }
}
