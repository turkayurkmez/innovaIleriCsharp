using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
   public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }
    }

    public class DoublePoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public void Reset()
        {
            X = 0.0;
            Y = 0.0;
        }
    }

    public class GeneralPoint
    {
        public object X { get; set; }
        public object Y { get; set; }
    }

    public class GenericPoint<T> where T:struct
    {
        public T X { get; set; }
        public T Y { get; set; }

        public void Reset()
        {
            X = default(T);
            Y = default(T);
        }
    }

}
