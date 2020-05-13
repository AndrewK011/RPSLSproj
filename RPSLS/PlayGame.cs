using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class PlayGame
    {
        public Player playerOne;
        public Player playerTwo;

        public void Intro()
        {
            
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! \n\nEnter number of human players (0/1/2): ");
            ChooseGameMode();
        }

        public void ChooseGameMode()
        {
            int gameModeInput;

            if (int.TryParse(Console.ReadLine(), out gameModeInput))
            {
                switch(gameModeInput)
                {
                    case 0:
                        CreatePlayerCharacters(gameModeInput);
                        break;
                    case 1:
                        CreatePlayerCharacters(gameModeInput);
                        break;
                    case 2:
                        CreatePlayerCharacters(gameModeInput);
                        break;
                    default:
                        Console.WriteLine("Incorrect input. Enter number of human players (0/1/2):");
                        ChooseGameMode();
                        break;
                }
                    
            }

            else
            {
                Console.WriteLine("Incorrect input. Enter number of human players (0/1/2):");
                ChooseGameMode();
            }         
        }

        public void BeginGame()
        {
            int playerOneScore = 0;
            int playerTwoScore = 0;
            int roundLimit = 3;
            bool gameOver = false;



            while(!gameOver)
            {
                CompareGestures(playerOne, playerTwo);
                if(playerOneScore == (roundLimit / 2 + 1))
                {
                    Console.WriteLine("\nPlayer One is the winner!");
                    Console.WriteLine($"Player One: {playerOneScore} round wins\n Player Two: {playerTwoScore} round wins");
                    gameOver = true;
                }

                else if (playerOneScore == (roundLimit / 2 + 1))
                {
                    Console.WriteLine("\nPlayer Two is the winner!");
                    Console.WriteLine($"Player One: {playerOneScore} round wins\n Player Two: {playerTwoScore} round wins");
                    gameOver = true;
                }

            }


        }

        

        public void CompareGestures(Player playerOne, Player playerTwo)
        {
            
        }

        public (Player, Player) CreatePlayerCharacters(int humanPlayer)
        {
            if(humanPlayer == 0)
            {
                playerOne = new Computer();
                playerTwo = new Computer();
                return (playerOne, playerTwo);
            }

            else if(humanPlayer == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
                return (playerOne, playerTwo);

            }
            else
            {
                playerOne = new Human();
                playerTwo = new Human();
                return (playerOne, playerTwo);
            }

        }

        
    }
}
