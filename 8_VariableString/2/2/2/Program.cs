using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation de var
            string motDePasse = "";

            //Requete Mot de passe
            Console.WriteLine("Veuillez entrer un mot de passe : ");
            motDePasse = Console.ReadLine();

            //boucle message d'erreur
            while (motDePasse.Length < 8)
            {
                //message boucle
                Console.WriteLine("Veuillez entrer un mot de passe avec MINIMUM 8 caractères : ");
                motDePasse = Console.ReadLine();
            }

            //trimer le mot de passe 
            motDePasse.Trim();

            //changer la couleur de l'ecriture a vert
            Console.ForegroundColor = ConsoleColor.Green;

            //Afficher
            Console.WriteLine("Mot de passe : Confirmé");
            Console.ReadLine();

            //nettoyer l'ecran
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            //creation des var
            double dN = 0;
            string sN = "";

            //REQUETE Nombre
            Console.WriteLine("Veuillez entrer un nombre decimal : ");
            while (double.TryParse(Console.ReadLine(), out dN) == false)
            {
                Console.WriteLine("Veuillez entrer un nombre decimal : ");
            }

            //calcul de 15 %
            dN += (dN * 0.15);

            //conversion double vers string
            dN.ToString(sN);
            //remplacer le point par une virgule
            sN.Replace(".", ",");

            Console.WriteLine(sN);
            Console.ReadLine();
        }
    }
}
