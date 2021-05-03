using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PascalCase// //CamelCase
            //case sensitive
            Product product1 = new(1, "RedBull", DateTime.Now, 10, 2);
            Product product2 = new(2, "Bizon", DateTime.Now, 30, 1);
            Product product3 = new(3, "Berg", DateTime.Now, 40, 1);
            Product[] products = new[] { product1, product2, product3 };
            foreach (Product product in products)
            {
                Console.WriteLine($" --------------------\n Product ID: {product.ID},\n ProductName: {product.ProductName},\n ProductDate: {product.ProductDate},\n Quantity: {product.Quantity},\n Price: {product.Price}\n --------------------");
            }

            ProductManager productManager = new();
            productManager.Create(product1);

            Console.Read();
        }
    }
}
