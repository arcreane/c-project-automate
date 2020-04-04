using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate.Drinks
{
    public class Tomato : Sweet
    {
        public Tomato() : base("Soupe de tomate", 2.50m)
        {

        }

        public override void PreparationDrink()
        {
            Console.WriteLine("Chauffer l'eau");
            Console.WriteLine("Écraser la tomate");
            Console.WriteLine("Mélanger les deux");
            Console.WriteLine("verser dans le goblet");
            if (HasCondiment)
            {
                Console.WriteLine("Ajouter la quantitée {0} de sel",Quantity);
            }

            if (HasSupplement)
            {
                Console.WriteLine("Ajouter du fromage");
            }

            Console.WriteLine("Ajouter une paille recyclable");
        }
    }
}
