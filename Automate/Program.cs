using Automate.Drinks;
using Automate.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate
{
    class Program
    {
        /// <summary>
        /// Notre programme vise à reproduire un automate de distrubution de boisson chaude.
        /// 1 : demander au client qu'elle boisson il veut
        /// 2 : enregistrer son choix
        /// 3 : demander la quantiteé de sel ou de sucre (variable entre 0 et 10)
        /// 4 : proposer des options en fonction de la boisson choisi
        /// 5 : afficher le montant total
        /// 6 : demander au client le choix de paiement (card / cash)
        /// 7 : procéder au paiement
        /// 8 : lancer la préparation de la boisson
        /// 9 : ajout de la quantité de condiment
        /// 10 : ajout de l'option
        /// 11 : servir la boisson
        /// </summary> 
        
       
        static void Main(string[] args)
        {
            Drink drink = SelectDrink();

            QuitOrContinue(drink);

            drink.PersonalizeDrink();

            if (QuitOrPay(drink))
            {
                Console.WriteLine("Votre boisson sera preparée!");
                Console.WriteLine("Merci!");

                // si paeiment ok  
                drink.PreparationDrink();
            }

            Console.WriteLine("Votre boisson est prête ! Bonne dégustation et à bientôt");

            Console.WriteLine("Veuillez appuyer sur une touche pour quitter");
            Console.ReadKey();
        }

        private static void QuitOrContinue(Drink drink)
        {
            Console.WriteLine("Si vous voulez changer de boisson taper 1, " +
                "si vous voulez quitter taper 2 sinon appuyer sur n'importe quelle touche pour continuer");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    drink = SelectDrink();
                    break;
                case "2":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("On continue avec votre boisson");
                    break;
            }

        }

        static Drink SelectDrink()
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

            return drink;
        }

        static bool QuitOrPay(Drink drink)
        {
            Console.WriteLine("Taper 1 pour payer ou taper 2 annuler");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Nous allons procéder au paiement!");
                    return PayDrink(drink);
                case "2":
                    Console.WriteLine("Vous ne souhaitez plus de boissons ? Dommage !");
                    //SelectDrink();
                    break;
                default:
                    break;
            }

            return false;
        }

        static bool PayDrink(Drink drink)
        {
            PaymentMethod paymentMethod = null;
            Console.WriteLine("Souhaitez-vous payer en espèce (taper 1) ou en carte (taper 2)? ");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Vous avez choisi de payer en espèce!");
                    paymentMethod = new Cash();
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisi de payer en carte!");
                    paymentMethod = new Card();
                    break;
                default:
                    break;
            }

            return paymentMethod.Pay(drink.Price);
        }
    }
}


