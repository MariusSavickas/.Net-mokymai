namespace DNR_uzduotis
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, DNR \n");
            string txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT      ";
            //Galimos bazės: Adenine, Thymine, Cytosine, Guanine

            Console.WriteLine(@"
Meniu
1. Atlikti DNR grandinės normalizavimo veiksmus:
2. Atlikti grandinės validaciją
3. Atlieka veiksmus su DNR grandine ");

            Console.WriteLine("\n Įveskite savo pasirinkimą");
            string pasirinkimas = Console.ReadLine();

            string pasirinkimas2 = "";
            string pasirinkau = pasirinkimas2;
            string pasirinkimas3 = "";
            string pasirinkau3 = pasirinkimas3;

            string Normalizuota = BeTarpuIrDidziosiomisRaidemis(txt); //Didziosiomis ir be tarpų
            string Segmentas = "";

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

            
            


            if (pasirinkau == "1") //Jei sub-meniu pasirinkome normalizuoti grandinę
            {
                Console.WriteLine(SubMeniu2(txt));
                Console.WriteLine("Pateikite savo pasirinkimą");
                pasirinkimas3 = Console.ReadLine();
                pasirinkau3 = pasirinkimas3;
                Console.WriteLine(Ivestis2(pasirinkau3, txt, Normalizuota));
            }
                                           
            else
            {
                Console.WriteLine("");
            }


            if (pasirinkau3 == "9" ) //Jei grįžtam atgal į pagrindinį meniu
            {
                Console.WriteLine("\n Įveskite savo pasirinkimą");
                pasirinkimas = Console.ReadLine();
                Console.WriteLine(Įvestis(pasirinkimas, txt));
                 if (pasirinkimas == "3")
                {
                    Console.WriteLine("Iveskite savo pasirinkimą");
                    pasirinkimas2 = Console.ReadLine();
                    pasirinkau = pasirinkimas2;
                    Console.WriteLine(Ivestis1(pasirinkau, txt));
                    if (pasirinkau == "1")
                    {
                        Console.WriteLine(SubMeniu2(txt));
                        Console.WriteLine("Pateikite savo pasirinkimą");
                        pasirinkimas3 = Console.ReadLine();
                        pasirinkau3 = pasirinkimas3;
                        Console.WriteLine(Ivestis2(pasirinkau3, txt, Normalizuota));
                    }

                    else
                    {
                        Console.WriteLine("");
                    }

                }
                else
                {
                    Console.WriteLine("");
                }

            }
            else
            {
                Console.WriteLine("");
            }

            

            
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

        public static string Ivestis2(string pasirinkau3, string txt, string Normalizuota) //Įvestis Sub-Meniu
        {


            switch (pasirinkau3)
            {
                case "1":
                    return KeičiamGCT(Normalizuota);
                case "2":
                    return SurastiCAT(Normalizuota);
                case "3":
                    return TreciasIrPenktasSegmentas(Normalizuota);
                case "4":
                    return RaidžiuKiekis(Normalizuota);
                case "5":
                    Console.WriteLine("Iveskit norima segmenta");
                    string Segmentas = "";
                    Segmentas = Console.ReadLine();
                    return IeskomeIvestoSegmento(Normalizuota, Segmentas); //truksta skaiciavimo
                case "6": 
                    return IvedamSegmentaGale(Normalizuota);
                case "7":
                    return PasalinamNorimaElementa(Normalizuota);
                case "8":
                    return PasirenkamIrKeiciamSegmentaIsKlaviaturos(Normalizuota);
                case "9":
                    return PakartokMeniu();
            }
            return "Blogas pasirinkimas, tokio punkto net nėra";
        }

        public static string PasirenkamIrKeiciamSegmentaIsKlaviaturos(string Normalizuota)
        {
            Console.WriteLine("Pasirinkite kelintą segmentą norite pakeisti nuo 1-13");
            string SegmentoNr = Console.ReadLine();
            switch (SegmentoNr)
            {
                case "1":
                    return PirmasSegmentas(Normalizuota);
                    
                case "2":
                    return AntrasSegmentas(Normalizuota);
                case "3":
                    return TreciasSegmentas(Normalizuota);
                case "4":
                    return KetvirtasSegmentas(Normalizuota);
                case "5":
                    return PenktasSegmentas(Normalizuota);
                case "6":
                    return SestasSegmentas(Normalizuota);
                case "7":
                    return SeptintasSegmentas(Normalizuota);
                case "8":
                    return AstuntasSegmentas(Normalizuota);
                case "9":
                    return DevintasSegmentas(Normalizuota);
                case "10":
                    return DesimtasSegmentas(Normalizuota);
                case "11":
                    return VienuoliktasSegmentas(Normalizuota);
                case "12":
                    return DvyliktasSegmentas(Normalizuota);
                case "13":
                    return TryliktasSegmentas(Normalizuota);

            }
            return "Toks segmento nr. neegzistuoja";   
                

        }

        #region 8. Segmento pasirinkimas nuo 1-13 ir pakeitimas kitu

        public static string TryliktasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(36, 3).Insert(36, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string DvyliktasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(33, 3).Insert(33, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string VienuoliktasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(30, 3).Insert(30, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string DesimtasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(27, 3).Insert(27, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string DevintasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(24, 3).Insert(24, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string AstuntasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(21, 3).Insert(21, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string SeptintasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(18, 3).Insert(18, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string SestasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(15, 3).Insert(15, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string PenktasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(12, 3).Insert(12, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string KetvirtasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(9, 3).Insert(9, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string TreciasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(6, 3).Insert(6, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string AntrasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Remove(3, 3).Insert(3, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string PirmasSegmentas(string Normalizuota)
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();

            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota.Substring(3).Insert(0, Segmentas));
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        #endregion

        public static string PakartokMeniu()
        {
            string txt1 = @"
Meniu
1. Atlikti DNR grandinės normalizavimo veiksmus:
2. Atlikti grandinės validaciją
3. Atlieka veiksmus su DNR grandine ";
            return txt1;
        }

        public static string PasalinamNorimaElementa(string Normalizuota) //Šaliname normą elemntą jei toks yra
        {
            Console.WriteLine("Įveskite elemeną, kurį nortie pašalinti");
            string IvedamsElementas = Console.ReadLine();
             

            if (Normalizuota.Contains(IvedamsElementas) == true)
            {
                return Normalizuota.Replace(IvedamsElementas, "");
            }
            else
            {
                return "Elementas nebuvo rastas";
            }
        }

        public static string IvedamSegmentaGale(string Normalizuota) //Segmento pridėjimas gale
        {
            Console.WriteLine("Įveskite trijų raidžių segmentą");
            string IvestasSegmentas = Console.ReadLine();
            string Segmentas = IvestasSegmentas.ToUpper();
            
            if (Segmentas.Length == 3)
            {
                if (Segmentas.Contains("Z") || Segmentas.Contains("X") || Segmentas.Contains("V") || Segmentas.Contains("B") || Segmentas.Contains("N") || Segmentas.Contains("M") || Segmentas.Contains("S")
                || Segmentas.Contains("D") || Segmentas.Contains("F") || Segmentas.Contains("H") || Segmentas.Contains("J") || Segmentas.Contains("K") || Segmentas.Contains("L") || Segmentas.Contains("Q")
                || Segmentas.Contains("W") || Segmentas.Contains("E") || Segmentas.Contains("R") || Segmentas.Contains("Y") || Segmentas.Contains("U") || Segmentas.Contains("I") || Segmentas.Contains("O")
                || Segmentas.Contains("P"))
                {
                    return "Segmentas neteisingas";
                }
                else
                {
                    return (Normalizuota+Segmentas);
                }
            }
            else if (Segmentas.Length == 0)
            {
                return "Segmentas nebuvo įvestas";
            }
            else if (Segmentas.Length < 3)
            {
                return "Segmentas per trumpas";
            }
            else
            {
                return "Segmentas per ilgas";
            }
        }

        public static string IeskomeIvestoSegmento(string Normalizuota, string Segmentas) //reik dar pridėti skaičiavimą kiek kartų
        {
            
            if (Normalizuota.Contains(Segmentas) == true)
            {
                return "Segmentas buvo rastas";
            }
            else
            {
                return "Tokio segmento nėra";
            }
            
                    
        }

        
        public static string RaidžiuKiekis(string Normalizuota) //skaičiuojame raide, išvedame kompozicijos būdų
        {

           var b = Normalizuota;
            var c = string.Format("Raidžių kiekis yra = {0}", b.Length);
            return $"{c}";
        }
        
        public static string TreciasIrPenktasSegmentas(string Normalizuota) //Surandame trečią ir penktą segmentą
        {
            string TreciasSegmentas = Normalizuota.Substring(6).Substring(0, 3);
            string PenktasSegmentas = Normalizuota.Substring(12).Substring(0,3);
            return $"Trečias segmentas = {TreciasSegmentas} \nPenktas segmentas = {PenktasSegmentas}";
        }

        public static string SurastiCAT(string Normalizuota) //CAT radimas grandinėje
        {
            if (Normalizuota.Contains("CAT") == true )
            {
                return "CAT buvo rasta";
            }
            else
            {
                return "CAT nebuvo rasta";
            }
        }

        public static string KeičiamGCT(string Normalizuota) //Keičiam GCT į AGG
        {
            
            return Normalizuota.Replace("GCT", "AGG");
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

