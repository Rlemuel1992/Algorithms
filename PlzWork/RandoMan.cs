using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlzWork
{
	class RandoMan : Player
	{
		Random r = new Random();
		public override int Guess()
		{

			int guessNum = r.Next(1, 100);
			return guessNum;


		}
	}
}
