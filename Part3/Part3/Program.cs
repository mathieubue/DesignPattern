using System;

namespace Part3
{
	class Program
	{
		public static void printBoard(Board b)
		{
			Cell curr = b.Start;
			int i = 0;
			while(i<41)
			{
				Console.WriteLine(curr.ToString());
				curr = curr.Next;
				i++;
			}
		}
		static void Main(string[] args)
		{
			Board b = new Board();
			b.Start = b.initBoard();
			printBoard(b);
			Console.WriteLine(b.Start.ToString());

			Player player1 = new Player("player1", b.Start,b);
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();
			player1.Play();


			Console.ReadLine();
		}
	}
}
