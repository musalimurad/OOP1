using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class PhoneManager //Operation class
    {
        //Encapsulation
        public void Add(Phone phone)
        {
            Console.WriteLine($" {phone.ID} Phone: {phone.PhoneName} {phone.Model} added successfuly!\n");
        }

        // --------------------------------- aralarindaki ferqe baxaq 
       
        public void Add2(int ID, string PhoneName, string Model, int Quantity, decimal Price)
        {
            Console.WriteLine($" {ID} Phone: {PhoneName} {Model} added successfuly!\n");
        }

        //DRY --> Don't Repeat Yourself!
    }
}
