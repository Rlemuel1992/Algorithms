using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlzWork
{
	class BruteForce : Player
	{
		
		public int guessNum = 0;

		public override int Guess()
		{
				return guessNum++;
		}
	}
}