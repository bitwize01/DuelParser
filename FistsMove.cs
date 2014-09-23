using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuelParser
{
    public class FistsMove
    {
        string name;
        double[] outcomes;

        public FistsMove(string name, double[] outcomes)
        {
            this.name = name;
            this.outcomes = outcomes;
        }

        //This service should only be used on qualified and validated objects
        //The index of the dictionary in FistMoveAbbreviations 
        int CompareTo(FistsMove compare)
        {
            int compareIndex = FistMoveAbbreviations.getMoveIndexFromName(compare.name);
            Console.WriteLine("Comparing " + this.name + " to " + compare.name + " ( " + this.outcomes[compareIndex] + " ) ");

            if (outcomes[compareIndex] < 0)
                return -1;
            if (outcomes[compareIndex] > 0)
                return 1;
            else
                return 0;
        }


    }
}
