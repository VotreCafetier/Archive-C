using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            string sNom;

            //REQUETE nom utilisateur
            Console.WriteLine("Veuillez entrer votre nom : ");
            sNom = Console.ReadLine();

            //DEBUT SI
            if (sNom.Contains("-"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vous avez un nom composé");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vous n'avez pas de nom composé");
            }

            //Garde la console en mode debug
            Console.ReadLine();
        }
    }
}
