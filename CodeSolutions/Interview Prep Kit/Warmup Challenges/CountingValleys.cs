using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions
{
    public static class CountingValleys
    {
        public static int Solve(int n,string s)
        {
            int SeaLevel = 0;
            bool HasEnteredValley = false;
            int numberOfValleys = 0;
            //int sLength = s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'D')
                {
                    SeaLevel -= 1;
                }
                else if (s[i] == 'U')
                {
                    SeaLevel += 1;
                }

                if (SeaLevel < 0)//Entered the Valley
                {
                    HasEnteredValley = true;
                }

                if (HasEnteredValley && SeaLevel >= 0)
                {
                    numberOfValleys += 1;
                    HasEnteredValley = false;
                }
            }
            return numberOfValleys;
        }  
    }
}
