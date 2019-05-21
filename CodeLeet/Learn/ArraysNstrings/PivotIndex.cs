using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLeet
{
    public static class PivotIndex
    {
        public static int Solve(int[] nums)
        {
            int leftSum = 0;
            int rightSum = 0;
            int l, r = 0;
            int pivot = -1;
            //-1, -1, -1, 0, 1, 1
            for (int x = 0; x < nums.Length; x++)
            {
                //left sum
                l = x - 1;
                while (l < x && l >= 0)
                {
                    leftSum += nums[l];
                    l--;
                }

                //right sum
                r = x + 1;
                while (r > x && r < nums.Length)
                {
                    rightSum += nums[r];
                    r++;
                }

                if (leftSum == rightSum)
                {
                    pivot = x;
                    break;
                }
                else
                {
                    leftSum = rightSum = 0;
                }
            }
            return pivot;
        }
    }
}
