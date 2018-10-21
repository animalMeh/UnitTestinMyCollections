using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollections;

namespace BracketsTest
{
    [TestClass]
    public class BracketTest
    {
        [TestMethod]
        public void TestStackUseManyBrackets()
        {
            // expected | what needs test
            Assert.AreEqual(true, StackUsing.CheckBKT("([{}])()[]<[()]>"));
        }

        [TestMethod]
        public void TestStackUseWordInsideBrackets()
        {
            Assert.AreEqual(true, StackUsing.CheckBKT("(да-да, я )"));
        }

        [TestMethod]
        public void TestStackWordsInsideManyBrackets()
        {
            Assert.AreEqual(true, StackUsing.CheckBKT("{array[5] arr = new array(10)}"));
        }

        [TestMethod]
        public void TestFailWrongBrackets()
        {
            Assert.AreEqual(false, StackUsing.CheckBKT("))()"));
        }

        [TestMethod]
        public void TestEmptyString()
        {
            Assert.AreEqual(true, StackUsing.CheckBKT(""));
        }
        [TestMethod]
        public void TestWithoutBrackets()
        {
            Assert.AreEqual(true, StackUsing.CheckBKT("alksdlasdl"));
        }

        [TestMethod]
        void TestSummary()
        {
            Assert.AreEqual(7, StackUsing.ComputeFromPolis_Int32("2+5"));
        }

        [TestMethod]
        void TestMultyply()
        {
            Assert.AreEqual(6, StackUsing.ComputeFromPolis_Int32("2*3"));
        }

        [TestMethod]
        void TestSumAndMul()
        {
            Assert.AreEqual(25, "23+5*");
        }

    }
    
}
