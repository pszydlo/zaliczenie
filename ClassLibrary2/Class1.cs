using System;
using System.Collections.Generic;

namespace Gra
{
    public class Class1 // nazwa klasy powinna opisywać co robi / skoro ta klasa jest odpowiedzialna za planszę to niech nie przyjmuje w metodach listy tylko posiada pole listy 
    {

        private static Random random = new Random();
        public static List<string> tworzplansze()  // nazwy metod i zmiennych powinny być po angielsku, i ta metoda tworzy pustą planszę więc nazwę zmienić 
        {
            List<string> plansza = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                plansza.Add(" ");
                
            }
            return plansza;
        }
        public static List<int> tworzplanszecyfry()
        {
            List<int> plansza = new List<int>();
            for (int i = 0; i < 9; i++) //i = 1 : i < 10 
            {
                plansza.Add(i + 1); // wtedy wywal tego i +1
            }
            return plansza;

        }


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
        public static void drukcyfry(List<int> lista) // dwie takie same metody , nie potrzebane 
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
        public static string znakkomputera(string znakgracza) // można zrobić enum na O i X 
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

        public static string gracz() // ta funcja pobier znak od gracza więc może nazwę zmienić  + to enum 
        {
            string znakgracza = " ";
            do
            {
                Console.WriteLine("Wybierz znak X lub O");
                znakgracza = Console.ReadLine();
            } while (znakgracza != "X" && znakgracza != "O");
            return znakgracza;



        }
        public static int punkt(List<int> lista) // tak samo z nazwą 

        {
            int pole = 9999; // nie ma potrzeby inicjalizować jakąkolwiek wartością 
            int cyfra;
            int flag = 0; // skoro flaga to bool 
            do
            {
                flag = 0;
                Console.WriteLine("Wybierz liczbe z tablicy");
                string input = Console.ReadLine();
                bool sukces = Int32.TryParse(input, out cyfra);
                if (sukces)
                {
                    pole = cyfra;
                }
                else
                {
                    Console.WriteLine(" Podaj liczbe");
                }
                bool istnieje = lista.Exists(x => x == pole); // to moża do ifa od razu włożyć 
                if (!istnieje)
                {
                    flag = 1;
                    Console.WriteLine(" Wybrano liczbe z niepoprawnego zakresu ");
                }
                          
            } while (pole > 9 || pole < 1 || flag == 1); // już w ifie sprawdzasz ten zakres 1- 9 więc nie ma po co sprawdzać, zostawiasz tylko while(flag) najlepiej przerobić na zwykły while a nie do while 
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
            return array1[index];

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
