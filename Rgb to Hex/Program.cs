using System;

namespace Rgb_to_Hex
{
    internal class Program
    {

        public static string Rgb(int r, int g, int b)
        {

            int [] arr = new int []{ r, g, b };
            string res = "";
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] <= 0)
                {
                    res += "00";
                }
                else if (arr[i] >= 255)
                {
                    res += "FF";
                }
                else if(Convert.ToString(arr[i], 16).Length==1)
                {
                    res+= "0"+Convert.ToString(arr[i], 16).ToUpper();
                }
                else
                {
                    res +=  Convert.ToString(arr[i], 16).ToUpper();
                }
            }
            return res;

            #region Karch Dzev
            //r = Math.Max(Math.Min(255, r), 0);
            //g = Math.Max(Math.Min(255, g), 0);
            //b = Math.Max(Math.Min(255, b), 0);
            //Console.WriteLine(String.Format("{0:X2}{1:X2}{2:X2}", r, g, b));
            #endregion

        }
        static void Main(string[] args)
        {

            Console.WriteLine(Rgb(212, 53, 12));

        }
    }
}
