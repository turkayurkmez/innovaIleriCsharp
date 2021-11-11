using System;
using System.Threading;

namespace LockingThread
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomResource customResource = new CustomResource();
            Thread t1 = new Thread(new ParameterizedThreadStart(customResource.writeNumberToConsole));
            Thread t2 = new Thread(customResource.writeNumberToConsole);
            Thread t3 = new Thread(customResource.writeNumberToConsole);
            Thread t4 = new Thread(customResource.writeNumberToConsole);

            Thread[] threads = { t1, t2, t3, t4 };
            foreach (var thread in threads)
            {
                thread.Start(3);
            }

            Console.ReadLine();

        }
    }
}
