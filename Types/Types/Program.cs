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
            //Console.ReadLine();


            Person person = new Person();
            //person.Name = "32468";
            //person.Name = "";

            Asci asci = new Asci();
            Console.WriteLine("Baklava sınıfı:");
            Console.WriteLine("----------------------");

            asci.Pisir(new Baklava());

            Console.WriteLine("Barunya sınıfı:");
            Console.WriteLine("----------------------");
            asci.Pisir(new Barbunya());
            Console.WriteLine("Z.Y  sınıfı:");
            Console.WriteLine("----------------------");
            asci.Pisir(new ZeytinYagliYemek());
            Console.ReadLine();

            Console.WriteLine("Pilav  sınıfı:");
            Console.WriteLine("----------------------");
            asci.Pisir(new Pilav());

            Baklava baklava = new Baklava();
            baklava.Pisir();
            Console.ReadLine();

        }
    }
}
