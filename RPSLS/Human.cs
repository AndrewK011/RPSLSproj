﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public override int ChooseGesture()
        {
            Console.WriteLine("Choose a Gesture: ");

            int userInput;
            

            for (int i = 0; i < gestureList.Count; i++)
            {
                Console.WriteLine($"{i}) {gestureList[i]}");
            }

            if(int.TryParse(Console.ReadLine(), out userInput))
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Incorrect input, picking random gesture.\n");
                return RandomGesture();
            }
        }
    }
}
