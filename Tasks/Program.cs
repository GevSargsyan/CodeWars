using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main()
        {

           var x = Task.Run(() => ForMethod());

            //x.Wait();
            Console.WriteLine(x.Result);
            Console.WriteLine("Hello World!");
            Console.WriteLine("End");
            Console.ReadKey();
        }

       static Task<int> ForMethod()
        {
            for (int i = 0; i < 1000000000; i++)
            {

                i=i+1;
            
            }

            return Task.FromResult(1);
        }



    }



}
