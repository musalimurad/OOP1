using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation
            Phone phone1 = new() { ID = 1, PhoneName = "Samsung", Model = "S20 ultra", Quantity = 10, Price = 2000 };
            Phone phone2 = new() { ID = 2, PhoneName = "Iphone", Model = "X", Quantity = 5, Price = 900 };

            PhoneManager phoneManager = new();

            phoneManager.Add(phone1);
            phoneManager.Add(phone2);

            //adi yazilis
            //------------------ aralarindaki ferq
            phoneManager.Add2(3, "Iphone", "11Pro", 7, 3000);


            Console.Read();
        }
    }
}
