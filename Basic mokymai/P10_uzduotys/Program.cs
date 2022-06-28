namespace P10_uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Parašykite programą kurioje yra 2 metodai.
- Pirmas metodas į konsolę išveda "Sveiki visi"
- Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"
            */

            sveikivisi();
            Linkiujumsgerosdienos();
            Console.WriteLine("------------------");

            NuskaitytiIrIsvestiVarda();

            Console.WriteLine("Iveskite pirma sk.");
            string SKA1 = Console.ReadLine();
            Console.WriteLine("Iveskite antra sk.");
            string SKA2 = Console.ReadLine();
            
            bool arSkai1 = int.TryParse(SKA1, out int intSKA1);
            bool arSkai2 = int.TryParse(SKA2, out int intSKA2);

            if (arSkai1 && arSkai2)
            {
                Console.WriteLine(DuSkaiciai(intSKA1, intSKA2)); 
            }
            else
            {
                Console.WriteLine("Ivesta blogai");
            }
            
            





        }
        public static void Linkiujumsgerosdienos()
        {
            Console.WriteLine($"Linkiu jums {NuskaitytiIrIsvestiVarda()} geros dienos");
        }

        public static void sveikivisi()
        {
            Console.WriteLine("Sveiki visi");
        }
        /* Parašykite programą kurioje yra 2 metodai.
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

        /* Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus.
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

