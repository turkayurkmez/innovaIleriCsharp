using System;

namespace UsingTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            int kalan = 0;
            int result = divide(14, 3, out kalan);

            var tupleResult = tupleDivide(14, 3);
            
            
            
        }

       static int divide(int number1, int number2, out int modulo)
        {
            modulo = number1 % number2; 
            return number1 / number2;
        }

        static DivideResult divide(int number1, int number2)
        {

            return new DivideResult { Result = number1 / number2, Modulo = number1 % number2 };
        }

        static Tuple<int, int> tupleDivide(int num1, int num2)
        {
            Tuple<int, int> tuple = Tuple.Create<int, int>(num1/num2, num1 % num2);
            return tuple;
        }
    }

    public class DivideResult
    {
        public int Result { get; set; }
        public int Modulo { get; set; }
    }
}
