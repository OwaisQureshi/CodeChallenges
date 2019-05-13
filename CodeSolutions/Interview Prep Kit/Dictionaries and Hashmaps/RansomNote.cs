using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Prep_Kit.Dictionaries_and_Hashmaps
{
    public static class RansomNote
    {
        /// <summary>
        /// solves using one dictionary for Magazine
        /// </summary>
        /// <param name="mgz"></param>
        /// <param name="note"></param>
        public static void Solve_Dictionary1(string[] mgz, string[] note)
        {
            var hasWords = false;
            //List was used previouly > Terminated due to timeout
            var mgzLst = new Dictionary<string, int>();
            for (int i = 0; i < mgz.Length; i++)
            {
                if (mgzLst.ContainsKey(mgz[i]))
                {
                    mgzLst[mgz[i]] += 1;
                }
                else
                {
                    mgzLst.Add(mgz[i], 1);
                }
            }

            for (int i = 0; i < note.Length; i++)
            {
                if (mgzLst.ContainsKey(note[i]) && mgzLst[note[i]] > 0)//words are there
                {
                    mgzLst[note[i]] -= 1;
                    hasWords = true;
                }
                else
                {
                    hasWords = false;
                    break;
                }
            }
            Console.WriteLine(hasWords ? "Yes" : "No");
        }

        /// <summary>
        /// solves using two dictionary one for Magazine and one for Note
        /// </summary>
        /// <param name="mgz"></param>
        /// <param name="note"></param>
        public static void Solve_Dictionary2(string[] mgz, string[] note)
        {
            var hasWords = false;
            //List was used previouly > Terminated due to timeout
            var noteLst = new Dictionary<string, int>();

            for (int k = 0; k < note.Length; k++)
            {
                if (noteLst.ContainsKey(note[k]))
                {
                    noteLst[note[k]] += 1;
                }
                else
                {
                    noteLst.Add(note[k], 1);
                }
            }

            var mgzLst = new Dictionary<string, int>();
            for (int i = 0; i < mgz.Length; i++)
            {
                if (mgzLst.ContainsKey(mgz[i]))
                {
                    mgzLst[mgz[i]] += 1;
                }
                else
                {
                    mgzLst.Add(mgz[i], 1);
                }
            }

            foreach (var item in noteLst)
            {
                if (mgzLst.ContainsKey(item.Key))
                {
                    if (item.Value > mgzLst[item.Key])
                    {
                        hasWords = false;
                    }
                    else if (item.Value <= mgzLst[item.Key])
                    {
                        mgzLst[item.Key] -= item.Value;
                        hasWords = true;
                    }
                }
                else
                {
                    hasWords = false;
                }

                if (!hasWords) break;
            }

            Console.WriteLine(hasWords ? "Yes" : "No");
        }
    }
}
