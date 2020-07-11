using System;
using System.Collections.Generic;

namespace Gra
{
    public class Class1
    {

        private static Random random = new Random();
        public static void druk(List<string> lista)
        {


            Console.Write("{0} | {1} | {2} \n", lista[0], lista[1], lista[2]);
            Console.Write("- + - + - \n");
            Console.Write("{0} | {1} | {2} \n", lista[3], lista[4], lista[5]);
            Console.Write("- + - + - \n");

            Console.Write("{0} | {1} | {2} \n", lista[6], lista[7], lista[8]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


        }
        public static void drukcyfry(List<int> lista)
        {


            Console.Write(" {0}  |  {1}  |  {2}  \n", lista[0], lista[1], lista[2]);
            Console.Write("--- + --- + --- \n");
            Console.Write(" {0}  |  {1}  |  {2}  \n", lista[3], lista[4], lista[5]);
            Console.Write("--- + --- + --- \n");
            Console.Write(" {0}  |  {1}  |  {2}  \n", lista[6], lista[7], lista[8]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
        public static string znakkomputera(string znakgracza)
        {
            string znakkomp = " ";
            if (znakgracza == "X")
            {
                znakkomp = "O";
            }
            else
            {
                znakkomp = "X";
            }
            return znakkomp;
        }

        public static string gracz()
        {
            string znakgracza = " ";
            do
            {
                Console.WriteLine("Wybierz znak X lub O");
                znakgracza = Console.ReadLine();
            } while (znakgracza != "X" && znakgracza != "O");
            return znakgracza;



        }
        public static int punkt()

        {
            int pole = 9999;
            do
            {
                pole = Convert.ToInt32(Console.ReadLine());

            } while (pole > 9 && pole < 1);
            return pole;
        }
        public static int komputer(List<string> lista)
        {
            List<int> array1 = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (lista[i] == " ")
                {
                    array1.Add(i);
                }

            }

            int index = random.Next(array1.Count);
            return index;

        }
        public static bool wynik(List<string> lista)
        {
            bool koniec = false;
            for (int i = 0; i < 9; i++)
            {
                if (lista[i] == " ")
                {
                    koniec = true;


                }

            }
            if (!koniec)
            {
                Console.WriteLine(" Remis ");

            }
            return koniec;
        }
        public static bool poziomo(List<string> lista, string znakgracza)
        {
            string znakkomp = znakkomputera(znakgracza);
            bool koniec = true;
            if (lista[0] == znakgracza && lista[1] == znakgracza && lista[2] == znakgracza)
            {
                Console.WriteLine(" Wygraleś ");
                koniec = false;
            }
            if (lista[3] == znakgracza && lista[4] == znakgracza && lista[5] == znakgracza)
            {
                Console.WriteLine(" Wygraleś ");
                koniec = false;
            }
            if (lista[6] == znakgracza && lista[7] == znakgracza && lista[8] == znakgracza)
            {
                Console.WriteLine(" Wygraleś ");
                koniec = false;
            }
            if (lista[0] == znakkomp && lista[1] == znakkomp && lista[2] == znakkomp)
            {
                Console.WriteLine(" Przegrałeś ");
                koniec = false;
            }
            if (lista[3] == znakkomp && lista[4] == znakkomp && lista[5] == znakkomp)
            {
                Console.WriteLine(" Przegrałeś ");
                koniec = false;
            }
            if (lista[6] == znakkomp && lista[7] == znakkomp && lista[8] == znakkomp)
            {
                Console.WriteLine(" Przegrałeś ");
                koniec = false;
            }
            return koniec;
        }
        public static bool pionowo(List<string> lista, string znakgracza)
        {
            string znakkomp = znakkomputera(znakgracza);
            bool koniec = true;
            if (lista[0] == znakgracza && lista[3] == znakgracza && lista[6] == znakgracza)
            {
                Console.WriteLine(" Wygraleś ");
                koniec = false;
            }
            if (lista[1] == znakgracza && lista[4] == znakgracza && lista[7] == znakgracza)
            {
                Console.WriteLine(" Wygraleś ");
                koniec = false;
            }
            if (lista[2] == znakgracza && lista[5] == znakgracza && lista[8] == znakgracza)
            {
                Console.WriteLine(" Wygraleś ");
                koniec = false;
            }
            if (lista[0] == znakkomp && lista[3] == znakkomp && lista[6] == znakkomp)
            {
                Console.WriteLine(" Przegrałeś ");
                koniec = false;
            }
            if (lista[1] == znakkomp && lista[4] == znakkomp && lista[7] == znakkomp)
            {
                Console.WriteLine(" Przegrałeś ");
                koniec = false;
            }
            if (lista[2] == znakkomp && lista[5] == znakkomp && lista[8] == znakkomp)
            {
                Console.WriteLine(" Przegrałeś ");
                koniec = false;
            }
            return koniec;
        }
        public static bool skos(List<string> lista, string znakgracza)
        {
            string znakkomp = znakkomputera(znakgracza);
            bool koniec = true;
            if (lista[0] == znakgracza && lista[4] == znakgracza && lista[8] == znakgracza)
            {
                Console.WriteLine(" Wygraleś ");
                koniec = false;
            }
            if (lista[6] == znakgracza && lista[4] == znakgracza && lista[2] == znakgracza)
            {
                Console.WriteLine(" Wygraleś ");
                koniec = false;
            }
            if (lista[0] == znakkomp && lista[4] == znakkomp && lista[8] == znakkomp)
            {
                Console.WriteLine(" Przegrałeś ");
                koniec = false;
            }
            if (lista[6] == znakkomp && lista[4] == znakkomp && lista[2] == znakkomp)
            {
                Console.WriteLine(" Przegrałeś ");
                koniec = false;
            }
            return koniec;

        }
    }
}
