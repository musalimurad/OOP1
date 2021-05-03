using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class ProductManager
    {
        //Operation class-lar var methodlar saxlayan classlardir
        //CRUD 
        public void Create(Product product)
        {
            Console.WriteLine($"Product: {product.ProductName} created successfully!");
        }

        public void Read(Product product)
        {
            Console.WriteLine($"Product: {product.ProductName}");
        }

        public void Update(Product product)
        {
            Console.WriteLine($"Product: {product.ProductName} update successfully!");
        }

        public void Delete(Product product)
        {
            Console.WriteLine($"Product: {product.ProductName} delete successfully!");
        }

    }
}
