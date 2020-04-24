
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automate.Drinks
{
    public class Supplement
    {

        public Supplement(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
               
        public decimal Price { get; set; }


    }
}
