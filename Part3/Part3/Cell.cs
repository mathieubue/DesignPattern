using System;
using System.Collections.Generic;
using System.Text;

namespace Part3
{
	public class Cell
	{
		private int value;
		private Cell next;

		public Cell(int value)
		{
			this.value = value;
			this.next = null;
		}

		public int Value
		{
			get { return this.value; }
			set { this.value = value; }
		}
		public Cell Next
		{
			get { return this.next; }
			set { this.next = value; }
		}
		public override string ToString()
		{
			return "Numero : " +  this.value.ToString();
		}
	}
}
