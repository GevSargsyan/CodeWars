using System;
using System.Linq;

namespace IsAnagram
{
    internal class Program
    {
        public static bool IsAnagram(string x, string y)
        {
            if (x.Length!=y.Length)
            {
                return false;
            }
            foreach (var item in x)
            {
                if (!y.ToLower().Contains(Char.ToLower(item)))
                {
                    return false;
                }
            }
            return true;


           // return x.ToLower().OrderBy(x => x).SequenceEqual(y.ToLower().OrderBy(x => x));
        
        }
        static void Main(string[] args)
        {
            IsAnagram("apple", "pale");
        }
    }
}
