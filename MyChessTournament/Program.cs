using MyChessTournament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChessTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            Player kasparov = new Player("Kasparov");
            Player timos = new Player("Timos");
            Player paspa = new Player("Paspa");
            Player makis = new Player("Makis");
            ChessGame game1 = new ChessGame();
            ChessGame game2 = new ChessGame();
            ChessGame game3 = new ChessGame();

            game1.ChessMoves(kasparov.PlayerName, timos.PlayerName);
            game2.ChessMoves(kasparov.PlayerName, paspa.PlayerName);
            game3.ChessMoves(kasparov.PlayerName, makis.PlayerName);

            Console.ReadLine();


        }
    }
}
