using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public Computer()
        {
            
            
        }
        //public int RandomGesture()
        //{
        //    System.Threading.Thread.Sleep(1000);
        //    Random rng = new Random();
        //    int randomResult = rng.Next(0, 5);
        //    return randomResult;
        //}
        public override void ChooseGesture()
        {
           int result = RandomGesture();

            chosenGesture = gestureList[result];
            
        }
    }
}
