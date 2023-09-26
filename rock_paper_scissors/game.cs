using System;

namespace rock_paper_scissors
{
    public class game
    {
        public string player;
        public string computer;

        public game(string player,string computer)
        {
            this.player = player;
            this.computer = computer;
            
        }



        public void gameplay()
        {
            int playerScore = 0;
            int ComputerScore = 0;
            int play = default;
            bool playAgain = true;
            Random random = new Random();
            while (playAgain)
            {//rock 1 paper 2 scissors 3
                Console.WriteLine("\nPlease chooes rock,paper, or scissors\nType quite to exit");
                var userInput = Console.ReadLine();
                Console.WriteLine("\nPlayer score:" + playerScore + " | " + "Computer score:"+ ComputerScore);
                if (userInput == "rock")
                {
                     play = 1;
                    
                }
                else if (userInput == "paper")
                {
                     play = 2;
                }
                else if(userInput == "scissors")
                {
                     play = 3;
                }
                else if(userInput == "quit")
                {
                    playAgain = false;
                    Console.WriteLine("\n\n\nThe final score is"+"\nPlayer score:" + playerScore + " | " + "Computer score:" + ComputerScore);
                    if (playerScore > ComputerScore)
                    {
                        Console.WriteLine("You won the game :)");
                        break;
                    }
                    else if(playerScore < ComputerScore)
                    {
                        Console.WriteLine("You lost the game :( ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The game has ended in a draw");
                    }
                }
                var compi = random.Next(1,4);


                if (compi == 1 && play == 1)
                {
                    Console.WriteLine("\nComputer : rock");
                    Console.WriteLine(player + " : rock \n");
                    Console.WriteLine("draw, you and the computer both chose rock");
                    Console.WriteLine("No points awarded");
                    continue;


                }
                else if (compi == 2 && play == 2)
                {
                    Console.WriteLine("\nComputer : paper");
                    Console.WriteLine(player + " : paper \n");
                    Console.WriteLine("draw, you and the computer both chose paper");
                    Console.WriteLine("No points awarded");
                    continue;

                }
                else if (compi == 3 && play == 3)
                {
                    Console.WriteLine("\nComputer : scissors");
                    Console.WriteLine(player + " : scissors \n");
                    Console.WriteLine("draw, you and the computer both chose paper");
                    Console.WriteLine("No points awarded");
                    continue;

                }
                else if (compi == 1 && play == 2)
                {
                    Console.WriteLine("\nComputer : rock");
                    Console.WriteLine(player + " : paper \n");
                    Console.WriteLine("You win , computer chose rock and you chose paper");
                    playerScore++;
                    continue;

                }
                else if (compi == 1 && play == 3)
                {
                    Console.WriteLine("\nComputer : rock");
                    Console.WriteLine(player + " : scissors \n");
                    Console.WriteLine("You lose, you chose scissors and the computer chose rock");
                    ComputerScore++;
                    continue;

                }
                else if (compi == 2 && play == 1)
                {
                    Console.WriteLine("\nComputer : paper");
                    Console.WriteLine(player + " : rock\n");
                    Console.WriteLine("You lose, you chose rock and the computer chose paper");
                    ComputerScore++;
                    continue;

                }
                else if (compi == 2 && play == 3)
                {
                    Console.WriteLine("\nComputer : paper");
                    Console.WriteLine(player + " : scissors\n ");
                    Console.WriteLine("You win, You chose scissors and the computer chose paper");
                    playerScore++;
                    continue;

                }
                else if (compi == 3 && play == 1)

                {
                    Console.WriteLine("\nComputer : scissors");
                    Console.WriteLine(player + " : rock \n");
                    Console.WriteLine("You win, the computer chose scissors and you chose rock");
                    playerScore++;
                    continue;

                }
                else if (compi == 3 && play == 2)

                {
                    Console.WriteLine("\nComputer : scissors");
                    Console.WriteLine(player + " : paper \n");
                    Console.WriteLine("You lose, You chose paper and the computer choes scissors");
                    ComputerScore++;
                    continue;

                }
                




            }


        }
       
        
    }
}
