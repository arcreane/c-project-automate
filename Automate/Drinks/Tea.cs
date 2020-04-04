using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate.Drinks
{
    public class Tea : Sweet
    {
        public Tea() : base("thé", 1.20m)
        {

        }

        public override void PreparationDrink()
        {
            Console.WriteLine("Chauffer l’eau");

            if (HasSupplement)
            {
                Console.WriteLine("Tomber un sachet de thé rouge");
            }

            else
            {
                Console.WriteLine("Tomber un sachet de thé vert");
            }
            
            if (HasCondiment)
            {
                Console.WriteLine("Ajouter la quantité {0} de sucre", Quantity);
            }

            Console.WriteLine("Verser dans le goblet");

            if (HasCondiment)
            {
                Console.WriteLine("Ajouter une touillette recyclable");
            }
        }

    }
}
