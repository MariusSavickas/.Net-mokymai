namespace P11_Uzduotys
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /* 5 uzduotis
            Parašykite programą kurioje vienas metodas.
- Naudotojo paprašome įvesti betkokį tekstą Main metode.
-Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
Pvz:
> Iveskite teksta:
            _ ' as mokausi '
            > Teksto ilgis yra: 10
            */
            Console.WriteLine("Iveskite bet koki teksta");
            string Tekstas = Console.ReadLine();
            IsvalytiTarpus(Tekstas);
                Console.WriteLine(Tekstas.Length);
            /*
            * 6. uzduotis Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
    - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
    -Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį
    - Main metode į ekraną išveskite žodžių kiekį
    Pvz:
    > Iveskite teksta:
             _ as mokausi programuoti
             > Zodziu kiekis yra: 3 
            Console.WriteLine("Iveskite bet koki teksta su tarpais");
            string Tekstas1 = Console.ReadLine();
            */

/*   7 uzduotis Parašykite programą kurioje vienas metodas. 
- Naudotojo paprašome įvesti betkokį tekstą Main metode. 
- Metodas grąžina tarpų kiekį teksto gale
- Main į ekraną išveda rezultatą
Pvz: 
> Iveskite teksta:
_ ' as mokausi      '
> Gale yra tarpų: 6
*/
//Console.WriteLine("Iveskite bet koki teksta su tarpais gale");          
// Console.WriteLine($"Tarpai gale yra {KiektarpuGale(Console.ReadLine())}");

/* 8 uzduotisParašykite programą kurioje vienas metodas.

- Naudotojo paprašome įvesti betkokį tekstą Main metode. 
-Metodas grąžina tarpų kiekį teksto pradžioje
- Main į ekraną išveda rezultatą
Pvz:
> Iveskite teksta:
 _ ' as mokausi      '
 > Pradžioje yra tarpų: 1*/
//Console.WriteLine( "Iveskite teksta su tarpais priekyje");
//Console.WriteLine($"Tarpai priekyje yra {KiektarpuPriekyje(Console.ReadLine())}");


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
 //Console.WriteLine( "Iveskite teksta su tarpais priekyje ir gale");
           // var TarpaiPriekyje = TarpaiPriekyjeIrGale(Console.ReadLine(), out int tarpai);
          //  var gale = tarpai;




}

        public static object TarpaiPriekyjeIrGale()
        {
            throw new NotImplementedException();
        }

        public static object KiektarpuPriekyje(string? Tekstas)
{
return Tekstas.Length - Tekstas.TrimStart().Length;
}

public static object KiektarpuGale(string? Tekstas)
{
return Tekstas.Length - Tekstas.TrimEnd().Length;


}

public static void IsvalytiTarpus(string Tekstas)
{
Console.WriteLine($"Tekstas yra {Tekstas.Trim()}.");
}
}
}