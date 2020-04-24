
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
        ///

        static Drink drink = null;

        static void Main(string[] args)
        {
           
            string typePayment = "";

            SelectDrink();

            QuitOrContinue();

            drink.PersonalizeDrink();

            // Paiment
            Console.WriteLine("Il faut payer {0}", drink.Price);

            SelectPayement(typePayment);

            // Si paiement ok
            drink.PreparationDrink();

            Console.WriteLine("Votre boisson est prête ! Bonne dégustation et à bientôt");

            Console.WriteLine("Veuillez appuyer sur une touchr pour quitter");
            Console.ReadKey();

        }
        // Fonction qui permet à l'utilisateur de faire son choix de boisson 
        static void SelectDrink()
        {
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

        }

        private static void QuitOrContinue()
        {
            Console.WriteLine("Si vous voulez changer de boisson taper 1, " +
                "si vous voulez quitter taper 2 sinon appuyer sur n'importe quelle touche pour continuer");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    SelectDrink();
                    break;
                case "2":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("On continue avec votre boisson");
                    break;
            }

        }
        static void SelectPayement(string typePayment)
        {
            Console.WriteLine("Taper 1 pour espèce ou 2 pour carte bleu. ");
            typePayment = Console.ReadLine();

            do
            {
                if (typePayment.Equals("1"))
                {
                    string payment;
                    Console.WriteLine("S'il vous plaît insérer de l'argent");
                    payment = Console.ReadLine();

                    Cash cash = new Cash();

                    cash.value = Convert.ToDecimal(payment);
                    cash.Pay(drink.Price);
                    Console.ReadKey();
                }
                else if (typePayment.Equals("2"))
                {
                    Console.WriteLine("S'il vous plaît insérer la carte");
                    Console.ReadKey();

                    Card card = new Card();
                    card.Pay(drink.Price);

                }

                else
                {
                    Console.WriteLine("S'il vous plaît choisissez une option valide !");
                    Console.WriteLine("Taper 1 pour espèce ou 2 pour carte bleu. ");
                    typePayment = Console.ReadLine();
                }
            } while (typePayment != "1" && typePayment != "2");
          
        }
    }
}


