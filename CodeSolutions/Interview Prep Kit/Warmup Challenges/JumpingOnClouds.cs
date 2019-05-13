using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions
{
    public class JumpingOnClouds
    {
        // Complete the jumpingOnClouds function below.
        public static int Solve(int[] c)
        {
            if (!(c.Length >= 2) && !(c.Length <= 100))
            {
                return 0;
            }
            //elements of C should always be 0 or 1
            //c[0] and c[n-1] should be 0 / walkable, i.e the first anf last element should be 0

            int jumps = 0;
            for (int i = 0; i < c.Length;)
            {
                // if 2 hops are possible ?
                if (i < c.Length - 2 && c[i + 2] != 1)//if currentIndex && currentIndex + 1 is NOT thunderhead cloud
                {
                    jumps += 1;
                    i += 2;
                }
                //if one hop is possible
                else if (c[i + 1] != 1)
                {
                    jumps += 1;
                    i += 1;
                }

                if (i == c.Length - 1)
                {
                    break;
                }
            }
            return jumps;
        }
    }
}
