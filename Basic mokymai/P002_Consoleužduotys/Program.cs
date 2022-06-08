namespace P002_Consoleužduotys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //išvesti savo vardą
            //Console.WriteLine("Marius");

            //Nuskaitykite savo vardą ir įrašykite į kosolę
            //Console.WriteLine(" " + Console.ReadLine());

            //Nuskaityti iš klaviatūros pirmą savo vardo pirmąją raidę ir  išveskite į konsolę jos ASCII kodą
            //Console.WriteLine( " Įvestas ASCII" + (int)Console.ReadKey().KeyChar);

            //Console.WriteLine(Read.Line() + (int)Console.ReadKey().KeyChar);

            //Nuskaitykite iš klaviatūros savo vardo pirmąją raidę, tada nuskaitykite bet kokį skaičių ir išveskite į konsolę sumą. Pabandykite šį skaičių išvesti įvairiais formatais
            //Console.WriteLine("Įveskite savo vardo pirmąją raide ir bet kokį skaičių");
            //Console.WriteLine(" Rezultatas yra: {0}", (int)Console.ReadKey().KeyChar + (int)Console.ReadKey().KeyChar-48);

            //Padarykite konsolės meniu skirtingose eilutėse(1) Pirkti, (2) Parduoti, (3) Likučiai.Išveskite pasirinktą meniu punktą.
            // naudokite konkatinacija
            Console.WriteLine("(1) Pirkti \n(2)Parduoti \n(3) Liukuciai");
            Console.WriteLine(" \'pasirinkimas yra: {0} \'", (int)Console.ReadKey().KeyChar - 48);
            //naudokite kompozicija
            //Naudokite interpoliacija
            //-. Dėstytojo Padarykite konsolės meniu skirtingose eilutėse(1) Pirkti, (2) Parduoti, (3) Likučiai.
            //Išveskite pasirinktą meniu punktą su tekstu "pasirinkimas yra ___" (kabutės irgi būtinos).
            // -.1 Naudokite konkatinaciją
            // -.2 Naudokite kompoziciją
            // -.3 Naudokite interpoliaciją
            Console.WriteLine("(1) Pirkti \n(2) Parduoti \n(3) Likučiai");
            Console.WriteLine($"     \"pasirinkimas yra : {Console.ReadLine()} \" " );

            /*
                        //----------------------------
                        //Parašykite Labas išvesta naujoje eilutėje kiekvieną raidę
                        Console.WriteLine("L");
                        Console.WriteLine("A");
                        Console.WriteLine("B");
                        Console.WriteLine("A");
                        Console.WriteLine("S");

                        Console.WriteLine(@"L
            A
            B
            A
            S");

                        Console.WriteLine("L \nA\nB\nA\nS");
                        //įrašyti nutolusį per vieną TAB
                        Console.WriteLine("L   A  B  A  S");
                        Console.WriteLine("L\tA\tB\tA\tS");

            */
            //Labas kabutese
            //Console.WriteLine("\"LABAS\"");
            //Console.WriteLine("\u0022LABAS\u0022");


            //Parašykite programą kuri nuskaito jūsų vardą ir išveda antrą raidę
            Console.WriteLine("Para6ykite savo vardą o aš atspėsiu antrą raidę");
            Console.WriteLine("   " + Console.ReadLine()[ 1] );

            // Parašykite programą kur nuskaito jūsų vardą ir išveda raidžių kiekį
            Console.WriteLine("Para6ykite savo vardą o aš raidžių kiekį");
            Console.WriteLine("  " + Console.ReadLine().Length );

            //Parašykite programą kuri nuskaito jūsų vardą ir raidžių kiekį. ir išveskite į ekraną tokiu principu
            ////petras
            //6
            //|        petras  |

            // 71 reikia pasižiūrėti Console.WriteLine("   {0}      {1} "  Console.ReadLine(), Console.ReadLine()  );

            Console.WriteLine("\n\n\n {0}" + Console.ReadLine());

            //Nupieškite veiduką
            Console.WriteLine("     ****************");
            Console.WriteLine("   **                **");
            Console.WriteLine("  **    ()      ()     **");
            Console.WriteLine(" **         |           **");
            Console.WriteLine("**     *    |   *         **");
            Console.WriteLine(" **       * |  *          **");
            Console.WriteLine("  **        * *          **");
            Console.WriteLine("   **                 **");
            Console.WriteLine("     *****************".Replace("*", "\""));
        } 

    }
}
