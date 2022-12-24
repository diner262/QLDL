using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLDL;
using System;

namespace UnitTestLogin
{
    [TestClass]
    public class UnitTest1
    {
        private frmLogin f;
        [TestInitialize]
        public void setUp()
        {
            f = new frmLogin();
        }

        [TestMethod]
        public void TestLoginAccount1()
        {
            bool expected, actual;
            expected = true;
            actual = f.checkAccount("tranhoangquangdin", "0123456");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginAccount2()
        {
            bool expected, actual;
            expected = true;
            actual = f.checkAccount("tranhoangquangdin", "0123456");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginAccount3()
        {
            bool expected, actual;
            expected = true;
            actual = f.checkAccount("hoanglydieu", "abcdef");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginAccount4()
        {
            bool expected, actual;
            expected = true;
            actual = f.checkAccount("doanphuongnam", "987654");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginAccount5()
        {
            bool expected, actual;
            expected = true;
            actual = f.checkAccount("truongthingantram", "123321");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginAccount6()
        {
            bool expected, actual;
            expected = true;
            actual = f.checkAccount("admin", "123456");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginAccount7()
        {
            bool expected, actual;
            expected = true;
            actual = f.checkAccount("tranhongngoc", "39393912");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoginAccount8()
        {
            bool expected, actual;
            expected = true;
            actual = f.checkAccount("nguyenvanhau", "qwer1234");
            Assert.AreEqual(expected, actual);
        }
    }
}
