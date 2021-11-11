using System;

namespace MemoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(true));
            Console.ReadLine();

            Random random = new Random();
            int x = random.Next(1, 10);
          

            Console.WriteLine(GC.GetTotalMemory(true));

            GC.Collect(0, GCCollectionMode.Forced);
            GC.SuppressFinalize(random);
            Console.WriteLine(GC.GetTotalMemory(true));

            Helper helper = new Helper();
            helper.SaveProductsToFile("text.txt");
            Console.WriteLine("Dispose olmadan önce");
            Console.WriteLine(GC.GetTotalMemory(true));

            Console.WriteLine("Dispose olduktan sonra");

            helper.Dispose();

            Console.WriteLine(GC.GetTotalMemory(true));

            Console.ReadLine();

            MakeSomeGarbage();
            Console.WriteLine("Memory used before collection:       {0:N0}",
                              GC.GetTotalMemory(false));

            // Collect all generations of memory.
            GC.Collect();
            Console.WriteLine("Memory used after full collection:   {0:N0}",
                              GC.GetTotalMemory(true));
        }

        static void MakeSomeGarbage()
        {
            Version vt;

            // Create objects and release them to fill up memory with unused objects.
            for (int i = 0; i < 1000; i++)
            {
                vt = new Version();
            }
        }
    }
}
