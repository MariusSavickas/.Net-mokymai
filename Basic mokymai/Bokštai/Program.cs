namespace Bokštai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tower of Honoi");
            Console.WriteLine("UŽDUOTIS nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius");

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




            //1 uzduotis nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + "      " + lekšte1 + "    " + bruksnis  + bruksnis);
            Console.WriteLine(eile3 + "     " + lekste2 + "   " + bruksnis + "" + bruksnis);
            Console.WriteLine(eile4 + "    " + lekste3 +"  " + bruksnis + "" + bruksnis);
            Console.WriteLine(eile5 + "   " +lekste4 + " " + bruksnis + bruksnis);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);

            //2uzduotis Apverskite pirmą sulpelį ir išveskite visą Tower of Hanoi

            Console.WriteLine("");
            Console.WriteLine(eile1 + "   " + lekste4  + " " + bruksnis  + bruksnis);
            Console.WriteLine(eile2 + "    " + lekste3 + "  " + bruksnis + "" + bruksnis);
            Console.WriteLine(eile3 + "     " + lekste2 + "   " + bruksnis + "" + bruksnis);
            Console.WriteLine(eile4 + "      " + lekšte1 + "    " +bruksnis + bruksnis);
            Console.WriteLine(eile5 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);

            //3uzduotis Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi
            Console.WriteLine("");
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile4 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile5 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);

            //4uzduotis Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi
            Console.WriteLine("");
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile4 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile5 + "   " + lekste4 + "     " + lekste4 + "      " + lekste4);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);

            //5uzduotis Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių,
            //ir išveskite Tower of Hanoi
            Console.WriteLine("");
            Console.WriteLine(eile1 + "   " + lekste4 + "      " + lekste3 + "         " + lekste2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + "       " + lekšte1);
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile4 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile5 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);

            //6uzduotis Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi
            Console.WriteLine("");
            Console.WriteLine(eile1 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile2 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile3 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile4 + "   " + lekste4 + "  " + bruksnis2 + "    " + lekste4);
            Console.WriteLine(eile5 + bruksnis2 + bruksnis2 + " " + bruksnis2);
            Console.WriteLine(eile6 + stulpas1 + stulpas2 + stulpas3);

            //7 uzduotis 





        }
    }
}