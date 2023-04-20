using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string sN;

            //REQUETE du nom de l'utilisateur
            Console.WriteLine("Veuillez entrez votre nom : ");
            sN = Console.ReadLine();

            //METTRE sN en Maj
            sN = sN.ToUpper();

            //AFFICHER resultat
            Console.WriteLine(sN);
            Console.ReadLine();

            //Nettoyer
            Console.Clear();

            //Deuxieme exercice

            //REQUETE adresse courriel de l'utilisateur
            Console.WriteLine("Veuillez entrer votre adresse courriel");
            sN = Console.ReadLine();

            //debut boucle de verification
            while ((sN.Contains("@") && sN.Contains(".")) == false)
            {
                //COULEUR TEXTE Rouge
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Veuillez entrer une adresse courriel valide");
                //COULEUR TEXTE Blanc
                Console.ForegroundColor = ConsoleColor.White;
                sN = Console.ReadLine();
            }

            //COULEUR TEXTE Vert
            Console.ForegroundColor = ConsoleColor.Green;

            //AFFICHER sN
            Console.WriteLine(sN);
            Console.ReadLine();
        }
    }
}
