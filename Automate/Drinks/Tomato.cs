using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate.Drinks
{
    public class Tomato : Drink
    {
        public Tomato() : base("Soupe de tomate", 2.50m, 050m)
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
                Console.WriteLine("Ajouter la quantitée {0} de sel", Quantity);
            }

            if (HasSupplement)
            {
                Console.WriteLine("Ajouter du fromage");
            }

            Console.WriteLine("Ajouter une paille recyclable");
        }

        //choix de suppliment et condiment
        public override void PersonalizeDrink()
        {
            Console.WriteLine("Le prix de votre boisson est: {0}€", Price);
            Console.WriteLine("Voulez vous du fromage pour {0} en plus O/N", PresonalizationPrice);
            string withsupp = Console.ReadLine();
            if (string.Equals(withsupp, "O", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ajouter Le fromage");
                Price += PresonalizationPrice;
                HasSupplement = true;
            }

            CondimentChoice("sel");

        }
    }
}
