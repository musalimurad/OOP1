using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class PersonManager //Operation class-lar method saxlayir ozunde
    {
        public void Add(Person person)
        {
            Console.WriteLine($"Person CardNumber: {((Customer)person).CardNumber}, Person Firstname: {person.FirstName} added successfully!");
        }
    }
}
