using System;

namespace RockPaperSicssors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            string[] possibilities = new[] { "Rock", "Paper", "Scissors" };
            
            Player player = new Player("Soufiane");
            Player computer = new Player("Computer");

            Game game = new Game();

            while (true)
            {
                Console.WriteLine("Begin battle !:");
                Console.WriteLine($"{player.Name} what is your choice ?");
                Console.WriteLine($"1: {possibilities[0]}, 2: {possibilities[1]}, 3: {possibilities[2]}");

                string k = Console.ReadLine();

                if(Convert.ToInt32(k) > 3 || Convert.ToInt32(k) < 0)
                {
                    Console.WriteLine("please make a choice between 1 - 3");
                    return;
                }

                player.SetChoice(possibilities[Convert.ToInt32(k) - 1]);

                computer.SetChoice(possibilities[r.Next(0, 3)]);
                
                game.Battle(player, computer);
                
            }

            

        }


    }
}
