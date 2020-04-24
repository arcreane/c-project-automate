using System;
namespace Automate.Payment
{
    public class Cash : PaymentMethod
    {

        public Cash()
        {
        }
        public override bool Pay(decimal price)
        {
            int total = 0;
            do
            {
                Console.WriteLine("Si vous voulez payer taper 1 pour pièces ou 2 pour billet 3 pour annuler?");
                string resp = Console.ReadLine();
                switch (resp)
                {
                    case "1":
                        Console.WriteLine("Veuillez insérer une ou plusieurs piéce de 5, 10, 20, 50 centimes, 1 ou 2 euro (séparé par espace)");
                        string cash = Console.ReadLine();
                        string[] pieces = cash.Split(' ');

                        if (pieces.Length > 0)
                        {
                            foreach (var item in pieces)
                            {
                                if (int.TryParse(item, out int piece))
                                {
                                    if (piece == 1 || piece == 2)
                                    {
                                        total += piece * 100;
                                    }
                                    else if (piece == 5 || piece == 10 || piece == 20 || piece == 50)
                                    {
                                        total += piece;
                                    }
                                }
                            }
                        }
                        
                        break;

                    case "2":
                        Console.WriteLine("Veuillez insérer un billet de 5, 10, 20 euros");
                        string cashBillet= Console.ReadLine();
                        switch (cashBillet)
                        {
                            case "5":
                                total += 500;
                                break;
                            case "10":
                                total += 1000;
                                break;
                            case "20":
                                total += 2000;
                                break;
                            default:
                                break;
                        }
                        break;

                    case "3":
                        if (total > 0)
                        {
                            Console.WriteLine("Veuillez récupérer votre monnaie {0} euro", total / 100);
                            return true;
                        }
                        return false;

                    default:
                        Console.WriteLine("Choix invalide");
                        break;
                }

                if (total < price * 100)
                {
                    Console.WriteLine("il vous manque {0} euro", (price * 100 - total) / 100);
                }

                if (total == price * 100)
                {
                    return true;
                }

                if (total > price * 100)
                {
                    Console.WriteLine("Veuillez récupérer votre monnaie {0} euro dans le receptacle", (total - price * 100) / 100);
                    return true;
                }


            } while (true);
        }
    }
}
