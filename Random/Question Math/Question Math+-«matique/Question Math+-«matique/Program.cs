using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question_Mathématique
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            Random rnd = new Random();
            int createS = rnd.Next(1, 5);
            string signe = "";

            if (createS == 1)
            {
                signe = "+";
            }

            else if (createS == 2)
            {
                signe = "-";
            }

            else if (createS == 3)
            {
                signe = "*";
            }

            else
            {
                signe = "/";
            }

            int Nb1 = rnd.Next(0, 101);

            int Nb2 = rnd.Next(0, 101);
            int R, iB, iM = 0;
            double dR = 0;
            int NbQ, compteur = 0;

            Console.ForegroundColor = ConsoleColor.White;

            //Requete
            Console.WriteLine("Combien de question voulez-vous répondre ? : ");
            while (int.TryParse(Console.ReadLine(), out NbQ) == false)
            {
                Console.WriteLine("Combien de question voulez-vous répondre ? : ");
            }

            while (compteur != NbQ )
            {
                Console.Write(Nb1 + " " + signe + " " + Nb2 + " = ");
                while (double.TryParse(Console.ReadLine(), out dR) == false)
                {
                    Console.Clear();
                    Console.Write(Nb1 + " " + signe + " " + Nb2 + " = ");
                }

                compteur += 1;

                if (dR == R)
                {
                    iB += 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                else
                {
                    iM += 1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("C'était " + R);
                }
            }

            Console.WriteLine("Votre pourcentage de réussite est de " + (iB / iM * 100) + " %");
            Console.ReadLine();
        }
    }
}
