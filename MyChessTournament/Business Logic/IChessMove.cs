using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChessTournament.Business_Logic
{
    interface IChessMove
    {
        void ChessMoves(string playerX, string playerY);
    }
}
