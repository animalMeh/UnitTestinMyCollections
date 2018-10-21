using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollections;

namespace BracketsTest
{
    [TestClass]
    public class BracketTest
    {
        [TestMethod]
        public void TestStackUse1()
        {
            // expected | what needs test
            Assert.AreEqual(true, StackUsing.CheckBKT("([{}])()[]<[()]>"));
        }

        [TestMethod]
        public void TestStackUse2()
        {
            Assert.AreEqual(true, StackUsing.CheckBKT("(да-да, я )"));
        }
    }
}
