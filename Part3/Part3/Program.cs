using System;

namespace Part3
{
	public class Program
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
			Board b = BoardFactory.CreateBoard();
			b.Start = b.initBoard();
			//printBoard(b);
			// affiche toutes les cases du board

			Player player1 = playerFactory.CreatePlayer("player1", b.Start,b);
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
