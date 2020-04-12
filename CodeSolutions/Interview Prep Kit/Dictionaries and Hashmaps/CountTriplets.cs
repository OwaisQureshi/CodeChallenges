using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Prep_Kit.Dictionaries_and_Hashmaps
{
    public static class CountTriplets
    {
        //long defValue = 0L;
        //https://gist.github.com/dreef3/24c50b8fa51ccf3a46f01df07e94ce50
        private static long JavaSolve(List<long> arr, long r)
        {
            var potential = new Dictionary<long, long>();
            var counter = new Dictionary<long, long>();
            long count = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                long a = arr[i];
                long key = a / r;

                if (counter.ContainsKey(key) && a % r == 0)
                {
                    count += counter[key];
                }

                if (potential.ContainsKey(key) && a % r == 0)
                {
                    long c = potential[key];
                    counter.Add(a, counter.ContainsKey(a) ? counter[a] + c : 0L);
                }

                potential.Add(a, potential.ContainsKey(a) ? potential[a] + 1 : 0L); // Every number can be the start of a triplet.
            }
            return count;
        }

        public static long Solve2(List<long> arr, long r)
        {
            //Assumptions:
            //List is unsorted
            //numbers can be or not geo sequence

            //Contraints
            //if (arr.Count <= 1 || arr.Count >= Math.Pow(10, 5)) return -1;
            //if r = 1, its returns -1 !
            //if (r <= 1 || r >= Math.Pow(10, 9)) return -1;

            int triplets = 0; //count of geoSeq sets
            int counter = 0; //counts individual sequence member
            //start and end markers for geoSeq array 
            int start = 0;
            int end = 2;

            long f1 = arr[0];
            long f2 = f1 * r;
            long f3 = f2 * r;//1*r*r

            while (end < arr.Count)//f0*(f0-1)*(f0-2)/6
            {
                for (int i = start; i < end; i++)//for pair of 3 set
                {
                    //if (IsValidGeoSeqNumb(arr[i]))
                    //{
                    //}
                }

                if (counter == 3)
                {
                    triplets += 1;
                }

                counter = 0;
                start++;
                end++;
            }
            return triplets;
        }

        //private static bool IsValidGeoSeqNumb(long numb)
        //{
        //    var returnVal = false;
        //    if (numb == 1)
        //    {
        //        return returnVal;
        //    }
        //    else if (true)
        //    {

        //    }
        //}

        public static long Solve(List<long> arr, long r)
        {
            //Assumptions:
            //List is sorted
            //all numbers are geometric sequence

            //Contraints
            //if (arr.Count <= 1 || arr.Count >= Math.Pow(10, 5)) return -1;
            //if r = 1, its returns -1 !
            //if (r <= 1 || r >= Math.Pow(10, 9)) return -1;

            //replace with geoSeq formula ?
            //var geoSeq = new HashSet<long>();
            //geoSeq.Add(1);
            var geoSeq = new Dictionary<long, int>();
            int triplets = 0; //count of geoSeq sets
            int counter = 0; //counts individual sequence member
            //start and end markers for geoSeq array 
            int start = 0;
            int end = 2;

            for (int i = 0; i < arr.Count; i++)
            {
                if (geoSeq.ContainsKey(arr[i]))
                {
                    geoSeq[arr[i]] += 1;
                }
                else
                {
                    geoSeq.Add(arr[i], 1);
                }
            }

            //1 2 2 4
            //1 5 5 25 125
            //1 3 9 9 27 81

            //1 3 9 27 81
            //1 1 2 1 1
            while (end < geoSeq.Count)
            {
                //f0*(f0-1)*(f0-2)/6
                //f0*(f0-1)*(f0-2)/6
                for (int i = start; i < end; i++)//for pair of 3 set
                {
                    if (geoSeq.Values.ElementAt(i) > 0)//get key by index
                    {
                        counter++;
                        geoSeq[geoSeq.Keys.ElementAt(i)] -= 1;
                    }
                }

                if (counter == 3)
                {
                    triplets += 1;
                }
                else
                {
                    counter -= 3;
                    triplets += (int)Math.Pow(2, counter);
                }

                counter = 0;
                start++;
                end++;
            }
            return triplets;
        }
    }
}
