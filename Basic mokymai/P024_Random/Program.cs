using System.Text;

namespace P024_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Random");

            //Konstruojam nauja Random
            Random random = new Random();

            int aRandomNumber = random.Next(); //bet koks skaicius nuo 0 iki Int32.MaxValue
            int aRandomNumber1 = random.Next(4); //taip bus sugeneruota 0, 1, 2, arba 3
            int aRandomNumber2 = random.Next(1, 4); //bus sugeneruota 1 , 2 arba 3

            double dRandomNumber = random.NextDouble(); // >=0.0 iki < 1.0

            Console.WriteLine(RandomMetodasDebuginimas()); //neimanoma testuoti
            Console.WriteLine(RandomMetodas(random)); //testuojama

            Random rnd = new Random();
            #region *** Atsitiktinis parinkimas is array ir list
            Console.WriteLine("---------------------------");
            Console.WriteLine("Atsitiktinis parinkimas is array ir list");
            string[] maleNames = { "Nedas", "Justas", "Arunas", "Arnas", "Vakaris", "Vytautas" };
            List<string> femaleNames = new List<string> { "Dainora", "Sonata", "Vida", "Liveta", "Kotryna", "Aldona", "Paule" };

            int aIndex = rnd.Next(maleNames.Length);
            Console.WriteLine("Vyriskas cardas yra " + maleNames[aIndex]);
            int fIndex = rnd.Next(femaleNames.Count);
            Console.WriteLine("Moteriskas vardas yra " + femaleNames[fIndex]);

            #endregion

            #region Atsitiktinis parinkimas is dictionary***
            Console.WriteLine("------------");
            Console.WriteLine("Atsitiktinis parinkimas is dictionary");
            Dictionary<string, int> miestai = new Dictionary<string, int>
            {
                {"Vilnius", 546155 },
                {"Kaunas", 298753 },
                {"Klaipeda", 152008 },
                {"Siauliai", 100653 }
            };
            List<string> miestaiKeys = new List<string>(miestai.Keys);
            int mIndex = rnd.Next(miestaiKeys.Count);
            string miestaiKey = miestaiKeys[mIndex];
            int gyventojuSkaicius = miestai[miestaiKey];
            Console.WriteLine($"mieste {miestaiKey} gyvena {gyventojuSkaicius} gyventojai");

            #endregion

            #region ***Atsitiktinio zodzio parinkimas tekste***
            Console.WriteLine("-------------");
            Console.WriteLine("Atsitiktinio zodzio parinkimas tekste");
            string lorem = "Lorem ipsum dolor sit amet consectetur adipiscing elit sed do elusmod tempor inciddunt ut labore et dolore magna aliqua";
            string[] loremARR = lorem.Split(' ');
            string zodis = loremARR[rnd.Next(loremARR.Length)];
            Console.WriteLine(zodis);

            #endregion

            #region ***Atsitiktinis raidziu generavimas***
            Console.WriteLine("--------------");
            Console.WriteLine("Atsitiktinis raidziu generavimas");
            int raidziuKiekis = 10;
            int A = 65, Z = 90;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < raidziuKiekis; i++)
            {

                sb.Append((char)rnd.Next(A, Z + 1));
            }
            Console.WriteLine(sb.ToString());

            #endregion

            #region ***Atsitiktinis Bool generavimas***
            Console.WriteLine("-------------");
            Console.WriteLine("Atsitiktinis Bool generavimas");
            bool arTrue = rnd.Next(2) == 1;
            Console.WriteLine(arTrue);
            #endregion

            #region ***Atsitiktiniu skaiciu surasymas i array***
            Console.WriteLine("------------------");
            Console.WriteLine("Atsitiktiniu skaiciu surasymas i array");
            int SkaiciuKiekis = 10;
            int min = 0;
            int max = 21;
            int[] skaiciai = new int[SkaiciuKiekis];
            Console.WriteLine(string.Join(" ", skaiciai)); //tuscias mas

            for (int i = 0; i < SkaiciuKiekis; i++)   //cia priskiriame reiksmes
            {
                 skaiciai[i] = rnd.Next(min, max+1);
            }
            Console.WriteLine(string.Join(" ", skaiciai));

            #endregion

            #region ***Atsitiktinis surasymas i list***
            Console.WriteLine("-------------------");
            Console.WriteLine("Atsitiktinis surasymas i list");
            List<int> listas = new List<int>();
            Console.WriteLine(String.Join(",", listas)); //tuscias

            for (int i = 0; i < SkaiciuKiekis; i++)
            {
                listas.Add(rnd.Next(min, max + 1));
            }
            Console.WriteLine(String.Join(",", listas)); //uzpildytas random sk.
            #endregion

            #region ***Atsitiktinis rikiavimas (shuffle)***
            Console.WriteLine("----------------------");
            Console.WriteLine("Atsitiktinis rikiavimas (shuffle)");
            List<string> skaiciai1 = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" };

            skaiciai1.Sort((a, b) => rnd.Next(10) - rnd.Next(10));
            Console.WriteLine(string.Join(",", skaiciai1));
            // skaiciai1.Sort((a, b) => rnd.Next(10) - rnd.Next(10));
            //Console.WriteLine(string.Join(",", skaiciai1));

            #endregion

            #region *** Geresnis random generavimas (System.Security.Cryptography.RandomNumberGenerator) ***

            Console.WriteLine("--------------------------");
            Console.WriteLine("Geresnis random generavimas (System.Security.Cryptography.RandomNumberGenerator)");

            for (int i = 0; i < 20; i++)
            {
                var randNumber = System.Security.Cryptography.RandomNumberGenerator.GetInt32(0, 10);
                Console.Write(" " + randNumber);
                
            }
            
            Console.WriteLine();

            #endregion

            #region ** GUID **
            Console.WriteLine("--------------------------");
            Console.WriteLine("GUID");
            Guid uid = Guid.NewGuid();
            Console.WriteLine(uid);

            updateGuid(uid);
            Console.WriteLine(uid);

            void updateGuid(Guid tmpGuid)
            {
                tmpGuid = Guid.NewGuid();
            }

            var guid1 = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579");
            Console.WriteLine("Guid1: " + guid1);

            bool isGuidParsed = Guid.TryParse("fc072692-d322-448b-9b1b-ba3443943579", out var guid2);
            Console.WriteLine("Guid2: " + guid2);
            #endregion
            #region **** Geresnis Atsitiktinis rikiavimas ****
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Geresnis Atsitiktinis rikiavimas");
            List<string> skaiciai2 = new List<string> { "1", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 " };
            skaiciai2.Sort((a, b) => Guid.NewGuid().CompareTo(Guid.NewGuid()));
            Console.WriteLine(string.Join(", ", skaiciai2));
            #endregion

            #region **** SEED ****
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("SEED");
            Random rnd1 = new Random(10); //vienodos reiksmes (10)
            Random rnd2 = new Random(10);
            for (int i = 0; i < 5; i++)
            {
                Console.Write(rnd1.Next(100) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(rnd2.Next(100) + " ");
            }
            Console.WriteLine();


            #endregion










        }

        static string RandomMetodasDebuginimas()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10) > 5 ? "dideja" : "mazeja";
        }

        static string RandomMetodas(Random rnd)
        {
         
            return rnd.Next(1, 10) > 5 ? "dideja" : "mazeja";
        }



    }
}