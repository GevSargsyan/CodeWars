using System;

namespace QanakaiQarakusi
{
    internal class Program
    {
        public static bool Narcissistic(int value)
        {
            
            int length = value.ToString().Length;
            int temp = 0;
            int num = 0;
            int tempvalue = value;
            while (tempvalue > 0)
            {
                temp = tempvalue % 10;
                int squaretemp = 1;
                for (int i = 0; i < length; i++)
                {
                    squaretemp *= temp;
                }
                num += squaretemp;
                tempvalue /= 10;
            }
            return value == num;

            //karch dzev
            //var valueAsString = $"{value}";
            //return valueAsString.Sum(c => Math.Pow(char.GetNumericValue(c), valueAsString.Length)) == value;
        }
        static void Main(string[] args)
        {
            Narcissistic(153);
            //B(5, 3);
        }

        static int B(int n,int q)
        {
            int temp = 1;
            for (int i = 0; i < q; i++)
            {
                temp = temp * n;
            }
            return temp;
        
        }

    }
}
