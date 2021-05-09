using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class Manager
    {
      
        public void Add(ref Monitor monitor)
        {
            monitor.Quantity = 40;
            monitor.ProductSort = "Komputer";
        }
    }
}
