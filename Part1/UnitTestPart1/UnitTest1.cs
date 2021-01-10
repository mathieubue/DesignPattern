using Microsoft.VisualStudio.TestTools.UnitTesting;
using Part1;

namespace UnitTestPart1
{
    [TestClass]
    public class UnitTest1
    {
        private const string expected = "Hello";
        private const string expected2 = "7 8 9 10 ";
        [TestMethod]

        public void TestMethod1()
        {
            CustomQueue<string> myCustomQueue = new CustomQueue<string>();
            Node<string> root = new Node<string>("World");
            myCustomQueue.Enqueue(root);
            myCustomQueue.Enqueue(new Node<string>("Hello"));
            myCustomQueue.Dequeue();

            Assert.AreEqual(expected, myCustomQueue.Root.data);

        }
        [TestMethod]
        public void TestMethod2()
        {
            string result = "";
            CustomQueue<int> myCustomQueueInt = new CustomQueue<int>();
            Node<int> rootInt = new Node<int>(10);
            myCustomQueueInt.Enqueue(rootInt);
            myCustomQueueInt.Enqueue(new Node<int>(9));
            myCustomQueueInt.Enqueue(new Node<int>(8));
            myCustomQueueInt.Enqueue(new Node<int>(7));
            foreach(int s in myCustomQueueInt)
            {
                result = result +s +" ";
            } 
            Assert.AreEqual(expected2, result);
        }
    }
}
