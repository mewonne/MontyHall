using System;
using System.IO;

namespace MontyHallGame
{
	class ConsoleGraphic
	{		
		public ConsoleGraphic()
		{
			
		}
		
		public void DrawLine()
		{
			Console.WriteLine("___________________________________________________________________");
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
			Console.WriteLine(@"|O          |	|O          |	|O          |");
			Console.WriteLine(@"|           |	|           |	|           |");
			Console.WriteLine(@"|           |	|           |	|           |");
			Console.WriteLine(@"|           |	|           |	|           |");
			Console.WriteLine(@"|           |	|           |	|           |");
			Console.WriteLine(@"=============	=============	=============");		
		}
		
		public void DrawSelectedDoors(int variant)
		{
			switch (variant)
			{
				case 1:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	| Дверь №3  |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|O          |	|O          |	|O          |");
					Console.WriteLine(@"|    _  /   |	|           |	|           |");
					Console.WriteLine(@"|     \/    |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case 2:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	| Дверь №3  |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|O          |	|O          |	|O          |");
					Console.WriteLine(@"|           |	|    _  /   |	|           |");
					Console.WriteLine(@"|           |	|     \/    |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case 3:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	| Дверь №3  |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|           |	|           |	|           |");
					Console.WriteLine(@"|O          |	|O          |	|O          |");
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
		
		public void DrawOpenDoors(int variant)
		{
			switch (variant)
			{
				case 1:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"|  Пустая / |	| Дверь №2  |	| Дверь №3  |");
					Console.WriteLine(@"| Дверь №1| |	|           |	|           |");
					Console.WriteLine(@"|         | |	|           |	|           |");
					Console.WriteLine(@"|         |o|	|O          |	|O          |");
					Console.WriteLine(@"|  Открыта| |	|           |	|           |");
					Console.WriteLine(@"|         | |	|           |	|           |");
					Console.WriteLine(@"|         | |	|           |	|           |");
					Console.WriteLine(@"|         \ |	|           |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case 2:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	|  Пустая / |	| Дверь №3  |");
					Console.WriteLine(@"|           |	| Дверь №2| |	|           |");
					Console.WriteLine(@"|           |	|         | |	|           |");
					Console.WriteLine(@"|O          |	|         |o|	|O          |");
					Console.WriteLine(@"|           |	|  Открыта| |	|           |");
					Console.WriteLine(@"|           |	|         | |	|           |");
					Console.WriteLine(@"|           |	|         | |	|           |");
					Console.WriteLine(@"|           |	|         \ |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case 3:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	|  Пустая / |");
					Console.WriteLine(@"|           |	|           |	| Дверь №3| |");
					Console.WriteLine(@"|           |	|           |	|         | |");
					Console.WriteLine(@"|O          |	|O          |	|         |o|");
					Console.WriteLine(@"|           |	|           |	|  Открыта| |");
					Console.WriteLine(@"|           |	|           |	|         | |");
					Console.WriteLine(@"|           |	|           |	|         | |");
					Console.WriteLine(@"|           |	|           |	|         \ |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				default:
					break;
			}	
		}
		
	}
}