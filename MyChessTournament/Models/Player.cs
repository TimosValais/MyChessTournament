using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChessTournament.Models
{
    class Player
    {
        private string _name;

        public string PlayerName
        {
            get { return _name; }
            set { _name = value; }
        }

        public Player(string playerName)
        {
            this.PlayerName = playerName;
        }
    }
}
