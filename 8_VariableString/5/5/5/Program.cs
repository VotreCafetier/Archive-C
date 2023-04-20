using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation des var
            string sD = "";

            //Requete nom d'utilisateur
            Console.WriteLine("Veuillez entrer votre nom : ");
            sD = Console.ReadLine();

            sD = sD.Replace("e", "3");
            sD = sD.Replace("i", "1");
            sD = sD.Replace("s", "$");

            Console.WriteLine(sD);
            Console.ReadLine();
        }
    }
}
