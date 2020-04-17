using Automate.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = null;
            do
            {
                Console.WriteLine("Bonjour");
                Console.WriteLine("Choisir ton boisson");
                Console.WriteLine("Tape 1 pour un café, tape 2 pour un thé et tape 3 pour une soupe");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        drink = new Coffee();
                        break;
                    case "2":
                        drink = new Tea();
                        break;
                    case "3":
                        drink = new Tomato();
                        break;
                    default:
                        Console.WriteLine("Je n'ai pas compris votre demande, réessayez");
                        break;
                }
            } while (drink == null);

            drink.PersonalizeDrink();

            // Payment
            Console.WriteLine("Il faut payer {0}", drink.Price);

            // si paeiment ok 
            drink.PreparationDrink();

            Console.ReadKey();
        }
    }
}


