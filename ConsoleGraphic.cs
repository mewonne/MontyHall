using System;

namespace MontyHallGame
{
	class ConsoleGraphic
	{
		public ConsoleGraphic()
		{
			
		}
		
		public void DrawLine()
		{
			Console.WriteLine("___________________________________________________________________\n");
		}
		
		public void DrawLine(int length)
		{
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine("_");
			}
		}
		
	}
}