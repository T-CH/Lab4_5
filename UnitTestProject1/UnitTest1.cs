using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application_;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 //test encoder
    {
        Entry entry = new Entry();
        Encoder encod = new Encoder();

        [TestMethod]
        public void TestMethod1()
        {
            string s1 = "1";
            entry.create(s1, s1, s1);
            encod.encode(entry,7);
            string s2 = "8";
            Assert.AreEqual(s2, entry.key);
            Assert.AreEqual(s1, entry.login);
            Assert.AreEqual(s2, entry.comment);
        }

        [TestMethod]
        public void TestMethod_decod()
        {
            string s1 = "8";
            entry.create(s1, s1, s1);
            encod.decode(entry,7);
            string s2 = "1";
            Assert.AreEqual(s2, entry.key);
            Assert.AreEqual(s1, entry.login);
            Assert.AreEqual(s2, entry.comment);
        }
    }

    [TestClass]
    public class EntryTest
    {
        Entry entry = new Entry();
        [TestMethod]
        public void TestMethodcreate()
        {
            string s1 = "a";
            string s2 = "b";
            string s3 = "c";
            entry.create(s1, s2, s3);
            Assert.AreEqual(s1, entry.key);
            Assert.AreEqual(s2, entry.login);
            Assert.AreEqual(s3, entry.comment);
        }

    }

    [TestClass]
    public class MasterKeyTest
    {
        Master_key m_key = new Master_key();
        [TestMethod]
        public void TestMethod_control()
        {
            string s1 = "123";
            Assert.IsTrue(m_key.control(s1, s1));
        }
    }

}

