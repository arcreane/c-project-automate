
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
            bool myPassword = true;

            do
            {
                
                Console.WriteLine("Tapez 1234 pour le mot de passe");
                string motDePasse = Console.ReadLine();
                if (motDePasse == "1234")
                {
                    Console.WriteLine("Mot de passe accept�");
                    Console.WriteLine("Votre boisson sera prepar�e, Merci!");
                    myPassword = false;
                }
                else
                {
                    Console.WriteLine("Mot de passe invalide, veillez r�essayer");
                    
                }

            } while (myPassword == true);
            
        }

       
    }
}
