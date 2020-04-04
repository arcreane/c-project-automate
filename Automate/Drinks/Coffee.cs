using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate.Drinks
{
    public class Coffee : Sweet
    {
        public Coffee() : base("Café", 1.50m)
        {

        }

        public override void PreparationDrink()
        {
            Console.WriteLine("Chauffer l'eau");
            Console.WriteLine("Presser le café");

            if (HasCondiment)
            {
                Console.WriteLine("Ajouter la quantité {0} sucre", Quantity);
            }
                
            Console.WriteLine("Verser dans le gobelet");

            if (HasSupplement)
            {
                Console.WriteLine("Ajouter Le lait");
            }

            if (HasCondiment)
            {
                Console.WriteLine("Ajouter une touillette recyclable");
            }
        }
    }
}
