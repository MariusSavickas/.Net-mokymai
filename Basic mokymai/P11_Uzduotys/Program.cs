namespace P11_Uzduotys
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // 5 uzduotis

            Console.WriteLine("Iveskite bet koki teksta");
            string Tekstas = Console.ReadLine();
            Console.WriteLine($"Tekstas yra  {IsvalytiTarpus(Tekstas)}");
            Console.WriteLine("------------------------");

            //6 uzduotis
            Console.WriteLine("Įveskite bet kokį teksta");
            Console.WriteLine($"Žodžių kiekis: {ZodziuKiekis(Console.ReadLine())}");
            Console.WriteLine("------------------------");
            //7 uzduotis
            Console.WriteLine("Iveskite bet koki teksta su tarpais gale");
            Console.WriteLine($"Tarpai gale yra {KiektarpuGale(Console.ReadLine())}");
            Console.WriteLine("------------------------");
            //8 uzduotis
            Console.WriteLine("Iveskite teksta su tarpais priekyje");
            Console.WriteLine($"Tarpai priekyje yra {KiektarpuPriekyje(Console.ReadLine())}");
            Console.WriteLine("------------------------");
            //9 uzduotis
            /* vienas is variantu
            Console.WriteLine("Iveskite teksta su tarpais priekyje ir gale");
            Console.WriteLine($"Tarpai priekyje = {TarpaiPriekyIrGale(Console.ReadLine(), out int Priekyje)}");
            Console.WriteLine($"Tarpai Gale = {TarpaiPriekyIrGale(out int tarpaiGale)}");
            */
            //Pagal destytojo
            // int = Priekyje; Kintamaj igaliu deklaruoti ir cia tada prie metodo jau reiktu tik zodelio out, kadangi kintamasis deklaruotas
            Console.WriteLine("9. Iveskite teksta su tarpais priekyje ir gale");
            
            TarpaiPriekyIrGale(Console.ReadLine(), out int Priekyje, out int tarpaiGale);
            Console.WriteLine($" Priekyje = {Priekyje} Gale = {tarpaiGale}"); 
            
            //9.2 variantas 
            int priekyje = TarpaiPriekyIrGale1(Console.ReadLine(), out int tarpaiGale1);
            Console.WriteLine($" Priekyje = {priekyje} Gale = {tarpaiGale1}");
            Console.WriteLine("------------------------");
            //10 uzduotis

            Console.WriteLine($" a raidziu yra = {KiekYraRaidziuA(Console.ReadLine())}"); //jei bus A did=ioji jos neskaiciuos
            Console.WriteLine("------------------------");

            //11 uzduotis



        }
        /* 11 uzduotis
         *  Parašykite programą kurioje vienas metodas. 
    - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
    - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. N.B. grąžinama string, o ne bool.
    -  Išvesti rezultatą Main metode.
    Pvz: 
    > Iveskite teksta:
    _ ' as labai mokausi programuoti     '
    > Ar yra mokausi: Taip
        */
        public static string ArYraZodisMokausi(string tekstas)
        {
            tekstas = " " + tekstas + " ";
            return tekstas.ToLower().Contains(" mokausi ") ? "Taip" : "Ne";
           // return tekstas.Contains("mokausi", StringComparison.OrdinalIgnoreCase) ? "Taip" : "Ne";  //kitoks būdas

        }

        #region 11A uzduotis
        /*
        Namu darbo užduotis būtuL
UŽDUOTIS 11A(sunkense) + testai

 Parašykite programą kurioje vienas metodas.
    - Naudotojo paprašome įvesti betkokį tekstą Main metode.
    - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. 
        Bet tik tuo atveju jei žodis 'mokausi' nesulipęs su kitu žodžiu.
        N.B.grąžinama string, o ne bool.
    -  Išvesti rezultatą Main metode.

    1. Pvz: 
    > Iveskite teksta:
    _ ' as labai mokausi programuoti     '
    > Ar yra mokausi: Taip

    2. Pvz2: 
    > Iveskite teksta:
    _ 'aslabaimokausiprogramuoti'
    > Ar yra mokausi: Ne

    3. Pvz3: 
    > Iveskite teksta:
    _ 'mokausi programuoti labai    '
    > Ar yra mokausi: Taip

    4. Pvz4: 
    > Iveskite teksta:
    _ 'as mokausi, labai stipriai'
    > Ar yra mokausi: Taip
    5. Pvz5: 
    > Iveskite teksta:
    _ 'as mokausi!'
    > Ar yra mokausi: Taip
    6. Pvz6: 
    > Iveskite teksta:
    _ 'as mokausi?'
    > Ar yra mokausi: Taip
    Pvz7: 
    > Iveskite teksta:
    _ 'as studijuoju (mokausi)'
    > Ar yra mokausi: Taip
    Pvz8: 
    > Iveskite teksta:
    _ 'as studijuojumokausi)'
    > Ar yra mokausi: Ne
        */
        #endregion
       public static string ArYraZodisMokausi1(string tekstas)
        {
            tekstas = " " + tekstas + " ";
            return tekstas.ToLower().Replace(","," ").Replace("!", " ").Replace("?", " ").Replace("(", " ").Replace(")", " ").Contains(" mokausi ") ? "Taip" : "Ne";
            // return tekstas.Contains("mokausi", StringComparison.OrdinalIgnoreCase) ? "Taip" : "Ne";  //kitoks būdas

        }


        /* 10 uzduotis
        Parašykite programą kurioje yra vienas metodas.
    - Main metode Naudotojo paprašome įvesti betkokį tekstą su tarpais
    - Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina 'a' raidžių kiekį tekste.
    - Main metode į ekraną išveskite metodo darbo rezultatą

  Pvz: 
    > Iveskite teksta:

  _ as mokausi programuoti
    > 'a' raidžių kiekis yra: 3*/

        public static int KiekYraRaidziuA(string tekstas)
        {
            
            return tekstas.Length - tekstas.Replace("a", "").Length;
        }
       

        /* 9 uzduotis Parašykite programą kurioje vienas metodas. 
            - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
            - Metodas grąžina dvi reikšmes pirmoji - tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
            <hint> naudoti out 
            - Main į ekraną išveda rezultatą
            Pvz: 
            > Iveskite teksta:
            _ ' as mokausi      '
            > Pradžioje yra tarpų: 1
            > Gale yra tarpų: 6
            */
        public static void TarpaiPriekyIrGale(string? tekstas, out int Priekyje, out int tarpaiGale)
        {
            Priekyje = tekstas.Length - tekstas.TrimStart().Length;
            tarpaiGale = tekstas.Length - tekstas.TrimEnd().Length;
            
        }
        public static int TarpaiPriekyIrGale1(string? tekstas, out int tarpaiGale1)
        {
            
            tarpaiGale1 = tekstas.Length - tekstas.TrimEnd().Length;
            return tekstas.Length - tekstas.TrimStart().Length;

        }

        /* 8 uzduotisParašykite programą kurioje vienas metodas.

           - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
           -Metodas grąžina tarpų kiekį teksto pradžioje
           - Main į ekraną išveda rezultatą
           Pvz:
           > Iveskite teksta:
            _ ' as mokausi      '
            > Pradžioje yra tarpų: 1 */
        public static object KiektarpuPriekyje(string? Tekstas)
{
return Tekstas.Length - Tekstas.TrimStart().Length;
}

        /*   7 uzduotis Parašykite programą kurioje vienas metodas. 
            - Naudotojo paprašome įvesti betkokį tekstą Main metode. 
            - Metodas grąžina tarpų kiekį teksto gale
            - Main į ekraną išveda rezultatą
            Pvz: 
            > Iveskite teksta:
            _ ' as mokausi      '
            > Gale yra tarpų: 6
            */
        public static object KiektarpuGale(string? Tekstas)
{
return Tekstas.Length - Tekstas.TrimEnd().Length;

}
        /*
           * 6. uzduotis Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
   - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
   -Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį
   - Main metode į ekraną išveskite žodžių kiekį
   Pvz:
   > Iveskite teksta:
            _ as mokausi programuoti
            > Zodziu kiekis yra: 3 
           */
        public static int ZodziuKiekis(string? v)
        {
            return v.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /* 5 uzduotis
          Parašykite programą kurioje vienas metodas.
- Naudotojo paprašome įvesti betkokį tekstą Main metode.
-Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
Pvz:
> Iveskite teksta:
          _ ' as mokausi '
          > Teksto ilgis yra: 10
          */
        public static int IsvalytiTarpus(string Tekstas)
{
            //Console.WriteLine($"Tekstas yra {Tekstas.Trim().Length}.");
            return Tekstas.Trim().Length;
}
}
}