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
        PlayGame test = new PlayGame();
        
        public int RandomGesture()
        {
            //Random num = new Random();
            int seedRandom = test.num.Next(0,int.MaxValue);
            Random rng = new Random(seedRandom);
            System.Threading.Thread.Sleep(500);
            int randomResult = test.num.Next(0, 5);
            return randomResult;
        }

        public abstract void ChooseGesture();
    }
}
