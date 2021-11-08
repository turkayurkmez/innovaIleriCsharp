using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing:
            int o = 8;
            //Unboxing:

            //Casting:
            byte b = (byte)o;
            object x = o;

            BirClass birClass = new BirClass();
            string result = (string) birClass.BirMetot(13);

            GenericPoint<byte> genericPoint = new GenericPoint<byte>();
            
            
        }
    }

    class BirClass
    {
       public object BirMetot(object parametre)
        {
            return parametre.ToString();
        }
    }
}
