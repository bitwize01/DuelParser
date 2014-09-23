using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuelParser
{
    public class FistMoveAbbreviations
    {
        // moveAbbreviations contains 
        private static Dictionary<string, string> moveAbbreviations = new Dictionary<string, string>()
	    {
	        {"JB","Jab"},
            {"HK","Hook"},
            {"UC","Uppercut"},
            {"CH","Chop"},
            {"JK","Jumpkick"},
            {"Spin","Spinkick"},
            {"SpK","Spinkick"},
            {"SP","Spinkick"},
            {"Snap","Snapkick"},
            {"SN","Snapkick"},
            {"Sweep","Legsweep"},
            {"LS","Legsweep"},
            {"FL","Flip"},
            {"AB","Armblock"},
            {"LB","Legblock"},
            {"DO","Dodge"},
            {"DU","Duck"},
            {"LE","Leap"}
	    };

        private static Dictionary<string, int> moveDictionary = new Dictionary<string, int>()
        {
            {"Jab", 0},
            {"Hook", 1},
            {"Uppercut", 2},
            {"Chop", 3},
            {"Jumpkick", 4},
            {"Spinkick", 5},
            {"Snapkick", 6},
            {"Legsweep", 7},
            {"Flip", 8},
            {"Armblock", 9},
            {"Legblock", 10},
            {"Dodge", 11},
            {"Duck", 12},
            {"Leap", 13}
        };

        public static bool isValidMove(string abbreviation)
        {
            return moveAbbreviations.ContainsKey(abbreviation);
        }

        public static string getMoveNameFromAbbreviation(string abbreviation)
        {
            if (isValidMove(abbreviation))
                return moveAbbreviations[abbreviation];
            else
                return null;
        }

        public static int getMoveIndexFromAbbreviation(string abbreviation)
        {
            if (isValidMove(abbreviation))
                return moveDictionary[moveAbbreviations[abbreviation]];
            else
                return -1;
        }

        public static int getMoveIndexFromName(string moveName)
        {
            return moveDictionary[moveName];
        }
    }
}
