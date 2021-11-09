using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateAndEvents
{
    class Program
    {
        static int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static void Main(string[] args)
        {
            //1.0
            var filtered1 = Filter.FilterNumbers(numbers,ciftMi);

            //2.0:
            var filtered2 = Filter.FilterNumbers(numbers, delegate (int x) { return x % 2 == 1; });

            //3.5:
            var filtered3 = Filter.FilterNumbers(numbers, p => p > 5);

            show(filtered3);

        }

        private static void show(int[] filtered1)
        {
            //foreach (var item in filtered1)
            //{
            //    Console.Write(item + ", ");
            //}

            filtered1.ToList().ForEach(p => Console.Write($"{p}, "));
        }

       

       static bool ciftMi(int item)
        {
            return item % 2 == 0;
        }

    }
}
