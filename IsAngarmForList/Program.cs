using System;
using System.Collections.Generic;
using System.Linq;

namespace IsAngarmForList
{
    internal class Program
    {

        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> list = new List<string>();
            foreach (string item in words)
            {
                if (word.OrderBy(x=>x).SequenceEqual(item.OrderBy(x=>x)))
                {
                    list.Add(item);
                }
            }
            return list;

            #region Aveli Karch
           // return words.Where(u => u.OrderBy(x => x).SequenceEqual(word.OrderBy(c => c))).ToList();
            #endregion
        }
        static void Main(string[] args)
        {
            Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" });

        }
    }
}
