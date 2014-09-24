using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DuelParser
{
    public static class FileReader
    {
        //Reads a file in from a local source
        public static List<string> ReadFromFile(string filename)
        {
            List<string> lines = new List<string>();

                    /** Read the contents of the given file. */

            String[] linesStringArray = System.IO.File.ReadAllLines(filename);
            lines = linesStringArray.ToList();      //Convert to a List for easier manipulation later

            return lines;
        }

        //Removes every line that doesn't contain fight data
        public static List<string> RemoveNonDuelText(List<string> RawLines)
        {
            List<string> lines = new List<string>();
            foreach (string line in RawLines)
            {
                //Searching for a timestamp followed by DUEL
                string sPattern = @"\[\d\d:\d\d:\d\d\] DUEL ";

                //Returns true if the pattern was found
                if (System.Text.RegularExpressions.Regex.IsMatch(line, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    Console.Out.WriteLine("Matched: " + line);
                    lines.Add(line);
                }
                else
                {
                    //Do nothing...?
                }
                
            }

            return lines;
        }

        //Removes all flavor text from a dueling line
        public static List<string> RemoveExtraneousDuelText(List<string> DuelLines)
        {
            List<string> lines = new List<string>();

            //First, remove any dueling lines with NO calling data
            foreach (string line in DuelLines)
            {
                string lineFormated = line;
                lineFormated = lineFormated.Trim();

                //Remove BOLD styling, if found - but the first part of the bold is actually helpful to parse off of, so lets leave it for now
                //lineFormated = Regex.Replace(lineFormated, @"<B>", "", RegexOptions.None);
                lineFormated = Regex.Replace(lineFormated, @"<\/B>", "", RegexOptions.None);

                string sPattern = @"\(\w+\/\w+,.+\)$";

                if (Regex.IsMatch(lineFormated, sPattern, RegexOptions.IgnoreCase))
                {
                    //We've found the line - now to pull the caller, and the fight data

                    //Pattern to pull the fight data - (mv/mv, # - # leadPlayer)
                    string fightDataRegex = @"(\(\w+\/\w+,.+\)$)";
                    
                    //Placeholder variable
                    string fightData = "NOT FOUND";

                    //Pattern to pull the caller name - [HH:MM:SS] DUEL callerName
                    string callerNameRegex = @"\[\d\d:\d\d:\d\d\] DUEL (\w+)";
                    
                    //Placeholder variable
                    string callerName = "NOT FOUND";

                    //Pattern to pull the ring and round - (name #)
                    string ringRoundRegex = @"<B>(\w+ \d)";

                    //Placeholder variable
                    string ringRoundData = "NOT FOUND";

                    //Do the regexes
                    fightData = Regex.Match(lineFormated, fightDataRegex, RegexOptions.IgnoreCase).Groups[1].Value;
                    callerName = Regex.Match(lineFormated, callerNameRegex, RegexOptions.IgnoreCase).Groups[1].Value;
                    ringRoundData = Regex.Match(lineFormated, ringRoundRegex, RegexOptions.IgnoreCase).Groups[1].Value;

                    //Result of the regex - remove later
                    Console.Out.WriteLine("Matched in ring/round" + ringRoundData + " by caller " + callerName + ": " + fightData);

                    //If statement
                    if (fightData.Equals("") || fightData.Equals(""))
                    {
                        Console.WriteLine("WARNING: Couldn't parse the following line: " + line);
                    }
                    else
                    {
                        lineFormated = ringRoundData + " -- " + callerName + " -- " + fightData;
                    }
                    lines.Add(lineFormated);
                }
                else
                {
                    //This may need to be removed for clarity.
                    Console.WriteLine("Skipping a non-fight line." + line);
                }
            }

            return lines;
        }
    }
}
