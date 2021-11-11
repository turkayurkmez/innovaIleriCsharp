using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Product> products = new List<Product>
            {
                new Product{ Name="X", Description="Test x", Price=100, Comments=new List<Comment>{
                    new Comment{ CommentText="Ok"},
                    new Comment{ CommentText="Done"}

                } },

                new Product{ Name="Y", Description="Test y", Price=50, Comments=new List<Comment>{
                    new Comment{ CommentText="Failed"},
                    new Comment{ CommentText="Success"}

                } }
            };

            serializeToJson(products);
            serializeToXML(products);

            List<Product> products1 = deSerializeFromJson();
            Console.WriteLine(products1.Count);

            List<Product> products2 = deSerializeFromXML();
            Console.ReadLine();
        }

        private static List<Product> deSerializeFromXML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
            var products = (List<Product>)xmlSerializer.Deserialize(new FileStream("products.xml", FileMode.Open));

            Console.WriteLine(3+5);
            
            return products;
        }

        private static List<Product> deSerializeFromJson()
        {
            var list = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("products.json"));

           
            return list;
        }

        private static void serializeToXML(List<Product> products)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(products.GetType());
            FileStream fileStream = new FileStream("products.xml", FileMode.Create);
            xmlSerializer.Serialize(fileStream,products);
            fileStream.Dispose();


        }

        private static void serializeToJson(List<Product> products)
        {
            var jsonResult = JsonConvert.SerializeObject(products);
            File.WriteAllText("products.json", jsonResult);
            Console.WriteLine("Serileştirme tamamlandı");
        }
    }
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }
    }
    [Serializable]
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }

    }
}
