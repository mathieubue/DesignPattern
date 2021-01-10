using Microsoft.VisualStudio.TestTools.UnitTesting;
using Part2;
using System.Collections.Generic;

namespace UnitTestPart2
{
    [TestClass]
    public class UnitTest1
    {

        private const int expected = 2;
        private const int expected2 = 1;
        [TestMethod]
        public void TestMethod1()
        {
            IDictionary<string, int> words = new Dictionary<string, int>();
            words.Add("test", 1);

            Part2.Program.Map(words, "test");

            Assert.AreEqual(expected, words["test"]);


        }

        [TestMethod]
        public void TestMethod2()
        {
            IDictionary<string, int> words = new Dictionary<string, int>();

            Part2.Program.Map(words, "test2");

            Assert.AreEqual(expected2, words["test2"]);


        }
    }
}
