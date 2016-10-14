using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge4_Column;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.ConvertToColumnName(1), "A");
            Assert.AreEqual(Program.ConvertToColumnName(3), "C");
            Assert.AreEqual(Program.ConvertToColumnName(27), "AA");
            Assert.AreEqual(Program.ConvertToColumnName(123), "DS");
            Assert.AreEqual(Program.ConvertToColumnName(2730), "CZZ");
            Assert.AreEqual(Program.ConvertToColumnName(2731), "DAA");
            Assert.AreEqual(Program.ConvertToColumnName(2147483647), "FXSHRXW");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Program.ConvertToColumnNumber("A"), 1);
            Assert.AreEqual(Program.ConvertToColumnNumber("C"), 3);
            Assert.AreEqual(Program.ConvertToColumnNumber("AA"), 27);
            Assert.AreEqual(Program.ConvertToColumnNumber("DS"), 123);
            Assert.AreEqual(Program.ConvertToColumnNumber("CZZ"), 2730);
            Assert.AreEqual(Program.ConvertToColumnNumber("DAA"), 2731);
            Assert.AreEqual(Program.ConvertToColumnNumber("FXSHRXW"), 2147483647);
        }

    }
}
