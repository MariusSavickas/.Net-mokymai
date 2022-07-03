namespace P10_uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
          // 1užduots 
            sveikivisi();  //1++
            Linkiujumsgerosdienos();  //1++

            Console.WriteLine("------------------");
        //2 užduotis
            Linkiujumsgerosdienos1(); //2++

            Console.WriteLine("------------------");
        //3 užduotis
            Console.WriteLine("Iveskite pirma sk.");
            string SKA1 = Console.ReadLine();
            Console.WriteLine("Iveskite antra sk.");
            string SKA2 = Console.ReadLine();
            
            bool arSkai1 = int.TryParse(SKA1, out int intSKA1);
            bool arSkai2 = int.TryParse(SKA2, out int intSKA2);

            if (arSkai1 && arSkai2)
            {
                Console.WriteLine("Suma yra = " + DuSkaiciai(intSKA1, intSKA2)); 
            }
            else
            {
                Console.WriteLine("Ivesta blogai");
            }

            Console.WriteLine("------------------");

            //4 užduotis ++
            Console.WriteLine("Iveskite bet kokį tekstą su tarpai");
            string Tekstas = Console.ReadLine();
            Console.WriteLine($"Tarpų kiekis yra  {TarpuKiekis(Tekstas)}"); 





        }

       /* 4 užduotis Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
- Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
- Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį
- Main metode į ekraną išveskite tarpų kiekį
Pvz:
> Iveskite teksta:
_ as mokausi programuoti
> Tarpu kiekis yra: 2 */

        public static int TarpuKiekis(string? Tekstas)
        {
            return Tekstas.Length - Tekstas.Replace(" ","").Length  ;
            
        }




        /* 1 Užduotis
       Parašykite programą kurioje yra 2 metodai.
- Pirmas metodas į konsolę išveda "Sveiki visi"
- Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"
       */
        public static void Linkiujumsgerosdienos()
        {
            Console.WriteLine($"Linkiu jums  geros dienos");
        }

        public static void sveikivisi()
        {
            Console.WriteLine("Sveiki visi");
        }
        /* 2 uzduotis 
         Parašykite programą kurioje yra 2 metodai.
 -
 - Pirmas metodas naudotojo paprašo įvesti savo vardą konsolę išveda "Labas tai_kas_ivesta" ir grąžina tai kas ivesta.
 - Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta geros dienos"
 Pvz:
 > Iveskite savo Varda:
 _ Petras
 > Labas Petras
 > Linkiu jums Petras geros dienos
        */
        public static string NuskaitytiIrIsvestiVarda()
        {
            Console.WriteLine("Iveskite savo varda");
            var Vardas = Console.ReadLine();
            Console.WriteLine($"Labas {Vardas}");
            return Vardas;
        }
        public static void Linkiujumsgerosdienos1()
        {
            Console.WriteLine($"Linkiu jums {NuskaitytiIrIsvestiVarda()} geros dienos"); //metodų hierarchija. 
        }

        /* 3 užduotis
         * Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus.
 - Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui.
 N.B.būtina validacija
 - Į ekraną išveskite argumentų matematinę sumą.
 Pvz:
 > Iveskite pirmą skaičių:
 _ 15
 > Iveskite antrą skaičių:
 _ 16
 > Rezultatas: 31

        */

        public static int DuSkaiciai(int a, int b)
        {
            var suma = a + b;
            return suma;
        }

    }
}

