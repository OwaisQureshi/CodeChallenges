using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Test.GSquad_HackerRank
{
    public static class Q1
    {
        public static char maximumOccurringCharacter(string text)
        {
            int maxCount = 0;
            char mostOccurChar = ' ';
            int currentCount = 0;
            var charList = new Dictionary<char, int>();

            if (text.Length == 1)
            {
                return text[0];
            }
            for (int i = 0; i < text.Length; i++)
            {
                //add key in the list if its not there
                if (!charList.ContainsKey(text[i]))
                {
                    charList.Add(text[i], 1);
                }
                else // key exists, add a counter to the key
                {
                    charList[text[i]] += 1;

                    currentCount = charList[text[i]];
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;// Max count till now
                        mostOccurChar = text[i];
                    }
                }
            }

            //mostOccurChar = charList.ElementAt(0).Key;

            return mostOccurChar;
        }

        public static int countPairs(List<int> numbers, int k)
        {
            var validPairs = new List<int[]>() { };
            int noOfPairs = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (j == i) { continue; }

                    //test i against every number
                    if (resultOfK(numbers[i]) == numbers[j + 1])
                    {
                        //if there is a pair according to (a + k = b) formula than add it
                        validPairs.Add(new int[] { numbers[i], numbers[j + 1] });
                        //noOfPairs++;
                    }
                }
            }

            noOfPairs = validPairs.Distinct().ToList().Count;

            return noOfPairs;

            int resultOfK(int a)
            {
                return a + k;
            }
        }

        public static int countPairs_Saad(List<int> numbers, int k)
        {
            int maxCount = 0;
            var charList = new Dictionary<int[], int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    //add key in the list if its not there
                    if (numbers[i] + k == numbers[j])
                    {
                        int[] pair = new int[] { numbers[i], numbers[j] };
                        if (!charList.ContainsKey(pair))
                        {
                            maxCount = maxCount + 1;
                        }
                    }
                }
            }

            return maxCount;
        }


        //public static int countPairsOld(List<int> numbers, int k)
        //{
        //    int noOfPairs = 0;
        //    //use the sliding window! :)
        //    for (int i = 0; i < numbers.Count - 1; i++)
        //    {
        //        if (resultOfK(numbers[0]) == numbers[i + 1])
        //        {
        //            noOfPairs++;
        //        }
        //    }
        //    return 1;

        //    int resultOfK(int a)
        //    {
        //        return a + k;
        //    }
        //}
    }
}
