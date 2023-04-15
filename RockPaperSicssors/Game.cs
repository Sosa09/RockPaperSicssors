using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSicssors
{
    public class Game : IPlay
    {
        
        public string Name { get; set; }


        public void Battle(params Player[] players)
        {
            if (players.Count() < 2)
            {
                Console.WriteLine("you have to be minimum 2 players to play !");
                return;
            }



            if (players[0].GetChoice() == players[1].GetChoice())
                Console.WriteLine("Draw");
            else if ((players[0].GetChoice() == "Rock" && players[1].GetChoice() == "Paper") || (players[0].GetChoice() == "Scissors" && players[1].GetChoice() == "Rock") || (players[0].GetChoice() == "Paper" && players[1].GetChoice() == "Scissors"))
                Name = players[1].Name;
            else
                Name = players[0].Name;
            Console.WriteLine($"Winner is {Name}");
        }
    }
}
