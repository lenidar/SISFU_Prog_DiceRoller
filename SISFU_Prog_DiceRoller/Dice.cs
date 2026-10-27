using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISFU_Prog_DiceRoller
{
    internal class Dice
    {
        private int _side = 0;
        private Random _rnd = null;

        public Dice(int side, Random rnd)
        {
            _side = side;
            _rnd = rnd;
        }

        public int Roll()
        {
            return _rnd.Next(1, _side + 1);
        }
    }
}
