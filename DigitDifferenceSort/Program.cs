using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitDifferenceSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int [] arr = { 152, 23, 7, 887, 243 };
            var sortedarr = DigitDifferenceSort(arr);
            for (int i = 0; i < sortedarr.Length; i++)
            {
                Console.WriteLine(sortedarr[i]);
            }
        }

        public static int[] DigitDifferenceSort(int[] a)
        {
            List<int> temp = new List<int>();
            List<(int,int,int,int)> tuple = new List<(int,int,int,int)>();

            for (int i = 0,count = 0, k = 10, n = 0 ; i < a.Length; i++)
            {
                n = a[i];
                while (n>0)
                {
                    temp.Add(n % k);
                    n /= 10;
                    count++;
                }

                tuple.Add((i,a[i], count, temp.Max() - temp.Min()));
                count = 0;
                temp.Clear();
            }
             return Sort(tuple);
        }


        public static int [] Sort(List<(int,int,int,int)> tuple)
        {
            for (int i = 0; i < tuple.Count - 1; i++)
            {
                for (int j = i + 1,k = 0; j < tuple.Count; j++,k++)
                { 
                    if (tuple[i].Item4 > tuple[j].Item4)
                    {
                        var temp = tuple[i];
                        tuple[i] = tuple[j];
                        tuple[j] = temp;
                    }

                }
            }

            for (int i = 0; i < tuple.Count - 1; i++)
            {
                for (int j = i + 1, k = 0; j < tuple.Count; j++, k++)
                {
                    if (tuple[i].Item4 == tuple[j].Item4)
                    {
                        if (tuple[i].Item1 < tuple[j].Item1)
                        {
                            var temp = tuple[i];
                            tuple[i] = tuple[j];
                            tuple[j] = temp;
                        }
                    }

                }
            }
            return tuple.Select(x=>x.Item2).ToArray();
        }

    }
}
