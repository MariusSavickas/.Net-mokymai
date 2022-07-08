namespace DNR_uzduotis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, DNR \n");
            string txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT      ";
            //Galimos bazės: Adenine, Thymine, Cytosine, Guanine

            Meniu();

            Console.WriteLine("\n Įveskite savo pasirinkimą");
            string pasirinkimas = Console.ReadLine();
            string pasirinkimas2 = "";
            string pasirinkau = pasirinkimas2;
            string pasirinkimas3 = "";
            string pasirinkau3 = pasirinkimas3;

            Console.WriteLine(Įvestis(pasirinkimas, txt));

            Console.WriteLine("--------");
               
            
            if (PatikrinameValidacija(txt) == "Kodas yra validus")
            {
                if (pasirinkimas == "3")
                {
                    Console.WriteLine("Iveskite savo pasirinkimą");
                    pasirinkimas2 = Console.ReadLine();
                    pasirinkau = pasirinkimas2;
                    Console.WriteLine(Ivestis1(pasirinkau, txt));

                }
                else
                {
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Kodas nevalidus toliau negalime atlikti jokių veiksmų");
            }


            if (pasirinkau == "1")
            {
                Console.WriteLine(SubMeniu2(txt));
                Console.WriteLine("Pateikite savo pasirinkimą");
                pasirinkimas3 = Console.ReadLine();
                pasirinkau3 = pasirinkimas3;
                Console.WriteLine(Ivestis2(pasirinkau3, txt));
            }
                                           
            else
            {
                Console.WriteLine("");
            }





           

            






        }

        

        public static void Meniu() //1 Meniu
        {
            Console.WriteLine(@"
Meniu
1. Atlikti DNR grandinės normalizavimo veiksmus:
2. Atlikti grandinės validaciją
3. Atlieka veiksmus su DNR grandine ");
        }

        public static string Įvestis(string pasirinkimas, string txt) //Įvestis pagrindiniam meniu
        {

            switch (pasirinkimas)
            {
                case "1":
                    return BeTarpuIrDidziosiomisRaidemis(txt);
                case "2":
                    return PatikrinameValidacija(txt);
                case "3":
                    return SubMeniu1(txt);
            }
            return "Blogas pasirinkimas, tokio punkto nėra";
        }  

        public static string SubMeniu1(string txt)  //Sub-Meniu 
        {

            string txt1 = @"Sub-Meniu 
1) normalizuoti grandinę
2) išeiti iš programos";
            return txt1;           
            
        }   

        public static string Ivestis1(string pasirinkau, string txt) //Įvestis Sub-Meniu
        {
            
                              
            switch (pasirinkau)
            {
                case "1":
                    return BeTarpuIrDidziosiomisRaidemis(txt);
                case "2":
                    return "------Press Enter------";             
            }
            return "Blogas pasirinkimas, tokio punkto net nėra";
        }

        public static string SubMeniu2(string txt) //Ekstra sub-meniu
        {
            string txt1 = @"Sub-Meniu 2
1) GCT pakeis į AGG
2) Išvesti ar yra tekste CAT 
3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).
4) Išvesti raidžių kiekį tekste (naudoti string composition)
5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas 
6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą  
(reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
7) Iš grandinės pašalinti pasirinką elementą  
8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros  
(reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
9) Gryžti į ankstesnį meniu";
            return txt1;
        }

        public static string Ivestis2(string pasirinkau3, string txt) //Įvestis Sub-Meniu
        {


            switch (pasirinkau3)
            {
                case "1":
                    return KeičiamGCT(txt);
                case "2":
                    return "------Press Enter------";
            }
            return "Blogas pasirinkimas, tokio punkto net nėra";
        }

        public static string KeičiamGCT(string txt)
        {
            string txt1 = BeTarpuIrDidziosiomisRaidemis(txt);
            return txt1.Replace("GCT", "AGG");
        }

        public static string PatikrinameValidacija(string txt)  //Grandines Validacija
        {
            //string txt1 = BeTarpuIrDidziosiomisRaidemis(txt);
            string txt1 = txt.ToUpper();           
            
            if (txt1.Contains("Z") || txt1.Contains("X") || txt1.Contains("V") || txt1.Contains("B") || txt1.Contains("N") || txt1.Contains("M") || txt1.Contains("S")
                || txt1.Contains("D") || txt1.Contains("F") || txt1.Contains("H") || txt1.Contains("J") || txt1.Contains("K") || txt1.Contains("L") || txt1.Contains("Q")
                || txt1.Contains("W") || txt1.Contains("E") || txt1.Contains("R") || txt1.Contains("Y") || txt1.Contains("U") || txt1.Contains("I") || txt1.Contains("O")
                || txt1.Contains("P"))
            {
                return "Kodas neteisingas";
            }
            else 
            {
                return "Kodas yra validus";
            }
            
            return txt1;
        }
           
        public static string BeTarpuIrDidziosiomisRaidemis(string txt) //Grandines Normalizacija
        {
            
            return txt.Replace("-", "").Replace(" ", "").ToUpper();
        }
        


        #region DNR užduotis
        /*
            Tarkime turime DNR grandinę užkoduotą tekstu var txt =" T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ".
        Galimos bazės: Adenine, Thymine, Cytosine, Guanine
         Parašykite programą kurioje atsiranda MENIU kuriame naudotojas gali pasirinkti:
         1. Atlikti DNR grandinės normalizavimo veiksmus:
            - pašalina tarpus.
            - visas raides keičia didžiosiomis. 
         2. Atlikti grandinės validaciją
            - patikrina ar nėra kitų nei ATCG raidžių
         3. Atlieka veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi). Nuspaudus 3 įeinama į sub-meniu
             - Jeigu grandinė yra validi, tačiau nenormalizuota programa pasiūlo naudotojui 
             1) normalizuoti grandinę
             2) išeiti iš programos
             - jei grandinė normalizuota arba kai buvo atlikta normalizacija
             1) GCT pakeis į AGG
             2) Išvesti ar yra tekste CAT 
             3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).
             4) Išvesti raidžių kiekį tekste (naudoti string composition)
             5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas 
             6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą  
                 (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
             7) Iš grandinės pašalinti pasirinką elementą  
             8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros  
                 (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
             9) Gryžti į ankstesnį meniu
        Visoms operacijoms reikalingi testai.
        */
        #endregion





    }
}

