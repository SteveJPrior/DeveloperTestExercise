using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;

namespace FileData.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void MainNoArgs()
        {
            var ret = Program.Main(new string[0]);
            Assert.AreEqual(1, ret);
        }

        [TestMethod]
        public void MainVersion()
        {
            var ret = Program.Main(new [] { "-v", "file1"});
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void MainSize()
        {
            var ret = Program.Main(new [] { "-s", "file1"});
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void MainBadArgs()
        {
            var ret = Program.Main(new [] { "x", "file1"});
            Assert.AreEqual(2, ret);
        }
    }
}