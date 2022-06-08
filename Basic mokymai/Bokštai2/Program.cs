namespace Bokštai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tower of Honoi");


            //Kintamieji
            string stulpas1 = "----Stulp1----";
            string stulpas2 = "----Stulp2----";
            string stulpas3 = "----Stulp3----";
            String eile1 = "1eile";
            String eile2 = "2eile";
            String eile3 = "3eile";
            String eile4 = "4eile";
            String eile5 = "5eile";
            string eile6 = "6eile";
            string stul1 = "       |    ";
            string stul2 = "         |    ";         
            string lekste1 = "      *|*   ";
            string lekste13 = "        *|*    ";
            string lekste2 = "     **|**  ";
            string lekste23 = "       **|**  ";
            string lekste3 = "    ***|*** ";
            string lekste33 = "      ***|*** ";
            string lekste4 = "   ****|****";
            string lekste43 = "     ****|****";

            //1 užduotis
            Console.WriteLine("\n1 uzduotis nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.\n");
            Console.WriteLine(eile1 + stul1 + stul2 + stul2);
            Console.WriteLine(eile2 + lekste1 + stul2 +stul2);
            Console.WriteLine(eile3 + lekste2 + stul2 + stul2 );
            Console.WriteLine(eile4 +lekste3+stul2+stul2);
            Console.WriteLine(eile5+ lekste4 + stul2 + stul2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());

            //2 užduotis
            Console.WriteLine("2 uzduotis Apverskite pirmą stulpelį ir išveskite visą Tower of Hanoi\n");
            Console.WriteLine(eile1 + lekste4 + stul2 + stul2);
            Console.WriteLine(eile2 + lekste3 + stul2 + stul2);
            Console.WriteLine(eile3 + lekste2 + stul2 + stul2);
            Console.WriteLine(eile4 + lekste1 + stul2 + stul2);
            Console.WriteLine(eile5 + stul1 + stul2 + stul2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());


            //3 užduotis
            Console.WriteLine("3 uzduotis Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi\n");
            Console.WriteLine(eile1 + stul1 + stul2 + stul2);
            Console.WriteLine(eile2 + stul1 + stul2 + stul2);
            Console.WriteLine(eile3 + stul1 + stul2 + stul2);
            Console.WriteLine(eile4 + stul1 + stul2 + stul2);
            Console.WriteLine(eile5 + stul1 + stul2 + stul2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());

            //4 užduotis
            Console.WriteLine("4 uzduotis Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + stul1 + stul2 + stul2);
            Console.WriteLine(eile2 + stul1 + stul2 + stul2);
            Console.WriteLine(eile3 + stul1 + stul2 + stul2);
            Console.WriteLine(eile4 + stul1 + stul2 + stul2);
            Console.WriteLine(eile5 + lekste4 + lekste43 + lekste43);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());

            //5 užduotis
            Console.WriteLine("5uzduotis Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių,ir išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + stul1 + stul2 + stul2);
            Console.WriteLine(eile2 + stul1 + stul2 + stul2);
            Console.WriteLine(eile3 + stul1 + stul2 + stul2);
            Console.WriteLine(eile4 + stul1 + stul2 + lekste13);
            Console.WriteLine(eile5 + lekste4 + lekste33 + lekste23);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----");
            Console.WriteLine(Console.ReadLine());

            //6 užduotis
            Console.WriteLine("6. užduotis Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + stul1 + stul2 + stul2);
            Console.WriteLine(eile2 + stul1 + stul2 + stul2);
            Console.WriteLine(eile3 + stul1 + stul2 + stul2);
            Console.WriteLine(eile4 + lekste1 + stul2 + lekste13);
            Console.WriteLine(eile5 + lekste4 + lekste33 + lekste23);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----");
            Console.WriteLine(Console.ReadLine());

            //7 užduotis
            Console.WriteLine("7. užduotis Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + stul1 + lekste23 + stul2);
            Console.WriteLine(eile2 + stul1 + lekste23 + stul2);
            Console.WriteLine(eile3 + stul1 + lekste23 + stul2);
            Console.WriteLine(eile4 + lekste1 + lekste23 + lekste13);
            Console.WriteLine(eile5 + lekste4 + lekste23 + lekste23);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());

            //8 užduotis
            Console.WriteLine("8. užduotis į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + stul1 + stul2 + stul2);
            Console.WriteLine(eile2 + stul1 + stul2 + lekste13);
            Console.WriteLine(eile3 + stul1 + stul2 + lekste23);
            Console.WriteLine(eile4 + stul1 + stul2 + lekste33);
            Console.WriteLine(eile5 + stul1 + stul2 + lekste43);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());

            //9 užduotis
            Console.WriteLine("9.užduotis pakeiskite visų elementų dizainą iš # į , išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + stul1 + stul2 + stul2);
            Console.WriteLine(eile2 + stul1 + stul2 + lekste13.Replace("*", "\""));
            Console.WriteLine(eile3 + stul1 + stul2 + lekste23.Replace("*", "\""));
            Console.WriteLine(eile4 + stul1 + stul2 + lekste33.Replace("*", "\""));
            Console.WriteLine(eile5 + stul1 + stul2 + lekste43.Replace("*", "\""));
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());

            
            //10 uzduotis užduotis
            Console.WriteLine("paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute\n");
            Console.WriteLine("\nNupieškite 1 stulpelio 1 eilutę, o aš ją atkartosiu\n");
            
            Console.WriteLine(eile1 + Console.ReadLine()[1] + stul1 + stul2 + stul2);
            Console.WriteLine(eile2 + stul1 + stul2 + lekste13.Replace("*", "\""));
            Console.WriteLine(eile3 + stul1 + stul2 + lekste23.Replace("*", "\""));
            Console.WriteLine(eile4 + stul1 + stul2 + lekste33.Replace("*", "\""));
            Console.WriteLine(eile5 + stul1 + stul2 + lekste43.Replace("*", "\""));
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());
            
            

        }
    }
}