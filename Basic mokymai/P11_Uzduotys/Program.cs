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

            //7 uzduotis
            Console.WriteLine("Iveskite bet koki teksta su tarpais gale");
            Console.WriteLine($"Tarpai gale yra {KiektarpuGale(Console.ReadLine())}");

            //8 uzduotis
            Console.WriteLine("Iveskite teksta su tarpais priekyje");
            Console.WriteLine($"Tarpai priekyje yra {KiektarpuPriekyje(Console.ReadLine())}");

            //9 uzduotis
            /* vienas is variantu
            Console.WriteLine("Iveskite teksta su tarpais priekyje ir gale");
            Console.WriteLine($"Tarpai priekyje = {TarpaiPriekyIrGale(Console.ReadLine(), out int Priekyje)}");
            Console.WriteLine($"Tarpai Gale = {TarpaiPriekyIrGale(out int tarpaiGale)}");
            */
            //Pagal destytojo
            Console.WriteLine("9. Iveskite teksta su tarpais priekyje ir gale");
            TarpaiPriekyIrGale(Console.ReadLine(), out int Priekyje, out int tarpaiGale);
            Console.WriteLine($" Priekyje = {Priekyje} Gale = {tarpaiGale}");

   
            
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