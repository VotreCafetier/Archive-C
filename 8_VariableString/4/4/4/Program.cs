using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation des variables
            string motCache = "anticonstitutionnellement";
            char lettre = 'a';
            int compteur = 0;

            //Requete d<un charactere
            Console.WriteLine("Entrer une lettre");
            lettre = Console.ReadKey().KeyChar;

            //debut boucle for
            for (int i = 0; i < motCache.Length; i++)
            {
                //si il contient la lettre que l'utilisateur a entre
                if (motCache.Contains(lettre))
                {
                    //ajoute 1 a compteur
                    compteur += 1;
                }
            }

            Console.WriteLine("Il y a " + compteur + " " + lettre + " dans le mot " + motCache + ".");
            Console.ReadLine();
        }
    }
}
