using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var executeFiles = Directory.GetFiles(@"C:\Users\turka\source\repos\Kurumsal\İnnova\ileriCsharp\CustomAttribute\CustomAttribute\bin\Debug", "*.exe");

            foreach (var item in executeFiles)
            {
                var assembly = Assembly.LoadFile(item);
                foreach (var type in assembly.GetTypes())
                {
                    developerInfoLog(type);
                }
            }

            Console.ReadLine();
        }

        private static void developerInfoLog(Type type)
        {
            Console.WriteLine("Yazılımcı bilgileri alınıyor");
            Attribute[] attributes = Attribute.GetCustomAttributes(type);
            foreach (var item in attributes)
            {
                if (item is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute developerInfoAttribute = (DeveloperInfoAttribute)item;
                    Console.WriteLine($"{developerInfoAttribute.Name} isimli yazılımcının açıklaması: {developerInfoAttribute.Description}");
                }
            }
               

        }
    }

    [DeveloperInfo(name:"Türkay Ürkmez", CreatedDate = "10 Kasım 2021", Description ="Personel modeli")]
    public class Person
    {
        [DeveloperInfo(name: "Ataberk Dağdelen", CreatedDate = "10 Kasım 2021", Description = "Process Modeli Eklendi")]
        public void Process()
        {

        }
    }
}
