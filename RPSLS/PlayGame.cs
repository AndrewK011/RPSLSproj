using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class PlayGame
    {
        public void Intro()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! \n\n Enter number of human players (0/1/2): ");
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

        public void CompareGestures()
        {

        }

        public void CreatePlayerCharacters(int humanPlayer)
        {
            if(humanPlayer == 0)
            {
                Player playerOne = new Computer();
                Player playerTwo = new Computer();
            }

            else if(humanPlayer == 1)
            {
                Player playerOne = new Human();
                Player playerTwo = new Computer();

            }
            else
            {
                Player playerOne = new Human();
                Player playerTwo = new Human();
            }

        }
    }
}
