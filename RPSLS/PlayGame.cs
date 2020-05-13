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
        public int playerOneScore = 0;
        public int playerTwoScore = 0;

        public void Intro()
        {
            
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! \n\nEnter number of human players (0/1/2): ");
            ChooseGameMode();
            BeginGame();
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
            //playerOneScore = 0;
            //playerTwoScore = 0;
            int roundLimit = 3;
            bool gameOver = false;



            while(!gameOver)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures(playerOne, playerTwo);
                if(playerOneScore == (roundLimit / 2 + 1))
                {
                    Console.WriteLine("\nPlayer One is the winner!");
                    Console.WriteLine($"Player One: {playerOneScore} round wins\n Player Two: {playerTwoScore} round wins");
                    gameOver = true;
                }

                else if (playerTwoScore == (roundLimit / 2 + 1))
                {
                    Console.WriteLine("\nPlayer Two is the winner!");
                    Console.WriteLine($"Player One: {playerOneScore} round wins\n Player Two: {playerTwoScore} round wins");
                    gameOver = true;
                }

            }


        }

        

        public void CompareGestures(Player playerOne, Player playerTwo)
        {
            switch(playerOne.chosenGesture)
            {
                case "rock":
                    if(playerTwo.chosenGesture == "scissors" || playerTwo.chosenGesture == "lizard")
                    {
                        playerOneScore++;
                    }
                    else if(playerTwo.chosenGesture == playerOne.chosenGesture)
                    {
                        Console.WriteLine("\nIt's a tie!");
                    }
                    else
                    {
                        playerTwoScore++;
                    }
                    break;

                case "paper":
                    if (playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "Spock")
                    {
                        playerOneScore++;
                    }
                    else if (playerTwo.chosenGesture == playerOne.chosenGesture)
                    {
                        Console.WriteLine("\nIt's a tie!");
                    }
                    else
                    {
                        playerTwoScore++;
                    }
                    break;

                case "scissors":
                    if (playerTwo.chosenGesture == "paper" || playerTwo.chosenGesture == "lizard")
                    {
                        playerOneScore++;
                    }
                    else if (playerTwo.chosenGesture == playerOne.chosenGesture)
                    {
                        Console.WriteLine("\nIt's a tie!");
                    }
                    else
                    {
                        playerTwoScore++;
                    }
                    break;

                case "lizard":
                    if (playerTwo.chosenGesture == "Spock" || playerTwo.chosenGesture == "paper")
                    {
                        playerOneScore++;
                    }
                    else if (playerTwo.chosenGesture == playerOne.chosenGesture)
                    {
                        Console.WriteLine("\nIt's a tie!");
                    }
                    else
                    {
                        playerTwoScore++;
                    }
                    break;

                case "Spock":
                    if (playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "scissors")
                    {
                        playerOneScore++;
                    }
                    else if (playerTwo.chosenGesture == playerOne.chosenGesture)
                    {
                        Console.WriteLine("\nIt's a tie!");
                    }
                    else
                    {
                        playerTwoScore++;
                    }
                    break;

                default:
                    break;
                    

            }
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
