using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            string sNom;

            //requete nom utilisateur
            Console.WriteLine("Veuillez entrer votre nom : ");
            sNom = Console.ReadLine();

            //Remplacer
            sNom = sNom.Replace("i", "1");
            sNom = sNom.Replace("s", "$");
            sNom = sNom.Replace("e", "3");

            //Afficher
            Console.WriteLine(sNom);
            Console.ReadLine();
        }
    }
}
