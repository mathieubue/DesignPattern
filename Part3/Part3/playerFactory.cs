using System;
using System.Collections.Generic;
using System.Text;

namespace Part3
{
	public class playerFactory
	{
		public static Player CreatePlayer(string name, Cell location, Board board )
		{
			return new Player(name, location,board);
		}
	}
}
