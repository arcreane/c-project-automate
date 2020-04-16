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

        static void Main(string[] args)
        {
            // Variable qui permet de connaître la boisson choisi tout au long du programme
            int drink = 0;
            // Variable qui permet de savoir si on doit mettre une touillette avant de servir la boisson
            bool stick = false;
            
            // Appel fonction de sélection de la boisson
            drink = SelectDrink(drink);
            // Propostion de sucrer ou saler
            AddCondiment(drink, stick);
            // Proposer de payer ou d'ajouter un supplément
            PriceWithoutOption(drink);

        }

        // Fonction qui permet à l'utilisateur de faire son choix de boisson 
        static int SelectDrink(int drink)
        {
            Console.WriteLine("Bonjour ! ?");
            Console.WriteLine("Merci de sélectionner une boisson !");
            Console.WriteLine("Taper 1 pour un café, taper 2 pour un thé et taper 3 pour une soupe");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Vous avez choisi un café !");
                    drink = 1;
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisi un thé ! !");
                    drink = 2;
                    break;
                case "3":
                    drink = 3;
                    Console.WriteLine("Vous avez choisi une soupe !");
                    break;
                default:
                    Console.WriteLine("Je n'ai pas compris votre demande, réessayez");
                    break;
            }
            return (drink);
        }

        // Fonction qui permet de savoir si l'utilisateur veut sucrer ou saler sa boisson, si quantité > 0, on ajoutera une touillette avant de servir la boisson 
        static bool AddCondiment(int drink, bool stick)
        {
            if (drink == 1 || drink == 2)
            {
                Console.WriteLine("Merci de saisir la quantité de sucre souhaitée (entre 0 et 5)");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "0":
                        Console.WriteLine("Votre boisson ne sera pas sucrée !");
                        stick = false;
                        break;
                    default:
                        Console.WriteLine("Nous avons enregistreé votre demande, merci");
                        stick = true;
                        break;
                }
            }
            else if (drink == 3)
            {
                Console.WriteLine("Merci de saisir la quantité de sel souhaitée (entre 0 et 5)");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "0":
                        Console.WriteLine("Votre boisson ne sera pas salée !");
                        stick = false;
                        break;
                    default:
                        Console.WriteLine("Nous avons enregistreé votre demande, merci");
                        stick = true;
                        break;
                }
            }
            else
            {
                SelectDrink(drink);
            }
            return (stick);
        }

        // Fonction qui affiche le prix de la boisson... l'utilisateur peut donc décider de payer maintenant ou d'ajouter un supplément
        static void PriceWithoutOption(int drink)
        {
            if (drink == 1)
            {
                Console.WriteLine("Le montant de votre café est de 1,50euros.");
                Console.WriteLine("Taper 1 pour payer ou taper 2 si vous souhaitez ajouter du lait");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Nous allons procéder au paiement!");
                        //PayDrink();
                        break;
                    case "2":
                        Console.WriteLine("Nous allons procéder à l'ajout du suppleément !");
                        AddOption(drink);
                        break;
                    default:
                        break;
                }
            }
            if (drink == 2)
            {
                Console.WriteLine("Le montant de votre thé est de 1,20euros.");
                Console.WriteLine("Taper 1 pour payer ou taper 2 si vous souhaitez un thé fruit rouge");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Nous allons procéder au paiement!");
                        //PayDrink();
                        break;
                    case "2":
                        Console.WriteLine("Nous allons procéder à l'ajout du supplément !");
                        AddOption(drink);
                        break;
                    default:
                        break;
                }
            }
            if (drink == 3)
            {
                Console.WriteLine("Le montant de votre soupe est de 2,50euros.");
                Console.WriteLine("Taper 1 pour payer ou taper 2 si vous souhaitez ajouter du fromage");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Nous allons procéder au paiement!");
                        //PayDrink();
                        break;
                    case "2":
                        Console.WriteLine("Nous allons procéder à l'ajout du suppleément !");
                        //AddOption();
                        break;
                    default:
                        break;
                }
            }
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

        static void PriceWithOption (int drink)
        {
            if (drink == 1)
            {
                Console.WriteLine("Le prix de votre café s'eélève maintenant à 2euros.");
                GiveOrPay();
                return;
            }
            if (drink == 2)
            {
                Console.WriteLine("Le prix de votre thé s'eélève maintenant à 1,70euros.");
                GiveOrPay();
                return;
            }
            if (drink == 3)
            {
                Console.WriteLine("Le prix de votre thé s'eélève maintenant à 3euros.");
                GiveOrPay();
                return;
            }
        }

        static void GiveOrPay()
        {
            Console.WriteLine("Taper 1 pour payer ou taper 2 annuler");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Nous allons procéder au paiement!");
                    //PayDrink();
                    break;
                case "2":
                    Console.WriteLine("Vous ne souhaitez plus de boissons ? Dommage !");
                    //SelectDrink();
                    break;
                default:
                    break;
            }
        }
    }
}
