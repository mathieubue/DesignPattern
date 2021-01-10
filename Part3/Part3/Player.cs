using System;
using System.Collections.Generic;
using System.Text;

namespace Part3
{
	public class Player
	{
		private string name;
		private bool jail;
		public Cell location;
		private Board board;
		private int count = 0;

		public Player(string name, Cell location,Board board)
		{
			this.name = name;
			this.location = location;
			this.jail = false;
			this.board = board;
		}
		
		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}
		public Cell Location
		{
			get { return this.location; }
			set { this.location = value; }
		}
		public bool Jail
		{
			get { return this.jail; }
			set { this.jail = value; }
		}
		public Board Board
		{
			get { return this.board; }
			set { this.board = value; }
		}

		protected int[] Roll()
		{
			Random rnd = new Random();
			int dice1 = rnd.Next(1, 7);
			int dice2 = rnd.Next(1, 7);
			int[] results = new int[] { dice1, dice2 };
			Console.WriteLine("Roll : " + dice1 + " | " + dice2);
			return results;
		}
		public Cell Move(int number)
		{
			int move = number;
			while(move>0)
			{
				this.location = location.Next;
				move--;
			}
			return this.location;
		}

		public Cell getJail()
		{
			Cell current = this.board.Start;
			int i = 0;
			while(i<10)
			{
				current = current.Next;
				i++;
			}
			return current;
		}
		protected void NotifyJailObsrver()
		{
			JailObserver.Update();
		}
		public void Play()
		{
			Cell Start = this.location;


			if(this.jail == false)
			{ 
				//Roll 1
				int[] roll = this.Roll();
				this.location = this.Move(roll[0] + roll[1]);
				//Check Jail
				if (this.location.Value == 30)
				{
					this.NotifyJailObsrver();
					this.location = this.getJail();
					this.jail = true;
				}


				// double ? - Rool 1
				else if (roll[0]==roll[1])
				{
					//Roll 2
					roll = this.Roll();
					this.location = this.Move(roll[0] + roll[1]);
					//Check Jail
					if (this.location.Value == 30)
					{
						this.NotifyJailObsrver();
						this.location = this.getJail();
						this.jail = true;
					}



					//double ? - Roll 2 
					else if (roll[0] == roll[1])
					{
						//Roll 3 
						roll = this.Roll();
						//double - Roll 3
						if(roll[0] == roll[1])
						{
							this.NotifyJailObsrver();
							this.location = this.getJail();
							this.jail = true;
						}
						else
						{
							this.location = this.Move(roll[0] + roll[1]);
							//Check Jail
							if (this.location.Value == 30)
							{
								this.NotifyJailObsrver();
								this.location = this.getJail();
								this.jail = true;
							}
						}
					}
					
				}
			}
			else
			{
				int[] roll = this.Roll();
				if(this.count == 3)
				{
					this.Move(roll[0] + roll[1]);
					this.count = 0;
					this.jail = false;
				}
				else if(roll[0]==roll[1])
				{
					this.Move(roll[0] + roll[1]);
					this.count = 0;
					this.jail = false;
				}
				else
				{
					this.count++;
				}
			}
			//print
			Console.WriteLine("Start :" + Start.ToString() + "\nCurrent Position : " + this.location.ToString());
		}
	}
}
