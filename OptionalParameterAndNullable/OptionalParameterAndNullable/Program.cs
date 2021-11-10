using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterAndNullable
{

    public enum Geometry
    {
        Square,
        Triangle,
        Circle,
        Rectangle
    }


    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            var result = product.Price;
            if (result.HasValue)
            {

            }

            optionalGetArea(5,3, Geometry.Rectangle);
            optionalGetArea(5, geometry: Geometry.Circle);
            optionalGetArea(3, geometry: Geometry.Triangle, height: 15);
        }

        static double alanHesapla(double length, Geometry geometry)
        {
            switch (geometry)
            {
                case Geometry.Square:
                    return Math.Pow(length, 2);

                case Geometry.Circle:
                    return Math.Pow(length, 2) * Math.PI;
                default:
                    throw new ArgumentException();
            }
        }

        static double alanHesapla(double width, double height, Geometry geometry)
        {
            switch (geometry)
            {
                case Geometry.Triangle:
                    return (width * height) / 2;

                case Geometry.Rectangle:
                    return width * height;
                default:
                    throw new ArgumentException();
            }
        }

        static double optionalGetArea(double width, double height = 1, Geometry geometry= Geometry.Square)
        {
            switch (geometry)
            {
                case Geometry.Square:
                    return Math.Pow(width, 2);
                
                case Geometry.Triangle:
                    return (width * height) / 2;
                case Geometry.Circle:
                    return Math.Pow(width, 2) * Math.PI;
                case Geometry.Rectangle:
                    return width * height;
                default:
                    throw new ArgumentException();
            }
        }


    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public int? Stock { get; set; }
    }
}
