using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Solution s = new Solution();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, s.Testnum(1));
        }
    }
}
