using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSolutions.Interview_Prep_Kit.Dictionaries_and_Hashmaps
{
    public static class CountTriplets
    {
        public static long Solve(List<long> arr, long r)
        {
            //Assumptions
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
            int end = 0;

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

            end += 3;

            //1 2 2 4
            ///int occurences = 0;
            while (end < geoSeq.Count)
            {
                //for pair of 3 set
                for (int i = start; i < end; i++)
                {
                    if (geoSeq.Keys.ElementAt(i) > 0)
                    {
                        counter += geoSeq.ElementAt(i).Value;
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
