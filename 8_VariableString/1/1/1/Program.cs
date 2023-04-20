using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation de la var
            string motDePasse = "";

            //Requete de motDePasse
            Console.WriteLine("Entrer un mot de passe d'au moins 8 caractères");
            motDePasse = Console.ReadLine();

            //Boucle d'erreur si motDePasse est moins de 8 lettres
            while (motDePasse.Length < 8)
            {
                //message d'erreur
                Console.WriteLine("ERREUR - Entrer un mot de passe d'au moins 8 caractères");
                motDePasse = Console.ReadLine();
            }

            //Changer la couleur de la console a vert
            Console.ForegroundColor = ConsoleColor.Green;

            //Afficher
            Console.WriteLine("Votre mot de passe est confirmé");
            Console.ReadLine();
        }
    }
}
