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
            Console.WriteLine("Bonjour ! ?");
            Console.WriteLine("Merci de sélectionner une boisson !");
            Console.WriteLine("Taper 1 pour un café, taper 2 pour un thé et taper 3 pour une soupe");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Voilà votre café !");
                    break;
                case "2":
                    Console.WriteLine("Voilà votre thé !");
                    break;
                case "3":
                    Console.WriteLine("Voilà votre soupe !");
                    break;
                default:
                    Console.WriteLine("Je n'ai pas compris votre demande, réessayez");
                    break;
            }

        }

    }
}
