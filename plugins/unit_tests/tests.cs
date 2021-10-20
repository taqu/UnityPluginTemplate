using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    [TestClass]
    public class TestPlugin00
    {
        [TestInitialize()]
        public void Startup()
        {
        }

        [TestCleanup()]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void TestMethod00()
        {
            Assert.AreEqual(4200, Plugin00.Plugin00.get_value());
        }
    }

    [TestClass]
    public class TestPlugin01
    {
        [TestInitialize()]
        public void Startup()
        {
        }

        [TestCleanup()]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void TestMethod00()
        {
            Assert.AreEqual(4201, Plugin01.Plugin01.get_value());
        }
    }
}