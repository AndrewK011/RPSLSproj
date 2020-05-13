using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //List<Gesture> gestureList = new List<Gesture>();
        public string chosenGesture;
        public List<string> gestureList = new List<string> {"rock","paper","scissors","lizard","Spock" };
        
        

        public int RandomGesture()
        {
            Random num = new Random();
            int randomResult = num.Next(0, 5);
            return randomResult;
        }

        public abstract void ChooseGesture();

    }
}
