using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public abstract class Document
    {
        public void Copy(string from, string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine kopyalandı");
        }

        public void Move(string from, string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine taşındı");
        }

        public abstract void LoadFromFile();
        public abstract void WriteToStorage();
      
    }

    public interface IPrintable
    {
        void Print();
    }

    public class PdfDocument : Document
    {
        public override void LoadFromFile()
        {
            throw new NotImplementedException();
        }

       

        public override void WriteToStorage()
        {
            throw new NotImplementedException();
        }
    }

    public class WordDocument : Document , IPrintable
    {
        public override void LoadFromFile()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void WriteToStorage()
        {
            throw new NotImplementedException();
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void LoadFromFile()
        {
            throw new NotImplementedException();
        }

        public  void Print()
        {
            throw new NotImplementedException();
        }

        public override void WriteToStorage()
        {
            throw new NotImplementedException();
        }
    }

    public class PrinterComponent
    {
        public void PrintDocument(IPrintable document)
        {
            document.Print();
        }
    }
}
