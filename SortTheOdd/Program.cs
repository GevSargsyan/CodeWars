using System;

namespace SortTheOdd
{
    internal class Program
    {
        public static int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] % 2 == 0) continue;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]>array[j]&&array[j]%2!=0)
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
        static void Main(string[] args)
        {
            SortArray(new int[] { 5, 3, 2, 8, 1, 4 });
        }
    }
}
