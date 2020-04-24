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
            Console.WriteLine("Voulez vous du fruit rouge pour 0.50€ en plus O/N");
            string withsupp = Console.ReadLine();
            if (withsupp == "O" || withsupp == "o")
            {
                Console.WriteLine("Tomber un sachet de thé rouge");
                Price += 0.50m;
                HasSupplement = true;
            }

            Console.WriteLine("Voulez vous du sucre O/N");
            string withSugar = Console.ReadLine();

            if (withSugar == "O" || withSugar == "o")
            {
                string quantity;
                int quantitySugar;
                do
                {
                    Console.WriteLine("Quantité 1 --> 5 ?");
                    quantity = Console.ReadLine();
                } while (!int.TryParse(quantity, out quantitySugar) && quantitySugar < 1 && quantitySugar > 5);

                Quantity = quantitySugar;
                HasCondiment = true;
            }
        }
    }
}
