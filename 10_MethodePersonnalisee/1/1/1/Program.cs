using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Program
    {
        //Methode pour afficher le tableau
        static void AfficherTableau(string[] sTableau)
        {
            for (int i = 0; i != sTableau.Length; i++)
            {
                    Console.WriteLine(sTableau[i]);
            }

        }
        
        //Methode Principale
        static void Main(string[] args)
        {
            //Var
            //Creation du tableau de 10 case
            string[] TableauUn = new string [10];
            TableauUn[0] = "56";
            TableauUn[1] = "65";
            TableauUn[2] = "42";
            TableauUn[3] = "88";
            TableauUn[4] = "96";
            TableauUn[5] = "48";
            TableauUn[6] = "78";
            TableauUn[7] = "32";
            TableauUn[8] = "11";
            TableauUn[9] = "92";

            //Creation du tableau de 4 case
            string[] TableauDeux = new string[5];
            TableauDeux[0] = "pomme";
            TableauDeux[1] = "banane";
            TableauDeux[2] = "fraise";
            TableauDeux[3] = "kiwi";
            TableauDeux[4] = "orange";

            string R;

            //Requete du tableau
            Console.WriteLine("Quel tableau voulez-vous afficher ?");
            Console.WriteLine("1.Tableau Un");
            Console.WriteLine("2.Tableau Deux");
            R = Console.ReadLine();

            //Verification si une des reponse
            if (R == "1" || R == "Tableau Un" || R == "Un")
            {
                AfficherTableau(TableauUn);
            }

            else if (R == "2" || R == "Tableau Deux" || R == "Deux")
            {
                AfficherTableau(TableauDeux);
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Code d'erreur : 001");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(1);
            }


            Console.ReadLine();
        }
    }
}
