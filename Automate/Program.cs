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

    }
}
