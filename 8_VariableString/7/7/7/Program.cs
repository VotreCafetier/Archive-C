using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string sAddress;
            
            //REQUETE Adresse courriel utilisateur
            Console.WriteLine("Veuillez entrer une adresse courriel");
            sAddress = Console.ReadLine();

            //Debut boucle de verification du courriel
            while (sAddress.Contains("@") && sAddress.Length - 4 != sAddress.IndexOf("."))
            { 
                //COULEUR TEXTE = rouge
                Console.ForegroundColor = ConsoleColor.Red;

                //REQUETE Adresse courriel
                Console.WriteLine("Veuillez entrer une adresse courriel valide");

                //COULEUR TEXTE = blanc
                Console.ForegroundColor = ConsoleColor.White;
                sAddress = Console.ReadLine();
            }

            //COULEUR TEXTE = vert
            Console.ForegroundColor = ConsoleColor.Green;

            //AFFICHER sAddress
            Console.WriteLine(sAddress);
            Console.ReadLine();
        }
    }
}
