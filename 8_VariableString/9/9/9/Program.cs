using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            //VAR
            string sNom, temp;

            //REQUETE du nom de lutilisateur
            Console.WriteLine("Quel est votre nom : ");
            sNom = Console.ReadLine();

            //prendre le premier charactere le met en maj et le met dans temp
            temp = sNom.First().ToString().ToUpper();

            //enleve le premier charactere de sNom
            temp = temp + sNom;
            temp = temp.Remove(1,1);
            //Affiche le resultat
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp.First() == temp[i])
                {
                    temp[i].ToString().ToUpper();
                }
            }

            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
