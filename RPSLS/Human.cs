using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        public Human()
        {
            
            
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose a Gesture: ");

            int userInput;
            

            for (int i = 0; i < gestureList.Count; i++)
            {
                Console.WriteLine($"{i}) {gestureList[i]}");
            }

            if(int.TryParse(Console.ReadLine(), out userInput))
            {
                chosenGesture = gestureList[userInput];
            }
            else
            {
                Console.WriteLine("Incorrect input, picking random gesture.\n");
                chosenGesture = gestureList[RandomGesture()];
            }
        }
    }
}
