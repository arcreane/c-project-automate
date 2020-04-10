
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automate.Drinks
{
    public abstract class Drink
    {
        public string Name
        {
            get;
            private set;
        }

        public decimal Price
        {
            get;
            protected set;
        }
        /// <summary>
        /// constructeur de la classe drink
        /// </summary>
        /// <param name="name">Le nom du boisson</param>
        /// <param name="price">Le prix de boisson</param>
        public Drink(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }



        protected bool HasCondiment { get; set; }

        public bool HasSupplement { get; set; }

        public abstract void PreparationDrink();

        public abstract void PersonalizeDrink();

    }
}