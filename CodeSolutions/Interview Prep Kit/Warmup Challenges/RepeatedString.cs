using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions
{
    public static class RepeatedString
    {
        public static long Solve(string s, long n)
        {
            long CountofAInS = 0;
            long CountOfA = 0;
            long nDividable = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    CountofAInS += 1;
                    if (s.Length >= n && i == n)
                    {
                        return CountofAInS;
                    }
                }
            }

            nDividable = long.Parse((n / s.Length).ToString());
            CountOfA = nDividable * CountofAInS;

            for (int i = 0; i < n - (nDividable * s.Length); i++)//iterate over remaining str
            {
                if (s[i] == 'a')
                {
                    CountOfA += 1;
                }
            }

            return CountOfA;
        }

        //public static long Solve(string s, long n)
        //{
        //    StringBuilder repeatedStr = new StringBuilder();
        //    //string repeatedStr = "";
        //    int CountOfA = 0;
        //    //make a repeated string
        //    while (repeatedStr.Length != n)
        //    {
        //        for (int i = 0; i < s.Length; i++)
        //        {
        //            if (repeatedStr.Length < n)
        //            {
        //                repeatedStr.Append(s[i]);
        //                if (s[i] == 'a') CountOfA += 1;
        //            }
        //            else break;
        //        }
        //    }
        //    return CountOfA;
        //}
    }
}
