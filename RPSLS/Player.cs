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

        public List<string> gestureList = new List<string>();
        
        public void CreateList()
        {
            gestureList.Add("rock");
            gestureList.Add("paper");
            gestureList.Add("scissors");
            gestureList.Add("lizard");
            gestureList.Add("Spock");

        }

        public int RandomGesture()
        {
            Random num = new Random();
            int randomResult = num.Next(0, 5);
            return randomResult;
        }

        public abstract int ChooseGesture();

    }
}
