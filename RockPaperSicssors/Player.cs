using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSicssors
{
    public class Player : IPlay
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        string _choice;

        public Player(string name)
        {
            Name = name;
        }

        public string GetChoice()
        {
            return _choice;
        }

        public void SetChoice(string choice) 
        {
            _choice = choice;
        }
    }
}
