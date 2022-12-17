using System;

namespace maskify
{
    internal  class Program
    {
        public static string Maskify(string cc)//4 hat verjiny pti ereva mnacacy demic astxanish
        {

            char[] arr = cc.ToCharArray();
            for (int i = 0; i < cc.Length - 4; i++) { arr[i] = '#'; }
            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify("AAAAAAAAAAA"));
            Console.ReadLine();
        }
    }
}
