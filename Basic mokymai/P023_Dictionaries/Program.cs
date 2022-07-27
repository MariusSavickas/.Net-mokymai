using System.Collections.Generic;

namespace P023_Dictionaries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Dictionaries!");
            DictionariesPavyzdziai();
        }

        public static void DictionariesPavyzdziai()
        {
            //Ždyno/Dictionaries deklaravimas
            Dictionary<string, float> kainuZodynas = new Dictionary<string, float>();
            Dictionary<string, float> kainuZodynas1 = new Dictionary<string, float>(3); //apibreziame kad norime tureti limituota kieki reiksmiu . t.y. 3
            var kainukintamasisZodynas = new Dictionary<string, float>();
            Dictionary <string, int> miestai = new Dictionary<string, int>
            {
                {"Vilnius", 7 },
                {"Kaunas", 6 },
                {"Siauliai",8 },
                {"Jonava", 6 }
            };

            Dictionary<string, string> ZodziuReiksmes = new Dictionary<string, string>()
            {
                { "Macnus", "Stpraus astraus skonio"},
                { "Unaravas", "Pasiputes arba arogantiskas"},
                { "Ceckavot", "Smuilkiai pjaustyti"},
                { "Bimbinetis", "Leisti laika be jokio tikslo"}
            };

            //Zodyno skaitymas
            Console.WriteLine($"{miestai["Vilnius"]},{miestai["Kaunas"]}");
            var miestoPavadinimoIlgis = miestai["Vilnius"];
            Console.WriteLine($"{miestoPavadinimoIlgis}");
            //Dictionary pildymas. KeyValuePair
            miestai.Add("Klaipeda", 8);
            Console.WriteLine($"Klaipeda {miestai["Klaipeda"]}");
            miestai["Silute"] = 6;
            Console.WriteLine($"Silute {miestai["Silute"]}");

            //Zodyno skaitymas
            foreach(var miestas in miestai)
            {
                Console.WriteLine(miestas);
            }

            foreach (KeyValuePair<string, int> miestas in miestai)
            {
                Console.WriteLine(miestas);
            }

            foreach (KeyValuePair<string, int> miestas in miestai)
            {
                Console.WriteLine(miestas.Key);
            }

            foreach (KeyValuePair<string, int> miestas in miestai)
            {
                Console.WriteLine(miestas.Value);
            }

            var varduZodynas = new Dictionary<int, string>()
            {
                {1, "Andrius" },
                {2, "Ieva" },
                {3, "Aiste" },
                {4, "Ieva" },
                {5, "Eugenijus" }
            };
            Console.WriteLine("-------------------------");
            for (int i = 1; i <= varduZodynas.Count; i++) //atspausdinimas per for
            {
                Console.WriteLine(varduZodynas[i]);
            }


            //Zodyno iraso/elemento validavimas
            if (miestai.TryGetValue("Klaipeda", out int miestoSkaicius))
            {
                Console.WriteLine($"Klaipeda {miestoSkaicius}");
            }
            else
            {
                Console.WriteLine("Neradome iraso");
            }
            Console.WriteLine("-------------------------");

            if (miestai.TryGetValue("Klaipedaa", out int miestoSkaicius1))
            {
                Console.WriteLine($"Klaipeda {miestoSkaicius1}");
            }
            else
            {
                Console.WriteLine("Neradome iraso");
            }

            if (!miestai.ContainsKey($"Klaipeda"))
            {
                Console.WriteLine("Neradome miesto");
            }
            else
            {
                Console.WriteLine($"Klaipeda {miestoSkaicius}");
            }


            // Zodyno ValueCollection
            Dictionary<string, int>.ValueCollection miestuReiksmes = miestai.Values;
            
            foreach(int miestoPavadinimoReiksme in miestuReiksmes)
            {
                Console.WriteLine("Reiksme = {0},", miestoPavadinimoReiksme);
            }

            // Zodyno KeyCollection

            Dictionary<string, int>.KeyCollection miestuRaktai = miestai.Keys;

            foreach (string miestoPavadinimoRaktas in miestuRaktai)
            {
                Console.WriteLine("Raktas = {0},", miestoPavadinimoRaktas);
            }

            //Zodyno Iraso isemimas
           
            
            varduZodynas.Remove(2);

            /*
            Console.WriteLine("-------------------------");
            for (int i = 1; i <= varduZodynas.Count; i++) //atspausdinimas per for //Luztu atvaizdavimas per for, nes nelieka 2 reiksmes
            {
                Console.WriteLine(varduZodynas[i]);
            } */

            foreach (var vardas in varduZodynas)
            {
                Console.WriteLine("Vardas = {0},", vardas);
            }
            if (!varduZodynas.ContainsKey(2))
            {
                Console.WriteLine("Neradome vardo");
            }
            else
            {
                Console.WriteLine($"Vardas:  {varduZodynas[2]}");
            }
            Console.WriteLine("-------------------------");
            //zodyno Isvalymas
            var skaiciuZodynas = new Dictionary<int,  int>
            {
                {1, 1},
                {2, 2},
                {3, 3},
                {4, 4},
                {5, 5},
            };

            skaiciuZodynas.Clear();
            
            if (skaiciuZodynas.Count == 0)
            {
                Console.WriteLine("Irasu nerasta");
            }
            else
            {
                Console.WriteLine(skaiciuZodynas.Count);
            }

            //Sudetingesnio zodyno sudarymas 

            Dictionary<string, List<int>> zaidejuTaskuZodynas = new Dictionary<string, List<int>>()
            {
                { "Ieva", new List<int>() { 9, 8, 10 } },
                { "Audrius", new List<int>() { 8, 10, 8, 10, 10 } },
                { "Veronika", new List<int>() { 10, 10, 10 } },
            };

            foreach (var zaidejas in zaidejuTaskuZodynas)
            {
                Console.Write(zaidejas.Key + " ");
                foreach (var taskai in zaidejas.Value)
                {
                    Console.Write(taskai + " ");
                }
                Console.WriteLine();
            }

            AtspausdintiPirmaKlasesDarba();

        }




        /*
        KLASES DARBAS 1. ## Parasykite metoda, kuris priima sveikaji skaiciu kaip parametra ir sukuria nauja zodyna - raktas:x,
            reiksme:x*x formoje. Pvz: Ivestis-5 1:1 2:4 3:9 4:16 5:25*/

        public static void AtspausdintiPirmaKlasesDarba()
        {
            var zodynas = PastatytiSkaiciausKvadratoZodyna(5);
            foreach (var skaicius in zodynas)
            {
                Console.Write($"{skaicius.Key}:{skaicius.Value} ");
            }
        }

        public static Dictionary<int, int> PastatytiSkaiciausKvadratoZodyna(int skaicius)
        {
            var skaiciuZodynas = new Dictionary<int, int>();
            for (int i = 1; i <= skaicius; i++)
            {
                skaiciuZodynas.Add(i, i * i);
            }

            return skaiciuZodynas;
        }





    }
}