using System;
using System.Collections.Generic;
using System.Linq;

namespace _1ic100kent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> tver = new List<int>();

            for(int i = 1; i <= 100; i++)
            {
                tver.Add(i);
            }

            while (tver.Count > 1)
            {
                for (int i = 0; i < tver.Count; i=i+2)
                {
                    tver[i] = 0;
                }
                tver.RemoveAll(x => x == 0);
            }
            Console.WriteLine(tver[0]);
        }
    }
}
