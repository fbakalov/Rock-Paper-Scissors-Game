using System;

namespace Rock_Paper_Scissor
{
    class Rock_Paper_Scissor
    {
        static void Main(string[] args)
        {
            int yourScore = 0;
            int computerScore = 0;
            Console.Write("Type \"Start\" to start the game: ");
            string action = Console.ReadLine();

            if (action != "Start")
            {
                Console.WriteLine("Ivalid Input. Try Again...");
                return;
            }

            Console.WriteLine("When you are done playing type \"Stop\" to stop the game.");

            while (action == "Start")
            {
                Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
                string playerMove = Console.ReadLine();

                if (playerMove == "Stop")
                {
                    action = "Stop";
                    return;
                }                

                if (playerMove == "r" || playerMove == "rock" || playerMove == "Rock")
                {
                    playerMove = "Rock";
                }
                else if (playerMove == "p" || playerMove == "paper" || playerMove == "Paper")
                {
                    playerMove = "Paper";
                }
                else if (playerMove == "s" || playerMove == "scissors" || playerMove == "Scissors")
                {
                    playerMove = "Scissors";
                }
                else
                {
                    Console.WriteLine("Ivalid Input. Try Again...");
                    break;
                }

                Console.WriteLine($"You chose: {playerMove}.");
                Console.ReadLine();

                Random random = new Random();
                int ComputerRandNum = random.Next(1, 4);

                string computerMove = "";
                switch (ComputerRandNum)
                {
                    case 1:
                        computerMove = "Rock";
                        break;
                    case 2:
                        computerMove = "Paper";
                        break;
                    case 3:
                        computerMove = "Scissors";
                        break;
                }

                Console.WriteLine($"The computer chose: {computerMove}.");
                Console.ReadLine();


                if ((playerMove == "Rock" && computerMove == "Scissors") ||
                    (playerMove == "Paper" && computerMove == "Rock") ||
                    (playerMove == "Scissors" && computerMove == "Paper"))
                {
                    Console.WriteLine("You win!");
                    Console.ReadLine();
                    yourScore++;
                }

                if ((computerMove == "Rock" && playerMove == "Scissors") ||
                    (computerMove == "Paper" && playerMove == "Rock") ||
                    (computerMove == "Scissors" && playerMove == "Paper"))
                {
                    Console.WriteLine("You lose!");
                    Console.ReadLine();
                    computerScore++;
                }

                if ((computerMove == "Rock" && playerMove == "Rock") ||
                    (computerMove == "Paper" && playerMove == "Paper") ||
                    (computerMove == "Scissors" && playerMove == "Scissors"))
                {
                    Console.WriteLine("Draw!");
                    Console.ReadLine();
                }

                Console.WriteLine($"Your Score: {yourScore}");
                Console.WriteLine($"Computer Score: {computerScore}");
            }       
        }
    }
}
