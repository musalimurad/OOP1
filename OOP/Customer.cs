using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Customer : Person //base class-dan referans alib
    {
        public int CardNumber { get; set; }
        public string Order { get; set; }
    }
}
