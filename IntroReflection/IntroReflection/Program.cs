using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IntroReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type tip1 = typeof(string);
            Random random = new Random();
            Type tip2 = random.GetType();

            MetotlariGoster(tip1);
            MetotlariGoster(tip2);

            Console.ReadLine();
            Console.WriteLine("Bir kelime girin");
            string kelime = Console.ReadLine();
            Console.WriteLine("Bu kelime ile ne yapayım?");
            string metodAdi = Console.ReadLine();
            string sonuc = (string)kelime.GetType().InvokeMember(name: metodAdi, invokeAttr: BindingFlags.InvokeMethod, binder: null, target: kelime, args: null);

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }

        private static void MetotlariGoster(Type tip)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"{tip.Name} isimli tipin metotları:");
            foreach (var item in tip.GetMethods())
            {
                Console.WriteLine($"{item.Name}({ string.Join(",", item.GetParameters().Select(x => x.Name).ToArray())})");

            }
        }
    }
}
