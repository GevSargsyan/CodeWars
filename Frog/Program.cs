using System;
using System.Collections.Generic;

namespace Frog
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int y = 102;
            int x = 1;

            JumpTo(x, y);
           

        }

     
        public static int JumpTo(int x, int y)
        {
            var steps = 0;
            while (y > x)
            {
                if (y % 2 != 0 || y / 2 < x)
                {
                    y--;
                }
                else
                {
                    y = y / 2;
                }

                steps++;
            }
            return steps;
        }
    }

}

