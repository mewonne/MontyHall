using System;

namespace MontyHallGame
{
	class MontyHall
	{
		public MontyHall()
		{
			
		}	
		
		public override string ToString()
		{
			return "Monty Hall's paradox";
		} 
		
		public void Start()
		{
			Console.WriteLine("This is Monty Hall's paradox. The Monty Hall problem is a brain teaser.");
			Console.WriteLine("Suppose you're on a game show, and you're given the choice of three doors:\n" + 
							  "Behind one door is a car; behind the others, goats.\n"+
							  "You pick a door, say No. 1, and the host, who knows what's behind the doors,\n" + 
							  "opens another door, say No. 3, " + 
							  "which has a goat.\n" + 
							  "He then says to you, Do you want to pick door No. 2?\n" + 
							  "Is it to your advantage to switch your choice?");
		}
	}
}