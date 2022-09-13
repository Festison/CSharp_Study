using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_공부_5.TextRPG2
{
    class program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
                game.process();
            }
        }
    }
}
