using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Prep_Kit.Dictionaries_and_Hashmaps
{
    public static class TwoStrings
    {
        public static string Solve1(string s1, string s2)
        {
            string str1 = s1.Length >= s2.Length ? s2 : s1;//smallest
            string str2 = s1.Length >= s2.Length ? s1 : s2;//largest
            bool found = false;

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        found = true;
                        break;
                    }
                }
            }
            return found ? "YES" : "NO";
        }

        public static string Solve2(string s1, string s2)
        {
            string str1 = s1.Length >= s2.Length ? s2 : s1;//smallest
            string str2 = s1.Length >= s2.Length ? s1 : s2;//largest
            bool found = false;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str2.IndexOf(str1[i]) > -1)
                {
                    found = true;
                    break;
                }
            }
            return found ? "YES" : "NO";
        }

        //Very Fast
        public static string Solve3(string s1, string s2)
        {
            bool found = false;
            var set2 = new HashSet<char>(s2.ToCharArray());

            for (int i = 0; i < s1.Length; i++)
            {
                if (set2.Contains(s1[i]))
                {
                    found = true;
                    break;
                }
            }
            return found ? "YES" : "NO";
        }

        //Very Fast
        //Somone from HackerRank
        //https://www.hackerrank.com/Nicke?hr_r=1
        //https://www.hackerrank.com/challenges/two-strings/forum/comments/325504
        public static string Solve4(string s1, string s2)
        {
            for (int i = 97; i <= 122; i++)
            {
                if (s1.IndexOf((char)i) > -1 && s2.IndexOf((char)i) > -1)
                    return "YES";
            }
            return "NO";
        }
    }
}
