using System;
using System.Linq;

namespace Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                            "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            var x = cars.Where(x => x.StartsWith('A')).Select(x=> new {x,Lento = x.Length+1});

            foreach (var item in x)
            {
                Console.WriteLine(item);

            }




        }
    }
}
