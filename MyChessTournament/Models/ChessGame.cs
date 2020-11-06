using MyChessTournament.Business_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChessTournament.Models
{
    class ChessGame : IChessMove
    {
        private int _time = 600;

        public int GameTime
        {
            get { return _time; }
            private set { _time = value; }
        }

        public void ChessMoves(string playerX, string playerY)
        {
            while (this.GameTime > 15)
            {
                if (this.GameTime % 2 == 0)
                Console.WriteLine($"{playerX} makes move against {playerY}");
                else
                    Console.WriteLine($"{playerY} makes move against {playerX}");

                this.GameTime -= 15;

            }

            Console.WriteLine("The Game Has Ended");

        }

    }
}
