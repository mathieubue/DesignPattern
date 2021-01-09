using System;

namespace Part1
{
	class Program
	{
		static void Main(string[] args)
		{
			//string
			CustomQueue<string> myCustomQueue = new CustomQueue<string>();
			Node<string> root = new Node<string>("World");
			myCustomQueue.Enqueue(root);
			myCustomQueue.Enqueue(new Node<string>("Hello"));
			Console.WriteLine("----------------");
			foreach(string s in myCustomQueue)
			{
				Console.WriteLine(s);
			}
			Console.WriteLine("----------------");
			Console.WriteLine(myCustomQueue.ToString());
			myCustomQueue.Dequeue();
			Console.WriteLine(myCustomQueue.ToString());
			myCustomQueue.Dequeue();
			myCustomQueue.Dequeue();
			Console.WriteLine(myCustomQueue.ToString());
			//int
			CustomQueue<int> myCustomQueueInt = new CustomQueue<int>();
			Node<int> rootInt = new Node<int>(10);
			myCustomQueueInt.Enqueue(rootInt);
			myCustomQueueInt.Enqueue(new Node<int>(9));
			myCustomQueueInt.Enqueue(new Node<int>(8));
			myCustomQueueInt.Enqueue(new Node<int>(7));
			Console.WriteLine("----------------");
			foreach (int i in myCustomQueueInt)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("----------------");
			Console.WriteLine(myCustomQueueInt.ToString());
			myCustomQueueInt.Dequeue();
			Console.WriteLine(myCustomQueueInt.ToString());
			myCustomQueueInt.Dequeue();
			Console.WriteLine(myCustomQueueInt.ToString());

			Console.ReadLine();
		}
	}
}
