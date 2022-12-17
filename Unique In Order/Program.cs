using System;
using System.Collections.Generic;

namespace Unique_In_Order
{
    internal class Program
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            using var e = iterable.GetEnumerator();
            bool EnumeratorActive = e.MoveNext();
            while (EnumeratorActive)
            {
                T cur = e.Current;
                yield return cur;
                while (cur.Equals(e.Current) && (EnumeratorActive = e.MoveNext())) ;
            }
            //var x = iterable.ToString();
            //string s = x[0].ToString();
            //for (int i = 1; i < iterable.ToString().Length; i ++)
            //{
            //    if (i== iterable.ToString().Length-1)
            //    {
            //        if (x[iterable.ToString().Length - 1] != s[s.Length-1])
            //        {
            //            s += x[iterable.ToString().Length - 1];
            //            return s;
            //        }

            //    }
            //    if (x[i] != x[i+1])
            //    {
            //        s += x[i+1];
            //    }
            //}
            //return s;
        }

        static void Main(string[] args)
        {
           var x = UniqueInOrder("AAAABBBCCDAABBB");
          
        }
    }
}
