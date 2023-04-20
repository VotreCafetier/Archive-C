using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation du random
            Random rHazard = new Random();

            //random entre 1 et 100
            int iHazard = rHazard.Next(1, 101);

            //Reponse
            double dR = 0;

            //Nombre d'essai
            int iEssai = 0;

            //recommencer
            string sAGN = "";

            //boucle pour recommencer
            while ((sAGN == "non" || sAGN == "NON" || sAGN == "Non" || sAGN == "N" || sAGN == "n") == false)
            {
                //boucle de verification si la reponse est la meme que iHazard
                while ((dR == iHazard) == false)
                {
                    //Requete pour le nombre
                    Console.WriteLine("Veuillez deviner le nombre : ");

                    //boucle message d'erreur si joueur n'entre pas un chiffre
                    while (double.TryParse(Console.ReadLine(), out dR) == false)
                    {
                        Console.WriteLine("Veuillez deviner le nombre : ");
                    }

                    //ajout d'essai
                    iEssai += 1;

                    //si nombre est plus petit
                    if (dR < iHazard)
                    {
                        Console.WriteLine("Plus!");
                    }

                    //si nombre plus grand
                    else if (dR > iHazard)
                    {
                        Console.WriteLine("Moins!");
                    }
                }

                //message de reussite & si boucle de recommencement
                Console.WriteLine("Vous avez deviné ! Vous avez essayé " + iEssai + " fois ! Voulez-vous rejouer ?");
                sAGN = Console.ReadLine();
            }
        }
    }
}
