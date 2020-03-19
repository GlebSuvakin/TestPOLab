using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1.Modules;

namespace Test1
{
    [TestClass]
    public class TestModuleNewMassMore
    {
        [DataTestMethod]
        [DataRow(1009, false)]
        [DataRow(1013, false)]
        [DataRow(9533, true)]
        public void TestMethodIsMore(int b, bool expected)
        {
            Assert.AreEqual(expected, NewMassMore.IsMore(b));
        }
    }
}
    