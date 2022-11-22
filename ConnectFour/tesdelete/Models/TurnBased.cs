using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Models
{
    public class TurnBased
    {
		private int Turn;

		public int turn
		{
			get { return Turn; }
			set { Turn = value; }
		}
	}
}
