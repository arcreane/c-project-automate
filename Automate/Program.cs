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
        static Drink currentDrink;
        static void Main(string[] args)
        {
            //Permetttre avec une boucle de choisir plusieurs boissons
            Console.WriteLine("Bonjour ! Ça farte ?");
            selectDrink();
            PaymentManagement();
            currentDrink.PreparationDrink();
            pickUpDrink();
        }

        static void PaymentManagement()
        {
            //Combien ca coute
            //est ce que vous voulez des suppléments...

            //Comment vous voulez payer etc...
            receivePayment(null/*on remplace null par la méthode séléctionnée*/);
        }

        /// <summary>
        /// @param payment
        /// </summary>
        public static void receivePayment(PaymentMethod payment)
        {
            // TODO implement here
        }

        public static void selectDrink()
        {
            Console.WriteLine("Tu veux quoi pour l'apero ?");
            Console.WriteLine("Tape 1 pour un café, tape 2 pour un thé et tape 3 pour une soupe");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    currentDrink = new Coffee();
                    break;
                case "2":
                    currentDrink = new Tea();
                    break;
                case "3":
                    currentDrink = new Tomato();
                    break;
                default:
                    Console.WriteLine("Je n'ai pas compris votre demande, réessayez");
                    break;
            }
           
        }

        public static void pickUpDrink()
        {
            // TODO implement here
        }
    }
}


 //  _
 //`(_)D