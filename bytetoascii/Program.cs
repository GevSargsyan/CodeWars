using System;

namespace bytetoascii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinaryToString("Hello"));
        }

        public static string BinaryToString(string binary)
        {
            string res = "";
            for (int i = 0; i < binary.Length; i++)
            {
                res += Convert.ToString((int)binary[i], 2).PadLeft(8, '0');
            }

            return res;
        }
    }
}
