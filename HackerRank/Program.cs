using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSolutions;
using CodeSolutions.Interview_Prep_Kit.Arrays;
using CodeSolutions.Interview_Prep_Kit.StringManupilation;
using CodeSolutions.Interview_Test.GSquad_HackerRank;
using CodeSolutions.Interview_Test.Thompson_Reuters;
using CodeLeet;
using System.IO;
using CodeSolutions.Interview_Prep_Kit.Dictionaries_and_Hashmaps;
using FreeCodeCampAlgo;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sock Merchant
            //SockMerchant.Input();
            //int k = SockMerchant.Solve();
            //Console.WriteLine("Matching pairs: " + k);

            //Counting Valleys
            //int n = 9;
            //string s = "UDDDUDUU";
            //int n = 14;
            //string s = "UDDDUDUUDDUUDD";
            //Console.WriteLine("Number of Valleys: " +
            //CountingValleys.Solve(n, s)
            //);

            //Jumping on the Clouds
            //int[] c = { 0, 0, 1, 0, 0, 1, 0 };
            //            int[] c = { 0, 0, 0, 0, 1, 0 };
            //int[] c = { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0 };
            //int[] c = { 0, 0, 0, 1, 0, 0 };
            //Console.WriteLine("Number of Hops: " +
            //JumpingOnClouds.Solve(c));
            //Console.ReadLine();

            //string s = "aba";
            //int n = 10;
            //string s = "a";
            //long n = 1000000000000;
            //string s = "ababa";
            //long n = 3;
            //string s = "cfimaakj";
            //long n = 554045874191;
            //Console.WriteLine("Number of A: " +
            //RepeatedString.Solve(s, n));
            //Console.ReadLine();

            //SumHourGlass
            //HourglassSum.CallSolve();


            //int[] a = { 1, 2, 3, 4, 5 };

            //for (int i = a.Length-1; i > 0; i--)
            //{
            //    Console.Write(a[i]);
            //}

            //Class1.maximumOccurringCharacter("helloworld");
            //string[] str = { "{}[]()", "{[}]}" };
            //string[] str = { "{[()]}", "{[(])}", "{{[[(())]]}}" };
            //Class1.braces(str);

            //RotLeft();
            //PivotIndex();
            //PlusOne();
            //NMultiples(19);
            //string[] mgz = "ive got a lovely bunch of coconuts".Split(' ');
            //string[] note = "ive got some coconuts".Split(' ');
            /*
            string[] mgz = "two times three is not four".Split(' ');
            string[] note = "two times two is four".Split(' ');
            checkMagazine(mgz, note);
            */


            //SolveCounTriplets();
            ///SolveDictionary();

            //TwoNumbersEqualTest();

            //var result = TwoNumbsEqual(new List<int> { 5, 2, 3, 4, 1 }, 7);
            //Console.WriteLine(result);

            //TestConvertToHtmlEntities();

            TestMinimumSwaps();

            //TestAlternatingStrings();

            //TestMostOccurChar();

            //TestCountPairs();

            // Console.WriteLine(diagonalDifference());

            //plusMinus();

            //staircase();

            Console.WriteLine("...Program Exit...");
            Console.ReadLine();
        }

        static void staircase()// int n)
        {
            int n = 6;
            for (int k = n; k < n; k++)
            {
                for (int i = n; i > 0; i--)
                    Console.Write("#");
            }
            Console.WriteLine("\n");
        }

        static void plusMinus()//int[] arr)
        {
            var arr = new int[] { -4, 3, -9, 0, 4, 1 };
            float pos = 0;
            float neg = 0;
            float zer = 0;
            float size = (float)arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) zer += 1;
                else if (arr[i] > 0) pos += 1;
                else if (arr[i] < 0) neg += 1;
            }
            Console.WriteLine(pos / size);
            Console.WriteLine(neg / size);
            Console.WriteLine(zer / size);
        }

        public static int diagonalDifference()//List<List<int>> arr
        {
            var arr = new List<List<int>>()
            {
                new List<int>{1, 2, 3 },
                new List<int>{4, 5, 6},
                new List<int>{9, 8 ,9 }
            };
            int left2Right = 0;
            int right2Left = 0;
            int arrCount = arr.Count;

            for (int i = 0; i < arrCount; i++)
            {
                left2Right += arr[i][i];
                right2Left += arr[i][(arrCount - 1) - i];
            }
            return Math.Abs(left2Right - right2Left);
        }

        private static void TestCountPairs()
        {
            //List<int[]> arrayList = new List<int[]>();
            var testData = new List<int[]>() {
                new int[] {1, 1, 2, 2, 3, 3 },
                new int[] { 1, 2, 3, 4, 5, 6 }, // k =2
                new int[] { 1, 2, 5, 6, 9, 10 },// k =2
            };

            var kVals = new int[] { 1, 2, 2 };
            var print = 0;

            for (int i = 0; i < testData.Count; i++)
            {
                print = Q1.countPairs_Saad(testData[i].ToList<int>(), kVals[i]);
                Console.WriteLine(print);
            }
        }


        private static void TestMostOccurChar()
        {
            /*
             aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyyzz
abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz
UyyFh7H4OW2fZVsDDxuuoh1HuALNlLyxj8Vv7ui3Vgsdig6Qq5b6oqOwGLB0ceEUlYiBQd42XBp5886xywJCJIQPvyOpxeyK7p03Kjnpz5oKWDe8uSBpetMs3TeePfhlJywiKANFjPSb87MsWoAQclfULYubZY20zsyVxZx9zZn7m3BmNgxZGsWFg9AJPRzOpLZI0niI

             */

            var testData = new string[] {
                //"abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz",
                //"helloworld"
                "S"
            };
            var print = ' ';

            for (int i = 0; i < testData.Length; i++)
            {
                print = Q1.maximumOccurringCharacter(testData[i]);
                Console.WriteLine(print);
            }
        }


        private static void TestAlternatingStrings()
        {
            var testData = new string[] {
                "AAAA",
                "BBBBB",
                "ABABABAB",
                "BABABA",
                "AAABBB"
            };
            var print = 0;

            for (int i = 0; i < testData.Length; i++)
            {
                print = AlternatingStrings.Algo(testData[i]);
                Console.WriteLine(print);
            }
        }

        private static void TestMinimumSwaps()
        {
            var testData = new int[] { 2, 3, 4, 1, 5 };
            var print = 0;

            //for (int i = 0; i < testData.Length; i++)
            //{
            print = MinimumSwap.Algo3(testData);
            Console.WriteLine(print);
            //}
        }


        /// <summary>
        ///  For FreeCodeCamp Algo & challenges
        /// </summary>
        private static void TestConvertToHtmlEntities()
        {
            var testData = new string[] {"Dolce & Gabbana",
                "Hamburgers < Pizza < Tacos",
                "Sixty > twelve",
                "Stuff in \"quotation marks\"",
                "Schindler's List",
                "<>", "abc"};
            var print = "";

            for (int i = 0; i < testData.Length; i++)
            {
                print =
                ConvertHtmlEntities.Convert(testData[i]);

                Console.WriteLine(print);
            }
        }

        /// <summary>
        /// This problem was recently asked by Google.
        /// Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
        /// For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
        /// Bonus: Can you do this in one pass?
        /// </summary>
        /// <returns></returns>
        private static bool TwoNumbsEqual(List<int> numbers, int k)
        {
            // k = 7
            // 5,2,3,4,1
            var remainder = 0;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                // numbers[i] + remainder = k
                remainder = k - numbers[i];
                //if we can find numbers[i] and remainder, then both we have found both numbers required to make "k" 
                //numbers[i] is already there, only if we can find the corresponding/pairing number i.e remainder
                //set = new HashSet<int> (numbers.Distinct<int>().ToList<int>());
                if (set.Contains(remainder))
                {
                    return true;
                }

                set.Add(numbers[i]);
            }
            return false;
        }

        public static void TwoNumbersEqualTest()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var k = int.Parse(Console.ReadLine());

            var result = TwoNumbersEqual(numbers, k);
            Console.WriteLine(result);
        }

        public static bool TwoNumbersEqual(List<int> numbers, int k)
        {
            var set = new HashSet<int>();
            foreach (var number in numbers)
            {
                var remaining = k - number;
                if (set.Contains(remaining))
                {
                    return true;
                }

                set.Add(number);
            }
            return false;
        }

        private static void SolveCounTriplets()
        {
            var arr = new List<long>();
            long r;

            //Test case 1
            //arr = new List<long>() { 1, 5, 5, 25, 125 };
            //r = 5;

            //Test case 2
            //arr = new List<long>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            //r = 1;

            arr = new List<long>() { 1, 2, 1, 2, 4 };
            r = 2;
            CountTriplets.Solve(arr, r);
        }

        private static void SolveDictionary()
        {
            //var fullPath = @"D:\OwaisWorkx\#Code\HackerRank\CodeSolutions\TestCases";
            //var isFirst = true;
            ////AppDomain.CurrentDomain.BaseDirectory + @"\TestCases\input18.txt"
            //foreach (string line in File.ReadLines(fullPath + "\\input18.txt", Encoding.UTF8))
            //{
            //    if (isFirst)
            //    {
            //        fileData.Add(line.Split(' ')[0]);
            //        fileData.Add(line.Split(' ')[1]);
            //    }
            //    else
            //    {
            //        fileData.Add(line);
            //    }
            //    isFirst = false;
            //}
            //var str = "ive got a lovely bunch of coconuts,ive got some coconuts";
            var str = "two times three is not four,two times two is four";
            var fileData = new List<string>() { "", "" };
            fileData.Add(str.Split(',')[0]);//"give me one grand today night");
            fileData.Add(str.Split(',')[1]);//"give one grand today");

            RansomNote.Solve_Dictionary1(fileData[2].Split(' '), fileData[3].Split(' '));
        }

        private static void NMultiples(int n)
        {
            if (n >= 2 && n <= 20)
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(String.Format("{0} x {1} = {2}", n, i, i * n));
                }
            }
        }

        private static void PlusOne(int n)
        {
            int[] a = new int[] { 9 };
            Console.WriteLine(string.Join("", CodeLeet.PlusOne.Solve(a)));
        }

        private static void PivotIndex()
        {
            int[] a = new int[] { -1, -1, -1, 0, 1, 1 };
            Console.WriteLine(string.Format("{0} \nPivot Index {1}",
                "",
                CodeLeet.PivotIndex.Solve(a)
            ));
        }

        private static void RotLeft()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(String.Format("{0} RotLeft {1}",
                a.ToString(),
                LeftRotation.RotLeft(a, 4).ToString()
            ));
        }
    }
}