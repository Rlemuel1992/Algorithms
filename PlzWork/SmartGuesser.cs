using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlzWork
{
	class SmartGuesser : Player
	{
		
		public override int Guess()
		{
			int num = 50;
			int min = 1;
			int max = 100;
			
			return num += min/max;
		}
	}
}
