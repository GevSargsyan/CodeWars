using System;
using System.Collections.Generic;
using System.Text;

namespace Krknvox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = new List<double>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);


            //string s = @" UPDATE[universe].[ExcelDatasetCell]
            //SET[DatasetID] = @DatasetID
            //WHERE[VariableID] = @OldVariableID AND [ID] IN () AND IsDeleted = 0";

            //iterator(nums);

            nums.ForEach(x => Console.WriteLine(x));

            nums.ForEach(n => n+=1);

            nums.ForEach(x => Console.WriteLine(x));   



        }


        private static void iterator(List<double> nums)
        {
            string s = "(";
            foreach (var item in nums)
            {
                s += item.ToString() + ",";
            }
            s = s.Remove(s.Length - 1,1);
            s += ")";
        }
    }
}
