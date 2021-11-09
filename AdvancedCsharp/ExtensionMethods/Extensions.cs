using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
   public static class Extensions
    {
        public static int KaresiniAl(this int sayi)
        {
            return sayi * sayi;
        }

        public static int UssunuAl(this int sayi, int us)
        {
            return (int) Math.Pow(sayi, us);

        }

        public static string TurkceGunGetir(this DateTime date)
        {
            var items = new string[] { "Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi" };
            return items[(int)date.DayOfWeek];
        }


    }
}
