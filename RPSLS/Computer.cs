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
       
        public override void ChooseGesture()
        {
           int result = RandomGesture();

            chosenGesture = gestureList[result];
            
        }
    }
}
