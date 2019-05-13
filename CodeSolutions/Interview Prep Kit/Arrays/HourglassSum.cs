using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Prep_Kit.Arrays
{
    public static class HourglassSum
    {
        public static int Solve(int[][] ar)
        {
            //A marker for x-axis movement of cursor  
            int BigSum = 0;
            int Sum = 0;
            string hourGlass = "";

            for (int i = 0; i < ar.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < ar.GetLength(0) - 2; j++)
                {

                    Sum += ar[i][j] + ar[i][j + 1] + ar[i][j + 2];
                    Sum += ar[i + 1][j + 1];
                    Sum += ar[i + 2][j] + ar[i + 2][j + 1] + ar[i + 2][j + 2];

                    if (hourGlass == "")
                    {
                        BigSum = Sum;
                    }

                    if (BigSum <= Sum)
                    {
                        BigSum = Sum;
                        hourGlass = String.Format("{0} {1} {2} \n  {3}\n{4} {5} {6} \n",
                           ar[i][j],
                           ar[i][j + 1],
                           ar[i][j + 2],
                           ar[i + 1][j + 1],
                           ar[i + 2][j],
                           ar[i + 2][j + 1],
                           ar[i + 2][j + 2]
                            );
                    }
                    Sum = 0;//reset sum

                    //Console.Write(String.Format("{0} {1} {2} \n",
                    //    ar[i, j],
                    //    ar[i, j + 1],
                    //    ar[i, j + 2]
                    //));
                    //Console.Write(String.Format("{0}\n",
                    //    ar[i + 1, j + 1]
                    // ));
                    //Console.Write(String.Format("{0} {1} {2} \n",
                    //     ar[i + 2, j],
                    //     ar[i + 2, j + 1],
                    //     ar[i + 2, j + 2]
                    // ));
                }
            }
            Console.WriteLine("Sum: " + BigSum);
            Console.Write(hourGlass);
            return BigSum;
        }

        public static void CallSolve()
        {
            //2d array
            //int[,] ar = {
            //{1 ,1 ,1 ,0 ,0 ,0},
            //{0 ,1 ,0 ,0 ,0 ,0},
            //{1 ,1 ,1 ,0 ,0 ,0},
            //{0 ,0 ,2 ,4 ,4 ,0},
            //{0 ,0 ,0 ,2 ,0 ,0},
            //{0 ,0 ,1 ,2 ,4 ,0},
            //};

            //jagged array
            //int[][] ar = new int[][]{
            //new int[] {1 ,1 ,1 ,0 ,0 ,0},
            //new int[] {0 ,1 ,0 ,0 ,0 ,0},
            //new int[] {1 ,1 ,1 ,0 ,0 ,0},
            //new int[] {0 ,0 ,2 ,4 ,4 ,0},
            //new int[] {0 ,0 ,0 ,2 ,0 ,0},
            //new int[] {0 ,0 ,1 ,2 ,4 ,0},
            //};

            int[][] ar = new int[][]{
                new int[] {0,-4,-6,0,-7,-6},
                new int[] {-1,-2,-6,-8,-3,-1},
                new int[] {-8,-4,-2,-8,-8,-6},
                new int[] {-3,-1,-2,-5,-7,-4},
                new int[] {-3,-5,-3,-6,-6,-6},
                new int[] {-3,-6,0,-8,-6,-7 }
            };//-19

            Solve(ar);
        }
    }
}
