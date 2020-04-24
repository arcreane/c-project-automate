using System;
namespace Automate.Payment
{
    public class Cash : PaymentMethod
    {

        public Cash()
        {
        }
        public override void Pay(decimal PriceDrink)
        {
            string payment;
            Console.WriteLine("S'il vous plaît insérer de l'argent");
            payment = Console.ReadLine();

            value = Convert.ToDecimal(payment);
            givenValue = givenValue + value;


            if (givenValue < PriceDrink)
            {
                decimal manque = PriceDrink - givenValue;
                Console.WriteLine("Valeur insérer " + givenValue + " euros");
                Console.WriteLine("S'il vous plaît insérer le montant manquant : " + manque);
                
               
                payment = Console.ReadLine();
                value = Convert.ToDecimal(payment);

                //value = Convert.ToDecimal(Console.ReadLine());
                Pay(PriceDrink);

            }

            else if (givenValue > PriceDrink)
            {
                decimal resultado = givenValue - PriceDrink;
                Console.WriteLine("Prenez votre monnaie " + resultado + " euros");
                Console.WriteLine("Votre boisson sera preparée!");
                Console.WriteLine("Merci!");
            }

            else
            {
                Console.WriteLine("Votre boisson sera preparée!");
                Console.WriteLine("Merci!");
            }


            //throw new NotImplementedException();
        }

        public override void Refund()
        {
            Console.WriteLine(value + " € en pièce retombent dans le receptacle");
        }


    }
}
