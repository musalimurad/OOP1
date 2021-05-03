using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // ValueType - int, decimal, byte, long, ulong, short, boolean, uint, enum ve s...
            // ValueType -lar Stack yaddasda qalir 

            int say1 = 40; // say1-nin deyeri 40dir kimi oxnur.
            int say2 = 60; // say2-nin deyeri 60dir kimi oxunur.
            say1 = say2;  // burda artiq say1-in deyerini say2-nin deyerine beraber etdik.
            say2 = 200;
            Console.WriteLine("sayi1:" + say1);

            Console.WriteLine("\n");
            //------------------------------------------------------------------

            //ReferenceType - array[], class, interface, string ve s....
            //ReferanceType-lar Heap yaddasda qalir.

            int[] saylar1 = new int[] { 1, 3, 5, 7, 9 };
            int[] saylar2 = new int[] { 2, 4, 6, 8, 10 };
            saylar1 = saylar2;

            saylar2[0] = 500;

            Console.WriteLine("saylar1[0]:" + saylar1[0]); // burda cavab 500 olacaq

            Console.WriteLine("\n");
            //----------------------------------------------------------------------------

            //OOP class-lar

            Person person1 = new() {ID = 1, FirstName = "Murad", LastName = "Musali", Phone = "055-405-55-96" }; //bu cur yazdiqda kodlari daha suretli oxuyur
            Customer customer1 = new Customer(); // bu cur yazdiqda tek-tek oxuyur kodlari bu da proqramin yavas islemesine getirib cixarir
            customer1.ID = 2;
            customer1.FirstName = "Kenan";
            customer1.LastName = "Ehmedov";
            customer1.Phone = "051-677-09-09";
            customer1.CardNumber = 354676845;
            customer1.Order = "Hp Monitor";
            Console.WriteLine($"CardNumber: {customer1.CardNumber}");
            Console.WriteLine("Order: " + customer1.Order);


            //customer != employee burda biz customer tipinde olan bir deyiskeni employee tipinde olan bir deyiskene beraber ede bilmerik 


            Person person2 = new Customer { ID = 3, FirstName = "Orxan", LastName = "Aliyev", Phone = "055-566-67-07", CardNumber = 7483592, Order = "Gaming mouse" };
            //burda ise person = customer deye bilerik , cunki person esas classdi customer esas classdan yeni personnan referans alib. amma CW-da person2-ni cagirdigimizda cardnumber ve orderi cagira bilmerik
            // burada person base class-dir yeni esas class
            Console.WriteLine($"\nFirstname: {person2.FirstName}");
            //---------------------------------------------
            //amma asagidaki kimi yazmaqda mumkundur
            Customer customer = new Customer();
            Person person3 = customer;
            person3.ID = 3;
            person3.FirstName = "resul";
            person3.LastName = "cahangirli";
            person3.Phone = "077-490-80-80";
            ((Customer)person3).CardNumber = 78453874; // bu cur yazilisa boxing deyilir.
            ((Customer)person3).Order = "airpods";
            Console.WriteLine("\n"+ person3.FirstName);
            Console.WriteLine(((Customer)person3).CardNumber);
            Console.WriteLine("\n");
            //------------------------------------------------------------
            //OOP class-larla methodlar istifade etmek mentiqi 
            PersonManager personManager = new();
            personManager.Add(person2);

            Console.Read();
        }
    }
}
