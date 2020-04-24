
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Automate.Drinks
{

    public abstract class Sweet : Drink
    {
        public Sweet(string name, decimal price)
            : base(name, price)
        {

        }

        public int Quantity { get; set; }
    }
}
