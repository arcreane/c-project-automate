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
            Console.WriteLine("Voulez vous du fromage pour 0.50€ en plus O/N");
            string withsupp = Console.ReadLine();
            if (withsupp == "O" || withsupp == "o")
            {
                Console.WriteLine("Ajouter du fromage");
                Price += 0.50m;
                HasSupplement = true;
            }

            Console.WriteLine("Voulez vous du sel O/N");
            string withSalt = Console.ReadLine();

            if (withSalt == "O" || withSalt == "o")
            {
                string quantity;
                int quantitySalt;
                do
                {
                    Console.WriteLine("Quantité 1 --> 5 ?");
                    quantity = Console.ReadLine();
                } while (!int.TryParse(quantity, out quantitySalt) && quantitySalt < 1 && quantitySalt > 5);

                Quantity = quantitySalt;
                HasCondiment = true;
            }
        }
    }
}
