using System;
using System.Collections.Generic;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
      {
          { 1,2, 3, 4, 5, 6},
          { 8,9, 10,11,12,13 },
          {14,15,16,17,18,19 },
          {20,21,22,23,24,25 }
      };
            List<Tuple<int, int>> queries = new List<Tuple<int, int>>();
            queries.Add(new Tuple<int, int>(0, 0)); // 1+9+16+23 = 49
            queries.Add(new Tuple<int, int>(1, 3)); //5+11+16+21 + 3+18+25 = 99

           var x = SumDiagonals(matrix, queries);
        }

        public static void Sax()
        {
            int[,] matrix =
            {
                     { 1,2, 3, 4, 5, 6},
          { 8,9, 10,11,12,13 },
          {14,15,16,17,18,19 },
          {20,21,22,23,24,25 }


            };

            Console.WriteLine(matrix[2, 2]);

            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);

            int r = 0;
            int c = 0;

            int sum = matrix[0, 0];

            int ro = ++r;
            int co = ++c;

            while (ro < rows && co != cols)//aj nerqev
            {
                int s = matrix[ro++, co++];
                sum += s;
            }


            r = 0;
            c = 0;


            ro = ++r;
            co = --c;
            while (ro < rows && co >= 0)//dzax nerqev
            {
                int s = matrix[ro++, co--];
                sum += s;
            }


            r = 0;
            c = 0;

            ro = --r;
            co = ++c;
            while (co <= cols - 1 && ro >= 0)//aj verev
            {
                sum += matrix[ro--, co++];
            }


            r = 0;
            c = 0;

            ro = --r;
            co = --c;

            while (co >= 0 && ro >= 0)//dzax verev
            {
                sum += matrix[ro--, co--];
            }

            Console.WriteLine(sum);

        }
        public static List<int> SumDiagonals(int[,] matrix, List<Tuple<int, int>> queries)
        {
            List<int> Sums = new List<int>();
            queries.ForEach(q => Sums.Add(Sum(matrix, q.Item1, q.Item2)));
            return Sums;

        }

        public static int Sum(int[,] matrix,int r,int c)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            int sum = matrix[r, c];

            int ro = r+1;
            int co = c+1;
            while (ro < rows && co != cols){ sum += matrix[ro++, co++];}//aj nerqev

            ro = r+1;
            co = c-1;
            while (ro < rows && co >= 0){ sum += matrix[ro++, co--];}//dzax nerqev


            ro = r-1;
            co = c+1;
            while (co <= cols - 1 && ro >= 0){ sum += matrix[ro--, co++];}//aj verev

            ro = r-1;
            co = c-1;
            while (co >= 0 && ro >= 0) { sum += matrix[ro--, co--];}//dzax verev

            return sum;
        }


    }
}
