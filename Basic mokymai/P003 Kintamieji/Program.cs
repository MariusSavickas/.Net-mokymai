namespace P003_Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Sveiki kintamieji");
            //skaičių kintamieji
            //Sveikų skaičių kintamieji
            byte mazasSkaicius = 2; //iki255
            short trumpasSkaicius = 2; //iki 32767 ir -32767
            int skaicius = 2; //2.147.483.647
            int maksimalusIntSkaitmuo = int.MaxValue;
            int minimalusIntSkaitmuo = int.MinValue;

            Console.WriteLine("maksimalusIntskaitmuo={0}\n minimalusIntskaitmuo = {1}", + maksimalusIntSkaitmuo, minimalusIntSkaitmuo);
            long ilgasskaicius = 2;

            int? skaiciusKurisGaliButiNull = null;
            Nullable<int> skaiciusKurisGaliButi = null;//null

            uint tikTeigiamasSkaicius = 2;//4.294.967.295
            //tikTeigiamasSkaicius = -5; taip negalima

            Console.WriteLine("Floating point types");
            float maziausiasTrupmeninis = 8.5f; //reikia nurodyti raidele f
            var trupmeninisVar = 8.5f;
            double trupmeninis = 8.5;
            decimal didziausiasTrupmeninis = 8.5m;

            Console.WriteLine("PROBLEMOS SU TIKSLUMU"); //Reikia pasikopinti iš dėstytojo 39-50
            double f1 = 0.09 * 100;
            double f2 = 0.09 * 99.999999;


            //patogesni užrašymai
            double avagardosNumber = 6.022e23; //taip u=rasoma 6.022*10^23
            double digitSeparator = 522_1_000_000_001; //The Digital Separator

            


            Console.WriteLine("char kintamieji");
            //char.raide = 'a'; //char kintamasis yra kintamojo tipas , nors atrodo kad talpina raide . Char is similar to an integer or ushort


            Console.WriteLine("datos kintamieji");

            DateTime siandien = DateTime.Now;

            //implicit "type" var, Type inference
            var nulis = 0;
            var automatinisIlgasSkaicius = 99999999999999999;
            var kazkoksTekstas = "kazkoks tekstas";
            //var kazkokiaData = new DateTime(2022,06,08);
            var floatSkaicius = 88f;
            Console.WriteLine(floatSkaicius);

            var s1 = 2_000_000_000;
            var s2 = 2_000_000_001;
            var s3 = s1 + s2; //gaunasi klaida

            Console.WriteLine(s3);
            */

           // PARAŠYTI PROGRAMĄ KURIOJE SAUGOME :
 //MOKYKLOS PAVADINIMĄ
 //KURSO PAVADINIMĄ
 //STUDENTŲ SKAIČIŲ
//ŠIANDIENOS DATĄ
 //VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ

            var Mokyklos_pavadinimas = "Code Academy";
            var Kursopavadinimas = "NET programavimo kursai";
            int StudentuSkaicius = 19;
            DateTime Siandien = DateTime.Now;
            DateTime Kursopradzia = new DateTime(2022,05,30);
            DateTime Kursopabaiga = new DateTime(2022,12,30);
            var KursoTrukme = Siandien - Kursopradzia;

            

            /*
            PAPILDYTI PROGRAMĄ IR PRIDĖTI:
• KURSO PRADŽIOS DATĄ
• KURSO PABAIGOS DATĄ
• Sužinoti skirtumą tarp pradžios ir dabartinės datos(dienomis)
• VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ
            */

            Console.WriteLine(Mokyklos_pavadinimas);
            Console.WriteLine(Kursopavadinimas);
            Console.WriteLine(StudentuSkaicius);
            Console.WriteLine(Siandien);

            Console.WriteLine("---------------------");
            Console.WriteLine($"Kurso pradzia - {Kursopradzia.ToShortDateString()}\n" +
                $"kurso pabaiga - {Kursopabaiga.ToShortDateString()}\n" +
                $"skirtumas - {KursoTrukme.Days}");

            //Sukurkite tris kintamuosius.tekstinio, sveiko skaitmens ir loginio tipo.
            //Parašykite programą kuri į konsolę visus aprašytus kintamuosius vienoje eilutėje atskiriant tarpu



            var skaicius = 2;
            var teisybe = true;
            var vardas = "Marius";

            Console.WriteLine($"{skaicius}   {teisybe}   {vardas}");


        }
    }
}