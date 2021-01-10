using System;
using System.Collections.Generic;
using System.Text;

namespace Part3
{
	public class Board
	{
		private Cell start;

		public Board()
		{
			this.start = null;
		}

		public Cell Start
		{
			get { return this.start; }
			set { this.start = value; }
		}


		
		public Cell initBoard()
		{
			this.start = new Cell(0);
			Cell curr = this.start;
			int i = 1;
			while(i<40)
			{
				Cell nextcell = new Cell(i);
				curr.Next = nextcell;
				curr = curr.Next;
				i++;
			}
			curr.Next = this.start;
			return this.start;
		}
	}
}
