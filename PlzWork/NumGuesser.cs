using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlzWork
{
	
	class NumGuesser
	{
		
		public List<int> attempts = new List<int>();
		Player guesser;
		public int guesses = 0;
		public NumGuesser(Player guesser)
		{
			this.guesser = guesser;
			RunGame();
			
		}
		
		public void RunGame()
		{
			
				int computerNumber = GetNumber(0, 100);
				int count = 0;
				int guessNum = 0;
				int difference = DoSubtraction(guessNum, computerNumber);
				while (guessNum != computerNumber)
				{

					guessNum = guesser.Guess();
					Console.WriteLine(guessNum);
					count++;

				}


			Console.WriteLine($"It took you {count} tries!");
			
		}



		public static int DoSubtraction(int number1, int number2)
		{
			return number1 - number2;
		}
		public static int GetNumber(int min, int max)
		{
			Random r = new Random();
			return r.Next(min, max);
		}
		
	}
}