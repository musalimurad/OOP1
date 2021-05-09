using System;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 100;
            //Manager manager = new();
            //manager.Add(sayi);

            Monitor Asus = new() { Quantity = 20, ProductSort = "notbuk" };
            Monitor Hp = new() { Quantity = 10, ProductSort = "MasaUstu" };
            Manager manager = new();
            manager.Add(ref Asus);
            manager.Add(ref Hp);
   
            Console.WriteLine($"Asus: {Asus.Quantity},\nHp: {Hp.Quantity},\nProductSort-Asus: {Asus.ProductSort},\nProductSort-Hp: {Hp.ProductSort}");

        }
    }
}
