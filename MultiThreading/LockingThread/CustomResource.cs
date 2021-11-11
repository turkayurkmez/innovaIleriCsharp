using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockingThread
{
    public class CustomResource
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public void writeNumberToConsole(object sayi)
        {
            //lock (this)
            //{
            Monitor.Enter(this);
            for (int i = (int)sayi; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine();
            Monitor.Exit(this);
            //}


        }
    }
}
