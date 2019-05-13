using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLeet
{
    public static class PlusOne
    {
        public static int[] Solve(int[] digits)
        {
            int[] dg;
            if (digits[digits.Length - 1] == 9)
            {
                dg = new int[digits.Length + 1];
                for (int i = 0; i < digits.Length; i++)
                {
                    dg[i] = 1;
                }
                //dg = digits;
                dg[digits.Length] = 0;
            }
            else
            {
                digits[digits.Length - 1] += 1;
                dg = digits;
            }
            return dg;
        }
    }
}
