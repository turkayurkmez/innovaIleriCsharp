using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 253;
            checked
            {
                x += 2;
            }
            Console.WriteLine(x);
            Console.ReadLine();

            Navigate navigate = (Navigate)2;
            switch (navigate)
            {
                case Navigate.Sorth:
                    break;
                case Navigate.North:
                    break;
                case Navigate.East:
                    break;
                case Navigate.West:
                    break;
                default:
                    break;
            }

            Console.WriteLine((int)Navigate.West);
            //Console.ReadLine();

            ErkekAkrabalikTipleri erkekAkrabalik = ErkekAkrabalikTipleri.Abi | ErkekAkrabalikTipleri.Ogul;
            Console.WriteLine(erkekAkrabalik);
            Console.ReadLine();
        }
    }
}
