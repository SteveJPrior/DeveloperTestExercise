using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;

namespace FileData.Tests
{   
    [TestClass]
    public class MainArgParserTest
    {
        private MainArgParser _parser;

        [TestInitialize]
        public void Init()
        {
            _parser = new MainArgParser();
        }

        [TestMethod]
        public void FileVersion()
        {
            var b = _parser.IsVersion("-v");
            Assert.IsTrue(b);
        }

        // TODO other version args

        [TestMethod]
        public void FileSize()
        {
            var b = _parser.IsSize("-s");
            Assert.IsTrue(b);
        }

        // TODO other size args

        [TestMethod]
        public void NotRecognised()
        {
            var b = _parser.IsVersion("x");
            Assert.IsFalse(b);
            b = _parser.IsSize("x");
            Assert.IsFalse(b);
        }
    }
}