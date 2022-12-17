using System;
using System.Collections.Generic;
using System.Linq;

namespace Length_Of_Missing_Array
{
    internal class Program
    {
        public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
        {
            List<int> lengths = new List<int>();   
           
            foreach (var item in arrayOfArrays)
            {
                lengths.Add(item.Length);
            }
            lengths.Sort();
            for (int i = 0; i < lengths.Count; i++)
            {
                if (lengths[i]+2==lengths[i+1])
                {
                    return lengths[i] + 1;
                }
            }

            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetLengthOfMissingArray(new object[][] { new object[] { 1, 2 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } })); 
        }
    }
}
