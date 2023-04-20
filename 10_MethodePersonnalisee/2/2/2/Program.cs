using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //VAR
            string sM, temp;

            //REQUETE mot
            Console.WriteLine("Veuillez entrer un mot : ");
            sM = Console.ReadLine();

            //DEBUT boucle for
            for (int i = 0; i < sM.Length; i++)
            {

                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            //AFFICHER
            Console.WriteLine(sM);
            Console.ReadLine();
        }
    }
}
