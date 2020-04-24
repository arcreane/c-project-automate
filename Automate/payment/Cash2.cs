using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Automate.Payment
{
    public class Cash : PaymentMethod
    {

        public Cash()
        {
        }
        public override void Pay(Decimal PriceDrink)
        {
            givenValue = givenValue + value;
            

            if (givenValue < PriceDrink)
            {
                Decimal manque = PriceDrink - givenValue;
                Console.WriteLine("Valeur ins�rer " + givenValue + " euros");
                Console.WriteLine("S'il vous pla�t ins�rer le montant manquant : " + manque);
                Console.ReadKey();
                string payment;
                payment = Console.ReadLine();
                value = Convert.ToDecimal(payment);

                //value = Convert.ToDecimal(Console.ReadLine());
                Pay(PriceDrink);


            }

            else if (givenValue > PriceDrink)
            {
                Decimal resultado = givenValue - PriceDrink;
                Console.WriteLine("Prenez votre monnaie " + resultado + " euros");
                Console.WriteLine("Votre boisson sera prepar�e!");
                Console.WriteLine("Merci!");
            }

            else
          {
                Console.WriteLine("Votre boisson sera prepar�e!");
                Console.WriteLine("Merci!");
            }
            

            //throw new NotImplementedException();
        }

      
    }
}
