using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLearning.DataStructres
{
    public static class UsingArray
    {
        public static void InitData(int[] initArray)
        {
            //Declaring Array 1D
            int[] ary = initArray;
            
            //Initializing Array 1D
            //ary = new int[10];// index from 0 - 9

            //Declaring and Intializing Array
            //int[] ary = new int[10];

            //2D Array int[row,col]
            //int[,] intArray = { { 1, 1 }, { 1, 2 }, { 1, 3 } };
            //int[,] intArray = new int[3,2]{ { 1, 1}, { 1, 2}, { 1, 3 } };

            // Important Properties and Methods
            // myArray.Length
            // myArray.Sort()
            // myArray.CopyTo(newArray,startIndex)
            // myArray.Rank --> 2 for 2d, dimensions

            //JaggedArray 2D

            //ref vs out
            //ref tells the compiler that the object is initialized 
            //before entering the function, 

            //out tells the compiler that the object will be initialized 
            //inside the function.

            //So while ref is two-ways, out is out-only.

            //ArrayList is kinda deprecated
            //https://stackoverflow.com/questions/2309694/arraylist-vs-list-in-c-sharp

            //ArrayList stores object in it

            //SortedList --> Old one
            //SortedList<TKey,TValue> 

        }
    }
}
