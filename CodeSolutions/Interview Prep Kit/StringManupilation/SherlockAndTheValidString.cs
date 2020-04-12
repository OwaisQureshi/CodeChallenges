using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Prep_Kit.StringManupilation
{
    static class SherlockAndTheValidString
    {
        public static bool Algo(string str)
        {
            var charOccur = new Dictionary<char, int>();
            var numbOccur = new Dictionary<int, int>();
            var result = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!charOccur.ContainsKey(str[i]))
                {
                    charOccur.Add(str[i], 1);
                }
                else
                {
                    charOccur[str[i]] += 1;
                }
            }

            foreach (var val in charOccur.Values)
            {
                if (!numbOccur.ContainsKey(val))
                {
                    numbOccur.Add(val, 1);
                }
                else
                {
                    numbOccur[val] += 1;
                }
            }

            return result;
        }

        public static void Test()
        {
            string[] arr = new string[] {
                "aabbcd",//no
                "aabbccddeefghi",//no
                "abcdefghhgfedecba", //yes
            };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(Algo(arr[i]) ? "Yes" : "No");
            }
        }
    }
}
