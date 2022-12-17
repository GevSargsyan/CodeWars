using System;

namespace Sum_Strings_as_Numbers
{
    internal class Program
    {
        private static string Method(string s1,string s2)
        {
            int length = s1.Length>s2.Length?s1.Length:s2.Length;
            if (s2.Length > s1.Length)
            {
                for (int i = 0; i < s2.Length - s1.Length; i++)
                {
                    s1=string.Concat("0", s1);
                }
            }
            else
            {
                for (int i = 0; i < s1.Length - s2.Length; i++)
                {
                    s2 = string.Concat("0", s2);
                }
            }
            string s = "";
            bool isgreaterthan10 = false;
            for (int i = length-1; i >= 0; i--)
            {
                int temp = 0;
                int s1int = Convert.ToInt32(s1[i] - 48);
                int s2int = Convert.ToInt32(s2[i] - 48);
                if (s1int+s2int>=10)
                {
                    if (isgreaterthan10)
                    {
                        temp = s1int + s2int - 10 + 1;
                    }
                    else
                    {
                        temp = s1int + s2int - 10;
                    }

                    isgreaterthan10 = true;
                }
                else
                {
                    if (isgreaterthan10)
                    {
                        temp = s1int + s2int + 1;
                    }
                    else
                    {
                        temp = s1int + s2int;
                    }
                    isgreaterthan10 = false;

                }
                s = temp.ToString() + s;
            }

            return s;
        }



        static void Main(string[] args)
        {
           // string s = Method("01874", "57694");

            object[] x = new object[]{ 10,'2', "30" };
            for (int i = 0; i < x.Length; i++)
            {
                var y = x[i];
                Console.WriteLine(x[i]);

            }

            Func<int, int> cube = x => x * x;
            var d = cube(5);
            Console.WriteLine(d);

            Func<int, string, bool> func = (length, str) => str.Length > length;

            Console.WriteLine(func(5,"abccde"));

            var hello = (int x,int y,int length) => 
            {
                int sum;
                for (int i = 0; i < length; i++)
                {   sum = 0;
                    sum += x + y + i;
                    Console.WriteLine(sum);
                }
                return false;

            };

           var r = hello(1,2,5);

        }
    }
}
