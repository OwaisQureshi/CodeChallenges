using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSolutions;
using CodeSolutions.Interview_Prep_Kit.Arrays;
using CodeSolutions.Interview_Test.Thompson_Reuters;
using CodeLeet;
using System.IO;
using CodeSolutions.Interview_Prep_Kit.Dictionaries_and_Hashmaps;

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
            //var fullPath = @"D:\OwaisWorkx\#Code\HackerRank\CodeSolutions\TestCases";
            var fileData = new List<string>();
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
            fileData.Add(""); fileData.Add("");
            fileData.Add(str.Split(',')[0]);//"give me one grand today night");
            fileData.Add(str.Split(',')[1]);//"give one grand today");

            RansomNote.Solve_Dictionary1(fileData[2].Split(' '), fileData[3].Split(' '));
            Console.ReadLine();
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