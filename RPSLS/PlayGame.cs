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
        int roundLimit;

        public void Intro()
        {
            
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! \n\nEnter number of human players (0/1/2): ");
            ChooseGameMode();
            SetRoundLimit();
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
            
            
            bool gameOver = false;



            while(!gameOver)
            {
                Console.WriteLine("Player One's Turn...\n");
                
                playerOne.ChooseGesture();


                
                Console.WriteLine("Player Two's Turn...\n");
                playerTwo.ChooseGesture();
                

                CompareGestures(playerOne, playerTwo);
                if(playerOneScore == (roundLimit / 2 + 1))
                {
                    Console.WriteLine("\nPlayer One is the winner!");
                    Console.WriteLine($"Player One: {playerOneScore} round wins\nPlayer Two: {playerTwoScore} round wins");
                    gameOver = true;
                }

                else if (playerTwoScore == (roundLimit / 2 + 1))
                {
                    Console.WriteLine("\nPlayer Two is the winner!");
                    Console.WriteLine($"Player One: {playerOneScore} round wins\nPlayer Two: {playerTwoScore} round wins");
                    gameOver = true;
                }

            }

            ContinuePlay();
            

        }

        public void ContinuePlay()
        {
            Console.WriteLine($"Best out of {roundLimit + 2}? y/n");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "y":
                    roundLimit += 2;
                    BeginGame();
                        break;
                case "n":
                    PlayAgain();
                    break;
                default:
                    Console.WriteLine("Incorrect input.");
                    ContinuePlay();
                    break;
            }



            
        }

        public void PlayAgain()
        {
            Console.WriteLine("Play a new game? y/n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "y":
                    
                    playerOneScore = 0;
                    playerTwoScore = 0;
                    Intro();
                    break;
                case "n":
                    Console.WriteLine("\n\nBye!");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    PlayAgain();
                    break;
            }




        }

        public void SetRoundLimit()
        {
            
            Console.WriteLine("Best out of?");
            if(int.TryParse(Console.ReadLine(), out roundLimit))
            {
                if(roundLimit % 2 == 0 || roundLimit < 0)
                {
                    Console.WriteLine("Number must be a positive, odd integer.");
                    SetRoundLimit();
                }
                else
                {
                    Console.WriteLine($"We're playing best out of {roundLimit}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                SetRoundLimit();
            }
            
        }

        

        public void CompareGestures(Player playerOne, Player playerTwo)
        {
            switch(playerOne.chosenGesture)
            {
                case "rock":
                    if(playerTwo.chosenGesture == "scissors" || playerTwo.chosenGesture == "lizard")
                    {
                        PlayerOneWins();
                    }
                    else if(playerTwo.chosenGesture == playerOne.chosenGesture)
                    {
                        Tie();
                    }
                    else
                    {
                        PlayerTwoWins();
                    }
                    break;

                case "paper":
                    if (playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "Spock")
                    {
                        PlayerOneWins();
                    }
                    else if (playerTwo.chosenGesture == playerOne.chosenGesture)
                    {
                        Tie();
                    }
                    else
                    {
                        PlayerTwoWins();
                    }
                    break;

                case "scissors":
                    if (playerTwo.chosenGesture == "paper" || playerTwo.chosenGesture == "lizard")
                    {
                        PlayerOneWins();
                    }
                    else if (playerTwo.chosenGesture == playerOne.chosenGesture)
                    {
                        Tie();
                    }
                    else
                    {
                        PlayerTwoWins();
                    }
                    break;

                case "lizard":
                    if (playerTwo.chosenGesture == "Spock" || playerTwo.chosenGesture == "paper")
                    {
                        PlayerOneWins();
                    }
                    else if (playerTwo.chosenGesture == playerOne.chosenGesture)
                    {
                        Tie();
                    }
                    else
                    {
                        PlayerTwoWins();
                    }
                    break;

                case "Spock":
                    if (playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "scissors")
                    {
                        PlayerOneWins();
                    }
                    else if (playerTwo.chosenGesture == playerOne.chosenGesture)
                    {
                        Tie();  
                    }
                    else
                    {
                        PlayerTwoWins();
                    }
                    break;

                default:
                    break;
                    

            }
        }

        public void PlayerOneWins()
        {
            Console.WriteLine("\nPlayer One wins the round!");
            Console.WriteLine($"{playerOne.chosenGesture} beats {playerTwo.chosenGesture}!\n");
            playerOneScore++;
            Console.WriteLine(playerOneScore + " - " + playerTwoScore + "\n");
        }
        
        public void PlayerTwoWins()
        {
            Console.WriteLine("\nPlayer Two wins the round!");
            Console.WriteLine($"{playerTwo.chosenGesture} beats {playerOne.chosenGesture}!\n");
            playerTwoScore++;
            Console.WriteLine(playerOneScore + " - " + playerTwoScore + "\n");
        }
        
        public void Tie()
        {
            Console.WriteLine($"\nIt's a tie!\n");
            Console.WriteLine($"Both players picked {playerOne.chosenGesture}!\n");
            Console.WriteLine(playerOneScore + " - " + playerTwoScore + "\n");
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
