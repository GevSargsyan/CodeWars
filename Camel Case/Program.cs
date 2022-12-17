using System;
using System.Collections.Generic;
using System.Linq;

namespace Camel_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "AAAAABBBAACDDFFB";
            //string r = "";
            //var x = s.GroupBy(x=>x).Select(x=> x.Count()+x.Key.ToString());
            //foreach (var item in x)
            //{
            //    r += item;
            //}
         
            BreakCamelCase("camelCasingTestCamel");
        }

        public static string BreakCamelCase(string str)
        {
            List<int> indexes = new List<int>();     
            for (int i = 0; i < str.Length; i++)
            {
                if ("ABCDEFGHIJKLMNOPQRSTUVWYXYZ".Contains(str[i]))
                {
                   indexes.Add(i);
                }
            }
            for (int i = 0; i < indexes.Count; i++)
            {
              
               str = str.Insert(indexes[i]+i, " ");
            }
            return str;

        }
    }
}
