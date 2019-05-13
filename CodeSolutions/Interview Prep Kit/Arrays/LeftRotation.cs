using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Prep_Kit.Arrays
{
    public static class LeftRotation
    {
        public static int[] RotLeft(int[] a, int d)
        {
            //4
            //1 2 3 4 5
            //5 1 2 3 4
            int newIndex = 0;
            int[] temp = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newIndex = i + d;
                if (newIndex >= a.Length)
                {
                    newIndex -= a.Length;
                }
                //left rotation;
                temp[i] = a[newIndex];
            }
            return temp;
        }
    }
}
