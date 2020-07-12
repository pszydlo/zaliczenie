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
            List<string> plansza = new List<string>(); // tak jak pisałem w tamtej klasie proponuję żeby klasa odpowiedzialna za planszę zawierała w konstruktorze inicjalizacje planszy i odpowiedznie pola 
            List<int> planszacyfry = new List<int>();// w tym momencie alokujesz dwa razy pamięć (dwa razy na tej samej kolecji masz new)
            int ruchy = 0;

            plansza = Class1.tworzplansze();
            planszacyfry = Class1.tworzplanszecyfry();

            
            string znak = Class1.gracz();
            string znakkomp = Class1.znakkomputera(znak);
            Class1.drukcyfry(planszacyfry);
            
            bool czykoniec ;

            do
            {

                
                int pole = Class1.punkt(planszacyfry);
                plansza[pole - 1] = znak;
                planszacyfry[pole - 1] = 0;
                Class1.druk(plansza);
                if (ruchy < 4)
                {
                    pole = Class1.komputer(plansza);
                    plansza[pole] = znakkomp;
                    planszacyfry[pole] = 0;
                }
                
                ruchy++;
                Class1.druk(plansza);
                Class1.drukcyfry(planszacyfry);
                czykoniec = Class1.pionowo(plansza, znak) && Class1.poziomo(plansza, znak) && Class1.skos(plansza, znak); // tu na pewno && pomiędzy ? a nie lub (||)
            } while (Class1.wynik(plansza) && czykoniec); // czy wynik nie definiuje końca?
        }
    }
}

