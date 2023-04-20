using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02___Convertisseur
{
    class Program
    {
        static void Main(string[] args)
        {
            int iMenu = 0;

        Menu:

            //Menu Principal
            Console.Clear();
            Console.WriteLine("____________Menu____________");
            Console.WriteLine("1. Livres en Kilogrammes");
            Console.WriteLine("2- Kilogrammes en Livres");
            Console.WriteLine("3. Fahrenheit en Celsius");
            Console.WriteLine("4. Celsius en Fahrenheit");
            Console.WriteLine("5. Mètres en Pieds");
            Console.WriteLine("6. Pieds en Mètres");
            Console.WriteLine("7. Centimètres en Pouces");
            Console.WriteLine("8. Pouces en Centimètres");
            Console.WriteLine("9. Litres en Gallons");
            Console.WriteLine("10. Gallons en litres");

            //requete Menu principal
            Console.WriteLine();
            Console.Write("Que voulez-vous faire ? : ");
            while (int.TryParse(Console.ReadLine(), out iMenu) == false && (iMenu >= 1 && iMenu <= 10) == false)
                {
                    Console.Clear();
                    Console.WriteLine("____________Menu____________");
                    Console.WriteLine("1. Livres en Kilogrammes");
                    Console.WriteLine("2- Kilogrammes en Livres");
                    Console.WriteLine("3. Fahrenheit en Celsius");
                    Console.WriteLine("4. Celsius en Fahrenheit");
                    Console.WriteLine("5. Mètres en Pieds");
                    Console.WriteLine("6. Pieds en Mètres");
                    Console.WriteLine("7. Centimètres en Pouces");
                    Console.WriteLine("8. Pouces en Centimètres");
                    Console.WriteLine("9. Litres en Gallons");
                    Console.WriteLine("10. Gallons en litres");
                    Console.WriteLine();

                    Console.Write("Que voulez-vous faire ? : ");
                }

            //Livre en Kilo
            if (iMenu == 1)
            {
                    double dN, dR = 0;
                    string sBoucle = "";

                LK:
                    Console.Clear();
                    Console.WriteLine("Livre en Kilo :");
                    Console.Write("Donner la mesure (Livre) : ");
                    while (double.TryParse(Console.ReadLine(), out dN) == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Livre en Kilo :");
                        Console.Write("Donner la mesure (Livre) : ");
                    }

                    dR = dN / 2.2046;

                    Console.WriteLine(dN + " en Kilo : " + dR);
                    Console.ReadLine();

                    calcul:
                    Console.WriteLine("Voulez-vous refaire un autre calcul ? : ");
                    sBoucle = Console.ReadLine();

                    if (sBoucle == "oui" || sBoucle == "Oui" || sBoucle == "O" || sBoucle == "o" || sBoucle == "OUI")
                    {
                        goto LK;
                    }

                    else if (sBoucle == "non" || sBoucle == "NON" || sBoucle == "N" || sBoucle == "n" || sBoucle == "NON")
                    {
                        return;
                    }

                    else
                    {
                        goto calcul;
                    }
            }

            //Kilo en livre
            else if (iMenu == 2)
            {
                double dN, dR = 0;
                string sBoucle = "";

                KL:
                    Console.Clear();
                    Console.WriteLine("Kilo en Livre :");
                    Console.Write("Donner la mesure (Kilo) : ");
                    while (double.TryParse(Console.ReadLine(), out dN) == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Kilo en Livre :");
                        Console.Write("Donner la mesure (Kilo) : ");
                    }

                    dR = dN * 2.2046;

                    Console.WriteLine(dN + " en Livre : " + dR);
                    Console.ReadLine();

                    calcul:
                    Console.WriteLine("Voulez-vous refaire un autre calcul ? : ");
                    sBoucle = Console.ReadLine();

                    if (sBoucle == "oui" || sBoucle == "Oui" || sBoucle == "O" || sBoucle == "o" || sBoucle == "OUI")
                    {
                        goto KL;
                    }

                    else if (sBoucle == "non" || sBoucle == "NON" || sBoucle == "N" || sBoucle == "n" || sBoucle == "NON")
                    {
                        return;
                    }

                    else
                    {
                        goto calcul;
                    }
            }

            //Fahrenheit en Celsius
            else if (iMenu == 3)
            {
                double dN, dR = 0;
                string sBoucle = "";

            FC:
                Console.Clear();
                Console.WriteLine("Fahrenheit en Celsius :");
                Console.Write("Donner la mesure (Fahrenheit) : ");
                while (double.TryParse(Console.ReadLine(), out dN) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Fahrenheit en Celsius :");
                    Console.Write("Donner la mesure (Fahrenheit) : ");
                }

                dR = (dN - 32) * 5 / 9;

                Console.WriteLine(dN + " en Celsius : " + dR);
                Console.ReadLine();

            calcul:
                Console.WriteLine("Voulez-vous refaire un autre calcul ? : ");
                sBoucle = Console.ReadLine();

                if (sBoucle == "oui" || sBoucle == "Oui" || sBoucle == "O" || sBoucle == "o" || sBoucle == "OUI")
                {
                    goto FC;
                }

                else if (sBoucle == "non" || sBoucle == "NON" || sBoucle == "N" || sBoucle == "n" || sBoucle == "NON")
                {
                    return;
                }

                else
                {
                    goto calcul;
                }
            }

            //Celsius en Fahrenheit
            else if (iMenu == 4)
            {
                double dN, dR = 0;
                string sBoucle = "";

            FC:
                Console.Clear();
                Console.WriteLine("Celsius en Fahrenheit :");
                Console.Write("Donner la mesure (Celsius) : ");
                while (double.TryParse(Console.ReadLine(), out dN) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Celsius en Fahrenheit :");
                    Console.Write("Donner la mesure (Celsius) : ");
                }

                dR = (dN * 9/5) + 32;

                Console.WriteLine(dN + " en Fahrenheit : " + dR);
                Console.ReadLine();

            calcul:
                Console.WriteLine("Voulez-vous refaire un autre calcul ? : ");
                sBoucle = Console.ReadLine();

                if (sBoucle == "oui" || sBoucle == "Oui" || sBoucle == "O" || sBoucle == "o" || sBoucle == "OUI")
                {
                    goto FC;
                }

                else if (sBoucle == "non" || sBoucle == "NON" || sBoucle == "N" || sBoucle == "n" || sBoucle == "NON")
                {
                    return;
                }

                else
                {
                    goto calcul;
                }
            }

            //Mètre en Pieds
            else if (iMenu == 5)
            {
                double dN, dR = 0;
                string sBoucle = "";

            MP:
                Console.Clear();
                Console.WriteLine("Mètre en Pieds :");
                Console.Write("Donner la mesure (Mètre) : ");
                while (double.TryParse(Console.ReadLine(), out dN) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Mètre en Pieds :");
                    Console.Write("Donner la mesure (Mètre) : ");
                }

                dR = dN * 3.281;

                Console.WriteLine(dN + " en Pieds : " + dR);
                Console.ReadLine();

            calcul:
                Console.WriteLine("Voulez-vous refaire un autre calcul ? : ");
                sBoucle = Console.ReadLine();

                if (sBoucle == "oui" || sBoucle == "Oui" || sBoucle == "O" || sBoucle == "o" || sBoucle == "OUI")
                {
                    goto MP;
                }

                else if (sBoucle == "non" || sBoucle == "NON" || sBoucle == "N" || sBoucle == "n" || sBoucle == "NON")
                {
                    return;
                }

                else
                {
                    goto calcul;
                }
            }

            //Pieds en Metre
            else if (iMenu == 6)
            {
                double dN, dR = 0;
                string sBoucle = "";

            PM:
                Console.Clear();
                Console.WriteLine("Pieds en Mètre:");
                Console.Write("Donner la mesure (Pieds) : ");
                while (double.TryParse(Console.ReadLine(), out dN) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Pieds en Mètre:");
                    Console.Write("Donner la mesure (Pieds) : ");
                }

                dR = dN / 3.281;

                Console.WriteLine(dN + " en Mètre : " + dR);
                Console.ReadLine();

            calcul:
                Console.WriteLine("Voulez-vous refaire un autre calcul ? : ");
                sBoucle = Console.ReadLine();

                if (sBoucle == "oui" || sBoucle == "Oui" || sBoucle == "O" || sBoucle == "o" || sBoucle == "OUI")
                {
                    goto PM;
                }

                else if (sBoucle == "non" || sBoucle == "NON" || sBoucle == "N" || sBoucle == "n" || sBoucle == "NON")
                {
                    return;
                }

                else
                {
                    goto calcul;
                }
            }

            //cm en p
            else if (iMenu == 7)
            {
                double dN, dR = 0;
                string sBoucle = "";

            CP:
                Console.Clear();
                Console.WriteLine("Centimètres en Pouces:");
                Console.Write("Donner la mesure (Centimètres) : ");
                while (double.TryParse(Console.ReadLine(), out dN) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Centimètres en Pouces:");
                    Console.Write("Donner la mesure (Centimètres) : ");
                }

                dR = dN / 2.54;

                Console.WriteLine(dN + " en Pouces : " + dR);
                Console.ReadLine();

            calcul:
                Console.WriteLine("Voulez-vous refaire un autre calcul ? : ");
                sBoucle = Console.ReadLine();

                if (sBoucle == "oui" || sBoucle == "Oui" || sBoucle == "O" || sBoucle == "o" || sBoucle == "OUI")
                {
                    goto CP;
                }

                else if (sBoucle == "non" || sBoucle == "NON" || sBoucle == "N" || sBoucle == "n" || sBoucle == "NON")
                {
                    return;
                }

                else
                {
                    goto calcul;
                }
            }

            //p en cm
            else if (iMenu == 8)
            {
                double dN, dR = 0;
                string sBoucle = "";

            PC:
                Console.Clear();
                Console.WriteLine("Pouces en Centimètres :");
                Console.Write("Donner la mesure (Pouces) : ");
                while (double.TryParse(Console.ReadLine(), out dN) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Pouces en Centimètres :");
                    Console.Write("Donner la mesure (Pouces) : ");
                }

                dR = dN * 2.54;

                Console.WriteLine(dN + " en Centimètres : " + dR);
                Console.ReadLine();

            calcul:
                Console.WriteLine("Voulez-vous refaire un autre calcul ? : ");
                sBoucle = Console.ReadLine();

                if (sBoucle == "oui" || sBoucle == "Oui" || sBoucle == "O" || sBoucle == "o" || sBoucle == "OUI")
                {
                    goto PC;
                }

                else if (sBoucle == "non" || sBoucle == "NON" || sBoucle == "N" || sBoucle == "n" || sBoucle == "NON")
                {
                    return;
                }

                else
                {
                    goto calcul;
                }
            }

            //L en Gallons
            else if (iMenu == 9)
            {
                double dN, dR = 0;
                string sBoucle = "";

            LG:
                Console.Clear();
                Console.WriteLine("Litres en Gallons:");
                Console.Write("Donner la mesure (Litres) : ");
                while (double.TryParse(Console.ReadLine(), out dN) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Litres en Gallons:");
                    Console.Write("Donner la mesure (Litres) : ");
                }

                dR = dN / 3.785;

                Console.WriteLine(dN + " en Gallons : " + dR);
                Console.ReadLine();

            calcul:
                Console.WriteLine("Voulez-vous refaire un autre calcul ? : ");
                sBoucle = Console.ReadLine();

                if (sBoucle == "oui" || sBoucle == "Oui" || sBoucle == "O" || sBoucle == "o" || sBoucle == "OUI")
                {
                    goto LG;
                }

                else if (sBoucle == "non" || sBoucle == "NON" || sBoucle == "N" || sBoucle == "n" || sBoucle == "NON")
                {
                    return;
                }

                else
                {
                    goto calcul;
                }
            }

            //Gallons en Litres
            else if (iMenu == 10)
            {
                double dN, dR = 0;
                string sBoucle = "";

            GL:
                Console.Clear();
                Console.WriteLine("Gallons en Litres :");
                Console.Write("Donner la mesure (Gallons) : ");
                while (double.TryParse(Console.ReadLine(), out dN) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Gallons en Litres :");
                    Console.Write("Donner la mesure (Gallons) : ");
                }

                dR = dN * 3.785;

                Console.WriteLine(dN + " en Litres : " + dR);
                Console.ReadLine();

            calcul:
                Console.WriteLine("Voulez-vous refaire un autre calcul ? : ");
                sBoucle = Console.ReadLine();

                if (sBoucle == "oui" || sBoucle == "Oui" || sBoucle == "O" || sBoucle == "o" || sBoucle == "OUI")
                {
                    goto GL;
                }

                else if (sBoucle == "non" || sBoucle == "NON" || sBoucle == "N" || sBoucle == "n" || sBoucle == "NON")
                {
                    return;
                }

                else
                {
                    goto calcul;
                }
            }
            goto Menu;
        }
    }
}