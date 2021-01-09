using System;
using System.Collections.Generic;
using System.Text;

namespace Part3
{
	class BoardFactory
	{
		public static Board CreateBoard()
		{
			return new Board();
		}
	}
}
