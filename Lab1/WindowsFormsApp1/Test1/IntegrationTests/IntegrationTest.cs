using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WindowsFormsApp1.Modules;

namespace Test1.IntegrationTests
{
    [TestClass]
    public class IntegrationTest
    {
        [DataTestMethod]
        [DataRow(new int[] { 1009, 1013, 1019, 9533 }, 3)]
        [DataRow(new int[] { 1009, 9533 }, 1)]
        [DataRow(new int[] { 1031, 1033, 1039, 1049, 1051, 9533 }, 3)]

        public void TestNewMassLess(int[] intArr, int expected)
        {
            int count = 0;
            foreach(int num in intArr)
            {
                if(NewMassMore.IsSimple(num) && NewMassLess.IsLess(num))
                {
                    count++;
                }
            }
            Assert.AreEqual(expected, count);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1009, 1013, 1019, 9533 }, 1)]
        [DataRow(new int[] { 1009, 9533 }, 1)]
        [DataRow(new int[] { 1031, 1033, 1039, 1049, 1051 }, 0)]
        public void TestNewMassMore(int[] intArr, int expected)
        {
            int count = 0;
            foreach (int num in intArr)
            {
                if (NewMassLess.IsSimple(num) && NewMassMore.IsMore(num))
                {
                    count++;
                }
            }
            Assert.AreEqual(expected, count);
        }
    }

}
