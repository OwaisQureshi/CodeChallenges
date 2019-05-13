using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSolutions
{
    public static class SockMerchant
    {
        //n: the number of socks in the pile
        static int n;
        //ar: the colors of each sock
        static List<int> ar;

        //public static int Solve_Old()
        //{
        //    int matchingPairs = 0;
        //    int matchTemp = 1;
        //    int[] arTemp = new int[15];
        //    int arTempCount = 0;

        //    int currentNumber;
        //    //arTemp = ar;
        //    for (int i = 0; i < n; i++)
        //    {
        //        currentNumber = ar[i];
        //        for (int j = i + 1; j < ar; j++)
        //        {
        //            if (currentNumber == ar[j])
        //            {
        //                matchTemp += 1;
        //            }
        //            else //if element doesnt matches put it in a temp array
        //            {
        //                arTemp[arTempCount] = ar[j];
        //                arTempCount++;
        //            }
        //        }
        //        matchingPairs += int.Parse((matchTemp / 2).ToString());
        //        matchTemp = 1;//reset
        //        ar = arTemp;
        //        n = arTempCount;
        //    }
        //    return matchingPairs;
        //}

        public static int Solve()
        {
            int matchingPairs = 0;
            int matchTemp = 0;
            int currentNumber;
            List<int> removeIndex = new List<int>();

            //constraints
            if (n >= 1 || n <= 100 || ar.Count >= 1 || ar.Count >= 100)
            {
                while (ar.Count != 0)
                {
                    //Console.WriteLine("///Inside i Loop/// Number:"+ar[i]);
                    currentNumber = ar[0];
                    //ar.RemoveAt(i);
                    for (int j = 0; j < ar.Count; j++)
                    {
                        if (currentNumber == ar[j])
                        {
                            matchTemp += 1;
//                            removeIndex.Add(j);
                        }
                    }
                    matchingPairs += int.Parse((matchTemp / 2).ToString());
                    Console.WriteLine(String.Format("Number: {0} with Pairs: {1}", currentNumber, int.Parse((matchTemp / 2).ToString())));
                   
                    //for (int k = 0; k < removeIndex.Count; k++)
                    //{
                    //    if (k == 0)
                    //    {
                    //        ar.RemoveAt(removeIndex[k]);
                    //    }
                    //    else
                    //    {
                    //        ar.RemoveAt(removeIndex[k]);
                    //    }
                    //}

                    ar.RemoveAll(item => item == currentNumber);
                    //while (list.Contains("2.2"))
                    //{
                    //    list.Remove("2.2");
                    //}
                    //list.RemoveAll(item => item == "2.2");
  //                  removeIndex = new List<int>();
                    matchTemp = 0;
                }
            }
            return matchingPairs;
        }

        public static void Input()
        {
            //n = Convert.ToInt32(Console.ReadLine());
            //ar = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            //n = 7;
            //ar = new List<int>(new int[] { 1, 2, 1, 2, 1, 3, 2 });
            //ar = new List<int>(new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            // ar = new List<int>(new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 });//Exception
            //ar = "1 1 3 1 2 1 3 3 3 3 ".Trim().Split(' ').Select(Int32.Parse).ToList();
            n = 100;
            ar = "50 49 38 49 78 36 25 96 10 67 78 58 98 8 53 1 4 7 29 6 59 93 74 3 67 47 12 85 84 40 81 85 89 70 33 66 6 9 13 67 75 42 24 73 49 28 25 5 86 53 10 44 45 35 47 11 81 10 47 16 49 79 52 89 100 36 6 57 96 18 23 71 11 99 95 12 78 19 16 64 23 77 7 19 11 5 81 43 14 27 11 63 57 62 3 56 50 9 13 45".Trim().Split(' ').Select(Int32.Parse).ToList();
            //n = 9;
            //ar = "10 20 20 10 10 30 50 10 20".Trim().Split(' ').Select(Int32.Parse).ToList();
            //ar = new List<int>(new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });//output 4, expected 3
        }
    }
}