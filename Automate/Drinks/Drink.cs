
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
        /// <param name="presonalizationPrice">Le prix de supplement</param>
        public Drink(string name, decimal price, decimal presonalizationPrice)
        {
            this.Name = name;
            this.Price = price;
            this.PresonalizationPrice = presonalizationPrice;
        }

        public decimal PresonalizationPrice
        {
            get;
            protected set;
        }

        public int Quantity { get; set; }

        protected bool HasCondiment { get; set; }

        public bool HasSupplement { get; set; }

        public abstract void PreparationDrink();

        public abstract void PersonalizeDrink();


        protected virtual void CondimentChoice(string type)
        {
            Console.WriteLine("Voulez vous du {0} O/N", type);
            string withCondiment = Console.ReadLine();

            if (string.Equals(withCondiment, "O", StringComparison.OrdinalIgnoreCase))
            {
                string quantity;
                int quantityCondiment;
                do
                {
                    Console.WriteLine("Quantité 1 --> 5 ?");
                    quantity = Console.ReadLine();
                } while (!int.TryParse(quantity, out quantityCondiment) && quantityCondiment < 1 && quantityCondiment > 5);

                Quantity = quantityCondiment;
                HasCondiment = true;
            }
        }

    }
}