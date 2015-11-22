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
			Console.WriteLine("-------------------------------------------------------------------");
		}
		
		public void DrawLine(int length)
		{
			for (int i = 0; i < length; i++)
			{
				Console.Write("-");
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
					Console.WriteLine(@"|           |	|           |	|    _  /   |");
					Console.WriteLine(@"|           |	|           |	|     \/    |");
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
					Console.WriteLine(@"| Дверь №1/ |	| Дверь №2  |	| Дверь №3  |");
					Console.WriteLine(@"|         | |	|           |	|           |");
					Console.WriteLine(@"|         | |	|           |	|           |");
					Console.WriteLine(@"|         |o|	|O          |	|O          |");
					Console.WriteLine(@"| Открыта | |	|           |	|           |");
					Console.WriteLine(@"|         | |	|           |	|           |");
					Console.WriteLine(@"|  Пусто  | |	|           |	|           |");
					Console.WriteLine(@"|         \ |	|           |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case 2:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2/ |	| Дверь №3  |");
					Console.WriteLine(@"|           |	|         | |	|           |");
					Console.WriteLine(@"|           |	|         | |	|           |");
					Console.WriteLine(@"|O          |	|         |o|	|O          |");
					Console.WriteLine(@"|           |	| Открыта | |	|           |");
					Console.WriteLine(@"|           |	|         | |	|           |");
					Console.WriteLine(@"|           |	|  Пусто  | |	|           |");
					Console.WriteLine(@"|           |	|         \ |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case 3:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	| Дверь №3/ |");
					Console.WriteLine(@"|           |	|           |	|         | |");
					Console.WriteLine(@"|           |	|           |	|         | |");
					Console.WriteLine(@"|O          |	|O          |	|         |o|");
					Console.WriteLine(@"|           |	|           |	| Открыта | |");
					Console.WriteLine(@"|           |	|           |	|         | |");
					Console.WriteLine(@"|           |	|           |	|  Пусто  | |");
					Console.WriteLine(@"|           |	|           |	|         \ |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				default:
					break;
			}	
		}
		
		public void DrawOpenAndSelectedDoors(int nOpen, int nSelected)
		{
			var variant = nOpen.ToString() + nSelected.ToString(); 
			switch (variant)
			{
				case "12":
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1/ |	| Дверь №2  |	| Дверь №3  |");
					Console.WriteLine(@"|         | |	|           |	|           |");
					Console.WriteLine(@"|         | |	|           |	|           |");
					Console.WriteLine(@"|         |o|	|O          |	|O          |");
					Console.WriteLine(@"| Открыта | |	|    _  /   |	|           |");
					Console.WriteLine(@"|         | |	|     \/    |	|           |");
					Console.WriteLine(@"|  Пусто  | |	|           |	|           |");
					Console.WriteLine(@"|         \ |	|           |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case "13":
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1/ |	| Дверь №2  |	| Дверь №3  |");
					Console.WriteLine(@"|         | |	|           |	|           |");
					Console.WriteLine(@"|         | |	|           |	|           |");
					Console.WriteLine(@"|         |o|	|O          |	|O          |");
					Console.WriteLine(@"| Открыта | |	|           |	|    _  /   |");
					Console.WriteLine(@"|         | |	|           |	|     \/    |");
					Console.WriteLine(@"|  Пусто  | |	|           |	|           |");
					Console.WriteLine(@"|         \ |	|           |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case "21":
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2/ |	| Дверь №3  |");
					Console.WriteLine(@"|           |	|         | |	|           |");
					Console.WriteLine(@"|           |	|         | |	|           |");
					Console.WriteLine(@"|O          |	|         |o|	|O          |");
					Console.WriteLine(@"|    _  /   |	| Открыта | |	|           |");
					Console.WriteLine(@"|     \/    |	|         | |	|           |");
					Console.WriteLine(@"|           |	|  Пусто  | |	|           |");
					Console.WriteLine(@"|           |	|         \ |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case "23":
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2/ |	| Дверь №3  |");
					Console.WriteLine(@"|           |	|         | |	|           |");
					Console.WriteLine(@"|           |	|         | |	|           |");
					Console.WriteLine(@"|O          |	|         |o|	|O          |");
					Console.WriteLine(@"|           |	| Открыта | |	|    _  /   |");
					Console.WriteLine(@"|           |	|         | |	|     \/    |");
					Console.WriteLine(@"|           |	|  Пусто  | |	|           |");
					Console.WriteLine(@"|           |	|         \ |	|           |");
					Console.WriteLine(@"=============	=============	=============");
					break; 
				case "31":
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	| Дверь №3/ |");
					Console.WriteLine(@"|           |	|           |	|         | |");
					Console.WriteLine(@"|           |	|           |	|         | |");
					Console.WriteLine(@"|O          |	|O          |	|         |o|");
					Console.WriteLine(@"|    _  /   |	|           |	| Открыта | |");
					Console.WriteLine(@"|     \/    |	|           |	|         | |");
					Console.WriteLine(@"|           |	|           |	|  Пусто  | |");
					Console.WriteLine(@"|           |	|           |	|         \ |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case "32":
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1  |	| Дверь №2  |	| Дверь №3/ |");
					Console.WriteLine(@"|           |	|           |	|         | |");
					Console.WriteLine(@"|           |	|           |	|         | |");
					Console.WriteLine(@"|O          |	|O          |	|         |o|");
					Console.WriteLine(@"|           |	|    _  /   |	| Открыта | |");
					Console.WriteLine(@"|           |	|     \/    |	|         | |");
					Console.WriteLine(@"|           |	|           |	|  Пусто  | |");
					Console.WriteLine(@"|           |	|           |	|         \ |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				default:
					break;
			}	
		}
		
		public void DrawPrizeDoors(int variant)
		{
			switch (variant)
			{
				case 1:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1/ |	| Дверь №2/ |	| Дверь №3/ |");
					Console.WriteLine(@"|         | |	|         | |	|         | |");
					Console.WriteLine(@"|         | |	|         | |	|         | |");
					Console.WriteLine(@"|         |o|	|         |o|	|         |o|");
					Console.WriteLine(@"| Открыта | |	| Открыта | |	| Открыта | |");
					Console.WriteLine(@"|   ____  | |	|         | |	|         | |");
					Console.WriteLine(@"|  |ПРИЗ| | |	|  Пусто  | |	|  Пусто  | |");
					Console.WriteLine(@"|  |____| \ |	|         \ |	|         \ |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case 2:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1/ |	| Дверь №2/ |	| Дверь №3/ |");
					Console.WriteLine(@"|         | |	|         | |	|         | |");
					Console.WriteLine(@"|         | |	|         | |	|         | |");
					Console.WriteLine(@"|         |o|	|         |o|	|         |o|");
					Console.WriteLine(@"| Открыта | |	| Открыта | |	| Открыта | |");
					Console.WriteLine(@"|         | |	|   ____  | |	|         | |");
					Console.WriteLine(@"|  Пусто  | |	|  |ПРИЗ| | |	|  Пусто  | |");
					Console.WriteLine(@"|         \ |	|  |____| \ |	|         \ |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				case 3:
					Console.WriteLine(@"=============	=============	=============");
					Console.WriteLine(@"| Дверь №1/ |	| Дверь №2/ |	| Дверь №3/ |");
					Console.WriteLine(@"|         | |	|         | |	|         | |");
					Console.WriteLine(@"|         | |	|         | |	|         | |");
					Console.WriteLine(@"|         |o|	|         |o|	|         |o|");
					Console.WriteLine(@"| Открыта | |	| Открыта | |	| Открыта | |");
					Console.WriteLine(@"|         | |	|         | |	|   ____  | |");
					Console.WriteLine(@"|  Пусто  | |	|  Пусто  | |	|  |ПРИЗ| | |");
					Console.WriteLine(@"|         \ |	|         \ |	|  |____| \ |");
					Console.WriteLine(@"=============	=============	=============");
					break;
				default:
					break;
			}	
		}
		
	}
}