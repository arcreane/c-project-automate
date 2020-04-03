using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour ! Ça farte ?");
            Console.WriteLine("Tu veux quoi pour l'apero ?");
            Console.WriteLine("Tape 1 pour un café, tape 2 pour un thé et tape 3 pour une soupe");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1": 
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Je n'ai pas compris votre demande, réessayez");
                    break;
            }
        }
    }
}


 //  _
 //`(_)D