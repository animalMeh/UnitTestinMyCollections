using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollections;

namespace BracketsTest
{
    [TestClass]
    public class BracketTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // expected | what needs test
            Assert.AreEqual(true, StackUsing.CheckBKT("([{}])()[]<[()]>"));
        }
    }
}
