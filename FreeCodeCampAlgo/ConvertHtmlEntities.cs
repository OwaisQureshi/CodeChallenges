using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCodeCampAlgo
{
    //https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures/intermediate-algorithm-scripting/convert-html-entities
    //Intermediate Algorithm Scripting: Convert HTML Entities
    public static class ConvertHtmlEntities
    {
        public static string Convert(string str)
        {
            string inputStr = str;
            List<string> result = new List<string>();
            int pos = -1;
            //char[str.Length]; // cannot ainticipate the size before hand

            string[] htmlUnsafe = new string[] { "&", "<", ">", "'", "\"" };
            var entities = new string[] { "&amp;", "&lt;", "&gt;", "&apos;", "&quot;" };
            for (int i = 0; i < str.Length; i++)
            {
                pos = Array.IndexOf(htmlUnsafe, str[i].ToString(), 0);
                if (pos > -1)
                {
                    result.Add(entities[pos]);
                }
                else
                {
                    result.Add(str[i].ToString());
                }
            }
            return String.Join("", result.ToArray());
            //result.ToString();
        }
    }
}
