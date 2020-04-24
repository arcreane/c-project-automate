
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Automate.Payment
{
    public class Card : PaymentMethod
    {

        public Card()
        {
        }

        public override void Pay(decimal PriceDrink)
        {
            Console.WriteLine("S'il vous plaît insérer la carte, appuyez sur une touche quand c'est bon");
            Console.ReadKey();

            bool myPassword = true;

            do
            {
                
                Console.WriteLine("Tapez 1234 pour le mot de passe");
                string motDePasse = Console.ReadLine();
                if (motDePasse == "1234")
                {
                    Console.WriteLine("Mot de passe accepté");
                    Console.WriteLine("Votre boisson sera preparée, Merci!");
                    myPassword = false;
                }
                else
                {
                    Console.WriteLine("Mot de passe invalide, veillez réessayer");
                    
                }

            } while (myPassword == true);
            
        }

        public override void Refund()
        {
            Console.WriteLine(value + " € a été recrédité sur votre compte en banque");
        }
    }
}
