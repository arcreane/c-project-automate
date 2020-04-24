
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

        public override bool Pay(decimal price)
        {
            Console.WriteLine("Insérer votre carte SVP O / N");
            string resp = Console.ReadLine();
            if (string.Equals(resp, "O", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Insérer le code de votre carte");
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

                Console.WriteLine("Paiement accepté");

                return true;
            }

            return false;
        }
    }
}
