using System;
using System.Collections.Generic;
using System.Linq;

namespace Clean_up_ListT__by_most_often
{
    public class AmazonItem
    {
        public string Name;
        public string Category;
    }
    internal class Program
    {
        public static List<AmazonItem> LeaveOnlyMainCategoryItems(List<AmazonItem> items)
        {
            var count = items.GroupBy(x => x.Category).Select(x=>x).Max(x=>x.Count());
            var item = items.GroupBy(x => x.Category).FirstOrDefault(x=>x.Count()==count).ToList();
            return item;
        }
        static void Main(string[] args)
        {
            List<AmazonItem> test = new List<AmazonItem>();

            for (int i = 0; i < 5; i++)
            {
                test.Add(new AmazonItem() { Category = "MainCategory" });
            }
            test.Add(new AmazonItem() { Category = "Phones" });
            test.Add(new AmazonItem() { Category = "Notebooks" });

            var x = LeaveOnlyMainCategoryItems(test);
            x.ForEach(x => Console.WriteLine(x.Category));

        }
    }
}
