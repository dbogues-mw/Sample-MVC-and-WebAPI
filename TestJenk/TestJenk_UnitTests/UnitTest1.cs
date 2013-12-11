using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestJenk_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int x = 2 + 2;
            Assert.AreEqual(4, x);

        }
    }
}
