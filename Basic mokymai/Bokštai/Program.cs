namespace Bokštai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tower of Honoi");
            

            string stulpas1 = "----Stulp1----";
            string stulpas2 = "----Stulp2----";
            string stulpas3 = "----Stulp3----";
            string lekšte1 = "*|*";
            string lekste2 = "**|**";
            string lekste3 = "***|***";
            string lekste4 = "****|****";
            String eile1 = "1eile";
            String eile2 = "2eile";
            String eile3 = "3eile";
            String eile4 = "4eile";
            String eile5 = "5eile";
            string eile6 = "6eile";
            String bruksnis = "        |      ";
            String bruksnis2 = "       |      ";



            //1
            Console.WriteLine("\n1 uzduotis nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.\n"); 
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + "      " + lekšte1 + "    " + bruksnis  + bruksnis);
            Console.WriteLine(eile3 + "     " + lekste2 + "   " + bruksnis + "" + bruksnis);
            Console.WriteLine(eile4 + "    " + lekste3 +"  " + bruksnis + "" + bruksnis);
            Console.WriteLine(eile5 + "   " +lekste4 + " " + bruksnis + bruksnis);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());

            //2
            Console.WriteLine("2 uzduotis Apverskite pirmą stulpelį ir išveskite visą Tower of Hanoi\n");
            Console.WriteLine(eile1 + "   " + lekste4  + " " + bruksnis  + bruksnis);
            Console.WriteLine(eile2 + "    " + lekste3 + "  " + bruksnis + "" + bruksnis);
            Console.WriteLine(eile3 + "     " + lekste2 + "   " + bruksnis + "" + bruksnis);
            Console.WriteLine(eile4 + "      " + lekšte1 + "    " +bruksnis + bruksnis);
            Console.WriteLine(eile5 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());

            //3
            Console.WriteLine("3 uzduotis Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi\n");
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile4 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile5 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());


            //4
            Console.WriteLine("4 uzduotis Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile4 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile5 + "   " + lekste4 + "     " + lekste4 + "      " + lekste4);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());


            //5uzduotis 
            
            Console.WriteLine("5uzduotis Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių,ir išveskite Tower of Hanoi\n");         
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile4 + bruksnis2 + bruksnis2 + "       " + lekšte1);
            Console.WriteLine(eile5 + "   " + lekste4 + "      " + lekste3 + "         " + lekste2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----");
            Console.WriteLine(Console.ReadLine());


            //6
            Console.WriteLine("6. užduotis Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile4 + "      " + lekšte1 + "     " + bruksnis2 + "       " + lekšte1);
            Console.WriteLine(eile5 + "   " + lekste4 + "      " + lekste3 + "         " + lekste2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----");
            Console.WriteLine(Console.ReadLine());


            //7 uzduotis 
            Console.WriteLine("7. užduotis Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + bruksnis2 +"     "+ lekste2 + "     " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + "     " + lekste2 + "     " + bruksnis2);
            Console.WriteLine(eile3 + bruksnis2 + "     " + lekste2 + "     " + bruksnis2);
            Console.WriteLine(eile4 + "      " + lekšte1 + "          " + lekste2 + "           " + lekšte1);
            Console.WriteLine(eile5 + "   " + lekste4 + "       " + lekste2 + "          " + lekste2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----");
            Console.WriteLine(Console.ReadLine());

            //8 uzduotis
            Console.WriteLine("8. užduotis į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + "       " + lekšte1);
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + "      " + lekste2);
            Console.WriteLine(eile4 + bruksnis2 + bruksnis2 + "     " + lekste3);
            Console.WriteLine(eile5 + bruksnis2 + bruksnis2 + "    " + lekste4);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());

            //9 uzduotis
            Console.WriteLine("9.užduotis pakeiskite visų elementų dizainą iš # į , išveskite Tower of Hanoi\n");
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + "       " + lekšte1.Replace("*", "\""));
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + "      " + lekste2.Replace("*", "\""));
            Console.WriteLine(eile4 + bruksnis2 + bruksnis2 + "     " + lekste3.Replace("*", "\""));
            Console.WriteLine(eile5 + bruksnis2 + bruksnis2 + "    " + lekste4.Replace("*", "\""));
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());

            /*
            //10 uzduotis
            Console.WriteLine("paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute\n");
            Console.WriteLine("\nNupieškite 1 stulpelio 1 eilutę, o aš ją atkartosiu");
            Console.WriteLine(Console.ReadLine()[1]);
            Console.WriteLine(eile1 + ReadLine()[1] + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + "       " + lekšte1.Replace("*", "\""));
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + "      " + lekste2.Replace("*", "\""));
            Console.WriteLine(eile4 + bruksnis2 + bruksnis2 + "     " + lekste3.Replace("*", "\""));
            Console.WriteLine(eile5 + bruksnis2 + bruksnis2 + "    " + lekste4.Replace("*", "\""));
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);
            Console.WriteLine("\n----tęsti----\n");
            Console.WriteLine(Console.ReadLine());
            */





        }
    }
}