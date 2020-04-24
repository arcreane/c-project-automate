
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
            if (resp == "O")
            {
                Console.WriteLine("Insérer le code de votre carte");
                
                Console.WriteLine("Paiement accepté");

                return true;
            }

            return false;
        }
    }
}
