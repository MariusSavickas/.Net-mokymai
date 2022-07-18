namespace P018_MasyvaiTeorija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvai");

            int[] pazymiai = new int[10];
            //var pazymiai = new int[10]; //var irgi galime naudoti

            string[] dienos = new string[7] {"Pirmadienis", "Antradienis", "Treciadienis", "Ketvirtadienis", "Penktadienis", "Sestadienis","Sekmadienis"};

            string[] dienos1 = { "Pirmadienis", "Antradienis", "Treciadienis", "Ketvirtadienis", "Penktadienis", "Sestadienis", "Sekmadienis" };

            //deklaravimas
            int[] skaiciai = { 100, 95, 92 };

            //tuscio masyvo deklaravimas
            int[] skaiciai2; // kad galetume reiksmes prisiskirti kitur. Kitaip deklaruotas reiksmes negalesime pakeisti

            //vietos isskyrimas
            int[] skaiciai3 = new int[10];
            string[] zodziai = new string[3];
            double[] realusSkaiciai = new double[3];

            //reiksmiu irasymas
            skaiciai3[0] = 100;
            skaiciai3[1] = 95;
            skaiciai3[2] = 92;
            //skaiciai3[99] = 999; //ismes klaida kad iseiname is masyvo ribu

            //deklaravimas. daugiau budu masyvy reiksmems deklaruoti
            int[] intMasyvas1 = new int[] { 100, 95, 92,165, 87, 55, 48, 50, 40, 35, 10 };
            int[] intMasyvas2 = new[] { 100, 95, 92, 165, 87, 55, 48, 50, 40, 35, 10 };
            int[] intMasyvas3 = new int[1] { 100};
            int[] intMasyvas4 = { 100, 95, 92, 165, 87, 55, 48, 50, 40, 35, 10 };

            //Masyvo reiksmes gauti pagal indeksa
            Console.WriteLine(intMasyvas1[8]);

            //Dvimatis masyvas /Matricos
            int[][] DvimatisMasyvas = new int[4][];
            int[,] dvimatisMasyvas2 = new int[4, 5]; //kitoks budas apsirasyti dvimati masyva
            Console.WriteLine("-----------------------------------");
            //Dvimacio masyvo irasu deklaravimas
            int[,] dvimatisMasyvas3 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 6, 7 } };
            for (int i = 0; i < dvimatisMasyvas3.GetLength(0); i++)
            {
                for (int j = 0; j < dvimatisMasyvas3.GetLength(1); j++)
                {
                    Console.WriteLine(dvimatisMasyvas3[i,j]);

                }

            }
            Console.WriteLine("-----------------------------------");

            for (int i = 0; i < dvimatisMasyvas3.Length; i++)
            {

            }



            string vardas = "Vardenis";
            Console.WriteLine(vardas.Length); //kiek raidziu simboliu yr
            Console.WriteLine( dienos.Length);
            Console.WriteLine(dienos[0]);
            //visu masyvu irasu atspausdinimas
            for (int i = 0; i < dienos1.Length; i++) //Masyve kiek yra kintamuju
            {
                Console.WriteLine(dienos1[i]);
            }

            string testiniszodis = "testinis";
            for (int i = 0; i < testiniszodis.Length; i++)
            {
                Console.WriteLine(testiniszodis[i]);
            }

            



        }
    }
}