using System;

namespace MontyHallGame
{
	class MontyHall
	{
		
		const int MaxCountAnswer = 3;
		
		enum TypeAnswer {BetterProb = 1, WorseProb, EqualProb};
		
		private ConsoleGraphic _cg;
				
		public MontyHall()
		{
			_cg = new ConsoleGraphic();
		}	
		
		public override string ToString()
		{
			return "Monty Hall's paradox";
		} 
		
		public void Process()
		{
			_cg.DrawLine();
			Console.WriteLine(
							  "Парадокс Монти Холла — одна из известных задач теории вероятностей,\n" + 
							  "решение которой, на первый взгляд, противоречит здравому смыслу.   \n"
							 );
		    _cg.DrawLine();
		   
			this.Quiz();
			
			Console.WriteLine();
			Console.WriteLine("Хотите сыграть в игру и сами убедиться в увеличении шансов на победу\n" +
							  "при смене двери?");
			
		}
				
		private void Quiz()
		{
		   Console.WriteLine(
			   				 "Представьте, что вы стали участником игры, в которой вам нужно\n" +  
							 "выбрать одну из трёх дверей. За одной из дверей находится автомобиль,\n" + 
							 "за двумя другими дверями — козы. Вы выбираете одну из дверей,\n" + 
							 "например, номер 1, после этого ведущий, который знает, где находится\n" + 
							 "автомобиль, а где — козы, открывает одну из оставшихся дверей,\n" + 
							 "например, номер 3, за которой находится коза. После этого он\n" + 
							 "спрашивает вас — не желаете ли вы изменить свой выбор и выбрать\n" + 
							 "дверь номер 2?\n" +
							 "\n" + 
							 "Увеличатся ли ваши шансы выиграть автомобиль,\n" + 
							 "если вы примете предложение ведущего и измените свой выбор?"
		   					);
			Console.WriteLine();
			Console.WriteLine("Варианты ответа:");
			Console.WriteLine(
							  "1. Увеличатся\n" + 
							  "2. Уменьшатся\n" +
							  "3. Останутся прежними"
							 );
			
			int counterAnswer = 0;
			var correctChoice = false;
			
			while (!correctChoice)
			{
				Console.WriteLine();
				Console.Write("Выбирите тот пункт, который вы считаете верным: ");
				var answer = Console.ReadLine();
				correctChoice = this.ProcessAnswer(answer);		
				counterAnswer++;
				if(counterAnswer >= MaxCountAnswer)
				{
					correctChoice = true;
					this.ShowAnswer((int)TypeAnswer.WorseProb);
				} 
			}
			
		}
		
		private bool ProcessAnswer(string answer)
		{
			bool correctChoice = true;
			switch (answer.ToUpper())
			{
				case "1":
				case "УВЕЛИЧАТСЯ":
				    Console.WriteLine();
					Console.WriteLine("Правильно!");
					Console.WriteLine();
					this.ShowAnswer((int)TypeAnswer.BetterProb);
					break;
				case "2":
				case "УМЕНЬШАТСЯ":
				    Console.WriteLine();
					Console.WriteLine("Это противоречит всякому здравому рассудку!");
					Console.WriteLine();
					this.ShowAnswer((int)TypeAnswer.WorseProb);
					break;
				case "3":
				case "ОСТАНУТСЯ":
				case "ОСТАНУТСЯ ПРЕЖНИМИ":
					Console.WriteLine();
					Console.WriteLine("Ошиблись. Шансы увеличатся!");
					Console.WriteLine();
					this.ShowAnswer((int)TypeAnswer.EqualProb);
					break;
				default:
					Console.WriteLine();
					Console.WriteLine("Введите один из предложенных ответов.");
					correctChoice = false;
					break;
			}
			return correctChoice;
		}
		
		private void ShowAnswer(int typeAnswer)
		{
			switch (typeAnswer)
			{
				case 1:
					Console.WriteLine(
									 "Одним из объяснений является следующее: если вы меняете \n" + 
									 "дверь после действий ведущего, то вы выигрываете c \n" +
									 "вероятностью 2/3. Потому что изначально выбрать проигрышную \n" + 
									 "дверь можно 2 способами из 3."
									 );
					break;
				case 2:
					Console.WriteLine(
									 "Изначально вероятность правильно выбрать дверь равна 1/3. \n" +
									 "При повторном выборе вероятность может только увеличиться! \n" +
									 "\n" + 
									 "Одним из объяснений является следующее: если вы меняете \n" + 
									 "дверь после действий ведущего, то вы выигрываете c \n" +
									 "вероятностью 2/3. Потому что изначально выбрать проигрышную \n" + 
									 "дверь можно 2 способами из 3. \n" +
									 "\n" + 
									 "Этот вывод противоречит интуитивному восприятию ситуации \n" + 
									 "большинством людей, поэтому описанная задача и называется \n" + 
									 "парадоксом Монти Холла, то есть парадоксом в бытовом смысле. \n" +
									 "\n" + 
									 "При решении этой задачи обычно рассуждают примерно так: \n" +
									 "ведущий всегда в итоге убирает одну проигрышную дверь, и тогда \n" + 
									 "вероятности появления автомобиля за двумя не открытыми дверьми \n" + 
									 "становятся равны 1/2, вне зависимости от первоначального выбора. \n" + 
									 "Но это неверно!"	
									 );
					break;
				case 3:
					Console.WriteLine(
									 "Этот вывод противоречит интуитивному восприятию ситуации \n" + 
									 "большинством людей, поэтому описанная задача и называется \n" + 
									 "парадоксом Монти Холла, то есть парадоксом в бытовом смысле. \n" +
									 "\n" + 
									 "При решении этой задачи обычно рассуждают примерно так: \n" +
									 "ведущий всегда в итоге убирает одну проигрышную дверь, и тогда \n" + 
									 "вероятности появления автомобиля за двумя не открытыми дверьми \n" + 
									 "становятся равны 1/2, вне зависимости от первоначального выбора. \n" + 
									 "Но это неверно!"	
									 );
					break;
				default:
					break;					
			}
		}
		
		private void GameMontyHall()
		{
						
		}
	}
}