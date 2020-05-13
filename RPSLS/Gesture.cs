using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gesture
    {
        string name;

        public Gesture(string name)
        {
            this.name = name;
        }
        //rock > scissors
        //rock > lizard
        //scissors > paper
        //scissors > lizard
        //paper > rock
        //paper > spock
        //spock > scissors
        //spock > rock
        //lizard > spock
        //lizard > paper
    }
}
