using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class Asci
    {
        public void Pisir(Yemek yemek)
        {
            yemek.Pisir();
        }
    }

    public abstract class Yemek
    {
        public string[] Malzemeleri { get; set; }
        public int PismeSuresi { get; set; }
        public bool PistiMi { get; set; }

        public string Ozellik { get; set; }
        public virtual void Pisir()
        {
            Console.WriteLine(this.GetType().Name + " pişiriliyor");
        }

        public Yemek()
        {

        }

        public Yemek(string ekstra)
        {
            Ozellik = ekstra;
        }

        public abstract void SunumYap();
    }
    public class ZeytinYagliYemek : Yemek
    {
        public bool ZeytinYagiOrani { get; set; }
        public bool SogukMu { get; set; }
        public override void Pisir()
        {
            Console.WriteLine("Tencere kullanılarak");
            base.Pisir();
        }

        public override void SunumYap()
        {
            throw new NotImplementedException();
        }
    }

    public class Barbunya : ZeytinYagliYemek
    {
        public bool MaydonozVarMi { get; set; }
        public override void Pisir()
        {
            Console.WriteLine("Limon eklendi...");
            base.Pisir();
        }

    }

    public class Tatli : Yemek
    {
        public Tatli():base("Şerbet")
        {

        }
        public Tatli(string deger):base(deger)
        {

        }
        public override void SunumYap()
        {
            throw new NotImplementedException();
        }
    }

    public class Baklava : Tatli
    {
        public override void Pisir()
        {

            Console.WriteLine("Fırında baklava pişirildi");
        }
        public Baklava() : base("çıtır hamur")
        {

        }
    }
    public class Pilav : Yemek
    {
        public override void SunumYap()
        {
            throw new NotImplementedException();
        }
    }

}
