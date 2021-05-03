using System;

namespace OOP2
{
    class Product
    {
        //property class-lar var ozellikler saxlayan classlardir
        public int ID { get; set; }
        public string ProductName { get; set; }
        public DateTime ProductDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // default constructor
        public Product()
        {

        }
        public Product(int id, string productName, DateTime productDate, int quantity, decimal price)
        {
            ID = id;
            ProductName = productName;
            ProductDate = productDate;
            Quantity = quantity;
            Price = price;
        }
    }

}
