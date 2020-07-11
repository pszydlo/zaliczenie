using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Gra;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> plansza = new List<string>();
            List<int> planszacyfry = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                plansza.Add(" ");
                planszacyfry.Add(i + 1);
            }

            string aktznak = "A";
            string znak = Class1.gracz();
            string znakkomp = Class1.znakkomputera(znak);
            aktznak = znak;
            Class1.drukcyfry(planszacyfry);
            if (aktznak == "X")
            {
                aktznak = "O";
            }
            else
            {
                aktznak = "X";
            }
            bool czykoniec = true;

            do
            {

                Console.WriteLine("Wybierz pole");
                int pole = Class1.punkt();
                plansza[pole - 1] = znak;
                planszacyfry[pole - 1] = 0;
                Class1.druk(plansza);
                pole = Class1.komputer(plansza);
                plansza[pole] = znakkomp;
                planszacyfry[pole] = 0;
                Class1.druk(plansza);
                Class1.drukcyfry(planszacyfry);
                czykoniec = Class1.pionowo(plansza, znak) && Class1.poziomo(plansza, znak) && Class1.skos(plansza, znak);
            } while (Class1.wynik(plansza) && czykoniec);
        }
    }
}

