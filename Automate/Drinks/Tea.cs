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

        //choix de suppliment et condiment
        public override void PersonalizeDrink()
        {
            Console.WriteLine("Le prix de votre boisson est: {0}€", Price);
            Console.WriteLine("Voulez vous du thé rouge pour {0} en plus O/N", PresonalizationPrice);
            string withsupp = Console.ReadLine();
            if (withsupp == "O")
            {
                Console.WriteLine("Thé fruit rouge choisie");
                Price += PresonalizationPrice;
                HasSupplement = true;
            }

            SugarChoice();
        }

    }
}
