using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Prep_Kit.StringManupilation
{
    public static class AlternatingStrings
    {
        public static int Algo(string s)
        {
            int skips = 0;//deletions

            if (s.Length == 1)
            {
                return skips;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (i != s.Length - 1)
                {
                    if (s[i] == s[i + 1])
                    {
                        skips++;
                    }
                }
            }
            return skips;
        }
    }
}
