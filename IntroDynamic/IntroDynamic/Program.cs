using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic value = GetBilmemNe("http://myapi.com");

            value = "yok ya bu değer...";
            value = new string[] { "a", "b" };
            Console.WriteLine(value.Length);
            Console.ReadLine();



            

        }










        private static dynamic GetBilmemNe(string url)
        {
            return "";
        }
    }
}
