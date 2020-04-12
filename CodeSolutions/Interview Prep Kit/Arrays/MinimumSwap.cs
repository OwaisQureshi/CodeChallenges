using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Prep_Kit.Arrays
{
    public static class MinimumSwap
    {

        public static int Algo3(int[] arr)
        {
            int swaps = 0;
            int temp = 0;
            int swapIndex = 1;
            int currentIndex = 0;

            // 0 1 2 3 // index
            // 4 3 2 1 // numbers in array            
            while (swaps <= arr.Length - 1 && currentIndex <= arr.Length-1)// Which index the current number is at ?, if at wrong index then put it where its supposed to be ?
            {
                if (arr[currentIndex] == currentIndex + 1)
                {
                    currentIndex++;// if number 0 is at index 0 
                }
                else // if 4 at index zero is not (index + 1 = 1)
                {
                    // save temp values
                    temp = arr[currentIndex];// put the value "4" in temp// 4 was at zero index
                    swapIndex = temp - 1;
                    //swap both
                    arr[currentIndex] = arr[swapIndex];
                    arr[swapIndex] = temp;

                    swaps++;
                }
            }
            return swaps;
        }

        public static int Algo(int[] arr)
        {
            int swaps = 0;
            int temp = 0;
            int forwardIndex = 0;

            for (int currentIndex = 0; currentIndex < arr.Length - 1; currentIndex++)
            {
                forwardIndex = currentIndex + 1;
                // if the first number is not at it's right place
                while (arr[currentIndex] != currentIndex + 1)//
                {
                    // find where the number of position is ?
                    if (arr[forwardIndex] == currentIndex + 1)
                    {
                        //swap both
                        temp = arr[currentIndex];
                        arr[currentIndex] = arr[forwardIndex];
                        arr[forwardIndex] = temp;

                        swaps++;
                        forwardIndex = currentIndex + 1;
                    }

                    if (swaps >= arr.Length - 1)
                    {
                        break;
                    }

                    forwardIndex++;
                }
                if (swaps >= arr.Length - 1)
                {
                    break;
                }
            }
            return swaps;
        }

        //Changing my Algo() code by looking at the discussion on HackerRank
        public static int Algo2(int[] arr)
        {
            int swaps = 0;
            int temp = 0;
            int forwardIndex = 0;

            for (int currentIndex = 0; currentIndex < arr.Length - 1; currentIndex++)
            {
                // 0 1 2 3 // index
                // 4 3 2 1 // numbers in array
                // find where the number of position is ?
                if (arr[currentIndex] != currentIndex + 1)// if 4 at index zero is not (index + 1 = 1)
                {
                    forwardIndex = currentIndex + 1;
                    //swap both
                    temp = arr[currentIndex];
                    arr[currentIndex] = arr[forwardIndex];
                    arr[forwardIndex] = temp;

                    swaps++;
                    forwardIndex = currentIndex + 1;
                }

                if (swaps >= arr.Length - 1)
                {
                    break;
                }

                forwardIndex++;
            }
            return swaps;
        }

        //taken from discussion 
        public static int AlgoJava(int[] arr)
        {
            int temp = 0, swaps = 0;
            for (int i = 0; i < arr.Length - 1;)
            {
                if (arr[i] != i + 1)
                {
                    Console.WriteLine("Swapping --" + arr[arr[i] - 1] + "  AND -- " + arr[i]);
                    temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                    ++swaps;
                }
                else
                    ++i;
                Console.WriteLine("value at position -- " + i + " is set to -- " + arr[i]);
            }
            return swaps;
        }
    }
}