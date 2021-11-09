using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ObservableCollection
{
    class Program
    {
       static ObservableCollection<string> accounts = new ObservableCollection<string>();
        static void Main(string[] args)
        {
            ObservableCollection<string> accounts = new ObservableCollection<string>();
            accounts.Add("Dolar");
            accounts.Add("Euro");

            accounts.CollectionChanged += Accounts_CollectionChanged;
            accounts.Insert(1, "Japon Yeni");
            accounts.Add("Kanada Doları");
            accounts[0] = accounts[1];
           
            accounts.Move(0, 1);
            accounts.Remove("Euro");
            accounts.Clear();
            
          

        }

        private static void Accounts_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Yeni Eleman eklendi");
                    Console.WriteLine("Eklenenler:");
                    foreach (var item in e.NewItems)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("bir Eleman çıkarıldı");
                  //  Console.WriteLine(accounts[e.NewStartingIndex]);
                    Console.WriteLine(e.OldStartingIndex);
                   
                    break;
                case NotifyCollectionChangedAction.Replace:

                    Console.WriteLine("Bir Elemanın yeri değişti");
                    Console.WriteLine($"Eski indexteki: {e.OldItems[e.OldStartingIndex]}, yeni indexteki {e.NewItems[e.NewStartingIndex]} ");
                    break;
                case NotifyCollectionChangedAction.Move:
                    Console.WriteLine("Yeni Eleman taşındı");
                    Console.WriteLine($"Eski indexteki: {e.OldStartingIndex}, yeni indexteki {e.NewStartingIndex} ");
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Koleksiyon resetlendi");

                    break;
                default:
                    break;
            }
        }
    }
}
