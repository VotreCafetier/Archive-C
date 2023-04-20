using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Premiere exercice
            string espace = "";

            //creation boucle for ajoute un espace
            for (int i = 0; i != 10; i++)
            {
                Console.WriteLine(espace + i);
                espace += " ";
            }

            //ouvre la console en debug
            Console.WriteLine("Voir l'exercice suivant");
            Console.ReadLine();
            Console.Clear();

            //deuxieme exercice
            //meme chose qu'en haut
            for (int i = 0; i != 11; i++)
            {
                for (int ii = 0; i != ii; ii++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(i);
            }

            for (int i = 9; i != 0; i--)
            {
                for (int ii = 0; i != ii; ii++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(i);
            }

            //enleve espace
            
            Console.WriteLine("Voir l'exercice suivant");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
