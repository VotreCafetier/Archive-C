using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validationCourriel
{
    class Program
    {
        static void Main(string[] args)
        {
            //VAR
            string sMAIL;

            //REQUETE de l'adresse
            Console.WriteLine("Veuillez entrer votre adresse courriel : ");
            sMAIL = Console.ReadLine();

            //DEBUT de la boucle de verification
            while ((sMAIL.Contains("@") && sMAIL.Contains(".")) == false)
            {
                //REQUETE de l'adresse
                Console.WriteLine("Veuillez entrer votre adresse courriel : ");
                sMAIL = Console.ReadLine();
            }

            //COUEUR TEXTE = VERT
            Console.ForegroundColor = ConsoleColor.Green;

            //AFFICHER
            Console.WriteLine("Votre adresse est valide");
            Console.ReadLine();
        }
    }
}
