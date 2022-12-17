using System;
using System.Linq;

namespace CountPrimeSetBits
{
    internal class Program
    {
        private static int CountPrimeSetBits(int A,int B)
        {
            int sum = 0;
            bool issimple;
            for (int i = 0, n = A ; i <= B-A; i++)
            {
                issimple = true;
                
                var count = (Convert.ToString(n++, 2).GroupBy(x => x).Where(x => x.Key == '1').Select(x => x.Count())).FirstOrDefault();
                if (count>1)
                {
                    for (int j = 2; j < count/2; j++)
                    {
                        if (count % j == 0)
                        {
                            issimple = false;
                            break;
                        }

                    }
                    if (issimple)
                    {
                        sum++;
                    }
                }
            }


            return sum;
        }

        private static string ParserToBinary(int num) // es methode karanq avelord chgrenq esi grelem patkeracnelu hamar te vonca ashxatum Convert.ToString(A, 2) / kam vonc 10akanic sarqel 2akan
        {
            string res = "";
            int remainder;
            while (num>0)
            {
                remainder = num % 2;
                num /= 2;
                res = remainder.ToString() + res;

            }
      
            //for (int i = 0; i <= 8 - res.Length; i++)
            //{
            //    res = res.Insert(0, "0");
            //}

            return res;
        }

        static void Main(string[] args)
        {
            CountPrimeSetBits(6,8);
        }
    }
}
