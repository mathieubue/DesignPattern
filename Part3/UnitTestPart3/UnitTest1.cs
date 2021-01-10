using Microsoft.VisualStudio.TestTools.UnitTesting;
using Part3;

namespace UnitTestPart3
{
    [TestClass]
    public class UnitTest1
    {
        private const int expected = 6;
        const int expected2 = 10;

        [TestMethod]
        public void TestMethod1()
        {

            Board b = BoardFactory.CreateBoard();
            b.Start = b.initBoard();

            Player player1 = playerFactory.CreatePlayer("player1", b.Start, b);

            player1.Move(6);


            Assert.AreEqual(expected, player1.location.Value);
        }

        [TestMethod]
        public void TestMethod2()
        {

            Board b = BoardFactory.CreateBoard();
            b.Start = b.initBoard();

            Player player1 = playerFactory.CreatePlayer("player1", b.Start, b);

            Cell test = player1.getJail();


            Assert.AreEqual(expected2, test.Value);
        }
    }
}
