using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QLDL;

namespace LoginTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoginUser1()
        {
            bool expected, actual;
            frmLogin f = new frmLogin();
            expected = true;
            actual = f.checkAccount("tranhoangquangdin", "0123456");
            Assert.AreEqual(expected,actual);
        }
    }
}
