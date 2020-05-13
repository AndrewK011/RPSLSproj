using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        
        public string chosenGesture;
        public List<string> gestureList = new List<string> {"rock","paper","scissors","lizard","Spock" };



        public int RandomGesture()
        {
            Random num = new Random();
            System.Threading.Thread.Sleep(500);
            int randomResult = num.Next(0, 5);
            return randomResult;
        }

        public abstract void ChooseGesture();

    }
}
