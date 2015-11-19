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
			Console.WriteLine(@"___________________________________________________________________\n");
		}
		
		public void DrawLine(int length)
		{
			for (int i = 0; i < length; i++)
			{
				Console.Write("_");
			}
		}
		
		public void DrawClosedDoors()
		{
			Console.WriteLine(@"=============	=============	=============");
			Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	| Дверь №3  |");
			Console.WriteLine(@"|           |	|           |	|           |");
			Console.WriteLine(@"|           |	|           |	|           |");
			Console.WriteLine(@"|o          |	|o          |	|o          |");
			Console.WriteLine(@"|           |	|           |	|           |");
			Console.WriteLine(@"|           |	|           |	|           |");
			Console.WriteLine(@"|           |	|           |	|           |");
			Console.WriteLine(@"|           |	|           |	|           |");
			Console.WriteLine(@"=============	=============	=============");		
		}
		
		public void DrawSelectedDoors(string variant)
		{
			switch (variant)
			{
				case "1" :
				case "№1":
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	| Дверь №3  |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|o          |	|o          |	|o          |");
					Console.WriteLine(@"|    _  /   |	|           |	|           |");
					Console.WriteLine(@"|     \/    |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case "2" :
				case "№2":
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	| Дверь №3  |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|o          |	|o          |	|o          |");
					Console.WriteLine(@"|           |	|    _  /   |	|           |");
					Console.WriteLine(@"|           |	|     \/    |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case "3" :
				case "№3":
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	| Дверь №3  |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|o          |	|o          |	|o          |");
					Console.WriteLine(@"|           |	|           |	|   _  /    |");
					Console.WriteLine(@"|           |	|           |	|    \/     |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				default:
					break;
			}	
		}
		
		
		
	}
}