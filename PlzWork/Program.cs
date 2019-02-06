using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlzWork
{
	class Program
	{
		
		static void Main()
		{
			
			int rounds = 0;
			while (rounds < 100)
			{
				Player p = new BruteForce();
				Player p2 = new RandoMan();
				Player p3 = new SmartGuesser();
				NumGuesser ng = new NumGuesser(p2);
				rounds++;
				
			}

			Console.WriteLine($"You played {rounds} rounds!");
		}
	}
}