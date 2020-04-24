
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
            Console.WriteLine("Ins�rer votre carte SVP O / N");
            string resp = Console.ReadLine();
            if (string.Equals(resp, "O", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ins�rer le code de votre carte");
                
                Console.WriteLine("Paiement accept�");

                return true;
            }

            return false;
        }

        public override void Refund()
        {
            Console.WriteLine(value + " � a �t� recr�dit� sur votre compte en banque");
        }
    }
}
