using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Test.Thompson_Reuters
{
    public static class Class1
    {
        //Dictionary<string, string> openWith = 

        //public static char maximumOccurringCharacter(string text)
        //{
        //    char ans = ' ';
        //    int BigCount = 0;
        //    int Count = 0;
        //    Dictionary<char, int> dict = new Dictionary<char, int>();

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (!dict.ContainsKey(text[i]))
        //        {
        //            dict.Add(text[i], 1);
        //        }
        //        else
        //        {
        //            dict[text[i]] += 1;
        //        }
        //    }


        //    for (int i = 0; i < dict.Count; i++)
        //    {
        //        Count = dict.ElementAt(i).Value;

        //        if (BigCount < Count)
        //        {
        //            BigCount = Count;
        //            ans = dict.ElementAt(i).Key;
        //        }

        //    }
        //    return ans;
        //}


        public static string[] braces(string[] values)
        {
            string[] ans = new string[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                //need class //reset them
                //not the best code :(
                int RoundStartIndex = 0;
                int RoundEndIndex = 0;
                bool RoundStart = false;
                bool RoundEnd = false;

                int SquareStartIndex = 0;
                int SquareEndIndex = 0;
                bool SquareStart = false;
                bool SquareEnd = false;

                int CurlyStartIndex = 0;
                int CurlyEndIndex = 0;
                bool CurlyStart = false;
                bool CurlyEnd = false;

                bool RoundCorrect = false;
                bool SquareCorrect = false;
                bool CurlyCorrect = false;

                for (int j = 0; j < values[i].Length; j++)
                {
                    if (values[i][j] == '(')
                    {
                        RoundStart = true;
                        RoundStartIndex = j;
                    }
                    else if (values[i][j] == ')')
                    {
                        RoundEnd = true;
                        RoundEndIndex = j;
                    }
                    else if (values[i][j] == '{')
                    {
                        CurlyStart = true;
                        CurlyStartIndex = j;
                    }
                    else if (values[i][j] == '}')
                    {
                        CurlyEnd = true;
                        CurlyEndIndex = j;
                    }
                    else if (values[i][j] == '[')
                    {
                        SquareStart = true;
                        SquareStartIndex = j;
                    }
                    else if (values[i][j] == ']')
                    {
                        SquareEnd = true;
                        SquareEndIndex = j;
                    }
                }

                //if ((RoundStart == false && RoundEnd == false)) { RoundStart = RoundEnd = true; RoundStartIndex = 1; RoundEndIndex = 2; }

                //if (!(SquareStart == false && SquareEnd == false)) { SquareStart = SquareEnd = true; SquareStartIndex = 1; SquareEndIndex = 2; }

                //if (!(CurlyStart == false && CurlyEnd == false)) { CurlyStart = CurlyEnd = true; CurlyStartIndex = 1; CurlyEndIndex = 2; }

                if ((RoundStart && RoundEnd) && (RoundStartIndex < RoundEndIndex))
                {
                    RoundCorrect = true;
                }

                if ((SquareStartIndex < SquareEndIndex) && SquareStart && SquareEnd)
                {
                    SquareCorrect = true;
                }

                if ((CurlyStartIndex < CurlyEndIndex) && CurlyStart && CurlyEnd)
                {
                    CurlyCorrect = true;
                }

                ans[i] = (RoundCorrect && SquareCorrect && CurlyCorrect) ? "YES" : "NO";
            }

            return ans;
        }
    }
}
