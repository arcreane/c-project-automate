using Automate.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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


        static void Main(string[] args)
        {
            Drink.PresonalizationPrice = 0.5m;

            Drink drink = null;
            SelectDrink(drink);

            QuitOrContinue(drink);

            if(PriceWithoutOption(drink))
                PersonalizeDrink(drink);
            // Payment
            Console.WriteLine("Il faut payer {0}", drink.Price);

            // si paeiment ok 
            drink.PreparationDrink();

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
                    SelectDrink(drink);
                    break;
                case "2":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("On continue avec votre boisson");
                    break;
            }

        }

        // Fonction qui permet à l'utilisateur de faire son choix de boisson 
        static void SelectDrink(Drink drink)
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


        // Fonction qui permet de savoir si l'utilisateur veut sucrer ou saler sa boisson, si quantité > 0, on ajoutera une touillette avant de servir la boisson 
        static void PersonalizeDrink(Drink drink)
        {
            Console.WriteLine("Veuillez personnaliser votre boisson");
            drink.PersonalizeDrink();
            //if (drink == 1 || drink == 2)
            //{
            //    Console.WriteLine("Merci de saisir la quantité de sucre souhaitée (entre 0 et 5)");
            //    string userChoice = Console.ReadLine();
            //    switch (userChoice)
            //    {
            //        case "0":
            //            Console.WriteLine("Votre boisson ne sera pas sucrée !");
            //            stick = false;
            //            break;
            //        default:
            //            Console.WriteLine("Nous avons enregistreé votre demande, merci");
            //            stick = true;
            //            break;
            //    }
            //}
            //else if (drink == 3)
            //{
            //    Console.WriteLine("Merci de saisir la quantité de sel souhaitée (entre 0 et 5)");
            //    string userChoice = Console.ReadLine();
            //    switch (userChoice)
            //    {
            //        case "0":
            //            Console.WriteLine("Votre boisson ne sera pas salée !");
            //            stick = false;
            //            break;
            //        default:
            //            Console.WriteLine("Nous avons enregistreé votre demande, merci");
            //            stick = true;
            //            break;
            //    }
            //}
            //else
            //{
            //    SelectDrink(drink);
            //}
            //return (stick);
        }

        // Fonction qui affiche le prix de la boisson... l'utilisateur peut donc décider de payer maintenant ou d'ajouter un supplément
        static bool PriceWithoutOption(Drink drink)
        {
            drink.DisplayPriceWithoutOption();

            Console.WriteLine("Taper 1 pour payer ou taper 2 si vous souhaitez personnaliser votre boisson");

            string userChoice = Console.ReadLine();
            bool returnUser = false;
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Nous allons procéder au paiement!");
                    //PayDrink();
                    break;
                case "2":
                    Console.WriteLine("Nous allons procéder à l'ajout du suppleément !");
                    returnUser = true;
                    break;
                default:
                    break;
            }
            return returnUser;
            //if (drink == 1)
            //{
            //    Console.WriteLine("Le montant de votre café est de 1,50euros.");
            //    Console.WriteLine("Taper 1 pour payer ou taper 2 si vous souhaitez ajouter du lait");
            //    string userChoice = Console.ReadLine();
            //    switch (userChoice)
            //    {
            //        case "1":
            //            Console.WriteLine("Nous allons procéder au paiement!");
            //            //PayDrink();
            //            break;
            //        case "2":
            //            Console.WriteLine("Nous allons procéder à l'ajout du suppleément !");
            //            AddOption(drink);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //if (drink == 2)
            //{
            //    Console.WriteLine("Le montant de votre thé est de 1,20euros.");
            //    Console.WriteLine("Taper 1 pour payer ou taper 2 si vous souhaitez un thé fruit rouge");
            //    string userChoice = Console.ReadLine();
            //    switch (userChoice)
            //    {
            //        case "1":
            //            Console.WriteLine("Nous allons procéder au paiement!");
            //            //PayDrink();
            //            break;
            //        case "2":
            //            Console.WriteLine("Nous allons procéder à l'ajout du supplément !");
            //            AddOption(drink);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //if (drink == 3)
            //{
            //    Console.WriteLine("Le montant de votre soupe est de 2,50euros.");
            //    Console.WriteLine("Taper 1 pour payer ou taper 2 si vous souhaitez ajouter du fromage");
            //    string userChoice = Console.ReadLine();
            //    switch (userChoice)
            //    {
            //        case "1":
            //            Console.WriteLine("Nous allons procéder au paiement!");
            //            //PayDrink();
            //            break;
            //        case "2":
            //            Console.WriteLine("Nous allons procéder à l'ajout du suppleément !");
            //            //AddOption();
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }

        static void AddOption(int drink)
        {
            if (drink == 1)
            {
                Console.WriteLine("Nous allons ajouter du lait augmentant le prix de 0,50c.");
                PriceWithOption(drink);
            }
            if (drink == 2)
            {
                Console.WriteLine("Nous allons ajouter du fromage augmentant le prix de 0,50c.");
                PriceWithOption(drink);
            }
            if (drink == 3)
            {
                Console.WriteLine("Nous allons vous mettre du thé rouge augmentant le prix de 0,50c.");
                PriceWithOption(drink);
            }
        }

        static void PriceWithOption(int drink)
        {
            if (drink == 1)
            {
                Console.WriteLine("Le prix de votre café s'eélève maintenant à 2euros.");
                QuitOrPay();
                return;
            }
            if (drink == 2)
            {
                Console.WriteLine("Le prix de votre thé s'eélève maintenant à 1,70euros.");
                QuitOrPay();
                return;
            }
            if (drink == 3)
            {
                Console.WriteLine("Le prix de votre thé s'eélève maintenant à 3euros.");
                QuitOrPay();
                return;
            }
        }

        static void QuitOrPay()
        {
            Console.WriteLine("Taper 1 pour payer ou taper 2 annuler");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Nous allons procéder au paiement!");
                    PayDrink();
                    break;
                case "2":
                    Console.WriteLine("Vous ne souhaitez plus de boissons ? Dommage !");
                    //SelectDrink();
                    break;
                default:
                    break;
            }
        }
        static void PayDrink()
        {
            Console.WriteLine("Souhaitez-vous payer en espèce (taper 1) ou en carte (taper 2)? ");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Vous avez choisi de payer en espèce!");
                    //PayCash();
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisi de payer en carte!");
                    //PayCard();
                    break;
                default:
                    break;
            }
        }
    }
}
