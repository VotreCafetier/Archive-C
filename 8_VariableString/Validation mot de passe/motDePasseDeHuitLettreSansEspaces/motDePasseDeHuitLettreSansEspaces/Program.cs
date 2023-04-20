using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motDePasseDeHuitLettreSansEspaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            string sMDP;

            //REQUETE du mot de passe
            Console.WriteLine("Veuillez entrer un mot de passe");
            sMDP = Console.ReadLine();

            //DEBUT boucle de confirmation
            while (sMDP.Length < 8 && sMDP == sMDP.Trim())
            {
                //REQUETE du mot de passe
                Console.WriteLine("Veuillez entrer un mot de passe");
                sMDP = Console.ReadLine();
            }

            //COULEUR AFFICHAGE = VERT
            Console.ForegroundColor = ConsoleColor.Green;

            //AFFICHER sMDP
            Console.WriteLine(sMDP);
            Console.ReadLine();
        }
    }
}
