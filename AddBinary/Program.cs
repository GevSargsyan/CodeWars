using System;

namespace AddBinary
{
    internal class Program
    {
        public static string AddBinary(int a, int b)
        {
            return Convert.ToString((a+b),2); 
        }

        static void Main(string[] args)
        {
            string s = "DataPlay 16.9 version is available now with below updates";
            var s1 = s.Remove(0, 8);
            int i = 3;
            double d = 13.5857067748214;
            var j = Math.Round(d);
            long number = 19876543210;
            Console.WriteLine($"{number:+# ### ### ## ##}"); // +1 987 654 32 10
            string ss = $"{d,3}";
            Console.WriteLine(ss);
            string k = string.Format(j.ToString());
            Console.WriteLine(k);
            //Console.WriteLine(AddBinary(5,9));
        }
    }
}
