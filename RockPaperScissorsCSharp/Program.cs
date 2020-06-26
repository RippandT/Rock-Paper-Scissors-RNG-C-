using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentRound = 0;
            int pScore = 0;
            int rngScore = 0;
            string[] pChoiceRPS = new string[3] { "Rock", "Paper", "Scissors" };
            string[] rngChoiceRPS = new string[5] { "Rock", "Paper", "Scissors", "Rock", "Paper" };

            Console.WriteLine("Welcome to Rock Paper Scissors against RNG!");
            Console.WriteLine("How many rounds do you wanna play for?");
            int rounds = int.Parse(Console.ReadLine());

            do
            {
                Random rng = new Random();
                int rngChoice = rng.Next(1, 3);

                Console.Clear();

                Console.WriteLine("Round {0} of {1}", currentRound + 1, rounds);
                Console.WriteLine("You: {0} | RNG: {1}", pScore, rngScore);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("[1]Rock ; [2]Paper ; [3]Scissors");
                int pChoice = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (pChoice < 1 || pChoice > 3)
                { Console.WriteLine("That's not it bud..."); }
                else
                {
                    switch (rngChoice)
                    {
                        case 1:
                            Console.WriteLine("You chose: {0} -- You win!", pChoiceRPS[pChoice - 1]);
                            Console.WriteLine("RNG chose: {0}", rngChoiceRPS[pChoice + 1]);
                            pScore += 1;
                            break;
                        case 2:
                            Console.WriteLine("You chose: {0}", pChoiceRPS[pChoice - 1]);
                            Console.WriteLine("RNG chose: {0} -- RNG wins!", rngChoiceRPS[pChoice]);
                            rngScore += 1;
                            break;
                        case 3:
                            Console.WriteLine("RNG chose: {0} -- It's a tie!", rngChoiceRPS[pChoice - 1]);
                            break;
                    }
                    Console.WriteLine("You: {0} | RNG: {1}", pScore, rngScore);
                    currentRound += 1;
                }
                Console.WriteLine("\n...Press any key to continue...");
                Console.ReadKey();
            } while (rounds > currentRound);

            Console.Clear();

            if (pScore > rngScore)
            {
                Console.WriteLine("Congratulations! You win the game!");
            }
            else
            {
                Console.WriteLine("Oopsies! The RNG wins the game!");
            }

            Console.WriteLine("\n...Press any key to exit...");
            Console.ReadKey();
        }
    }
}
