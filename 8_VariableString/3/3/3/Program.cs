using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation des variables
            string MotDePasse = "";

            //Requete du mot de passe
            Console.WriteLine("Entrer un mot de passe d'au moins 8 charactères sans espaces");
            MotDePasse = Console.ReadLine();
            //Debut boucle de verification si il est d'au moins 8 characteres et sans espace
            while (MotDePasse.Length < 8 && MotDePasse.Contains(" "))
            {
                Console.WriteLine("Entrer un mot de passe d'au moins 8 charactères sans espaces");
                MotDePasse = Console.ReadLine();
            }

            //Couleur texte = vert
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Votre mot de passe est confirmé.");
            Console.ReadLine();
        }
    }
}
