using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Models
{
    public abstract class Player
    {
        public string Name { get; set; } = default!;
        public char Sign { get; set; } = default!;

        public Player()
        {

        }

        public Player(string name, char sign)
        {
            Name = name;
            Sign = sign;
        }

        public abstract int ExecuteTurn(int turn = 0);

        public abstract string Symbool();
    }
}
