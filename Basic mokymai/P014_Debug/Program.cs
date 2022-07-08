using System.Diagnostics;
using System.Globalization;

namespace P014_Debug
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Debug!");
            //Pinigas();
            //DecimalHour(Console.ReadLine());

            Console.WriteLine("Iveskite pirmą skaičių");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antrą skaičių");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Suma yra lygi: {Suma(a, b)}");
            Console.WriteLine($"Atimtis yra lygi: {Atimtis(a, b)}");
            Console.WriteLine($"Daugyba yra lygi: {Daugyba(a, b)}");
            Console.WriteLine($"Dalyba yra lygi: {Dalyba(a, b)}");
            Console.WriteLine($"suma visų metodų {Atimtis(a, b) + Suma(a, b)+ Daugyba(a, b)+ Dalyba(a, b)}");

            //Skaiciuotuvas
            Console.WriteLine("Iveskite pirmą skaičių");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antrą skaičių");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("veiksmo zenkla");
            string zenklas = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Rezultatas yra {Skaiciuotuvas(a1,b1, zenklas)}");

        }
        
        

        /*
        public static void Pinigas()    
        {
            Console.WriteLine("Iveskite pinigų sumą");
            var suma = Console.ReadLine();
            var kursas = 5.6;
            Debug.WriteLine("Labas");   
            // var rezultatas = Convert.ToInt32(suma) * kursas; //reikalinga korekcija del didelio skaiciaus
            // var rezultatas = Convert.ToInt64(suma) * kursas; //reikalinga korekcija del trumpesnio skaiciaus pvz. 20.4
            // var rezultatas = Convert.ToDouble(suma) * kursas; // reikalinga korekcija del trumpesnio skaiciaus suu taskupvz. 20.4
            var decimalSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            var groupSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberGroupSeparator;
            
            var sumaPakeista = suma.Replace(decimalSeparator, groupSeparator);
            var rezultatas = Convert.ToDouble(suma) * kursas;
            Console.WriteLine("Jus turite rankoje {0} pinigų", rezultatas);
            Debug.WriteLine("Jus turite rankoje {0} pinigų", rezultatas);

        }

        public static void DecimalHour(string input)
        {
            var a = input.Split(".");
            if(a.Length < 2)
            {
                Console.WriteLine("Invalid time");
                return;
            }        
            if (int.TryParse(a[0], out int hour) || hour < 0)
            {
                Console.WriteLine("Invalid hours");
                return;
            }
            if (int.TryParse(a[0], out int minute) || minute < 0 || minute > 60)
            {
                Console.WriteLine("Invalid hours");
                return;
            }

            if (a.Length > 2 && (!int.TryParse(a[2], out int sec) || sec < 0 || sec > 60))
            {
                Console.WriteLine("Invalid seconds");
                return;
            }

            var dec = Convert.ToDecimal(a[0]) +
                (Convert.ToDecimal(a[1])/60) +
                (a.Length > 2 ? (Convert.ToDecimal(a[2]) / 3600) : 0);

            Console.WriteLine($"Decimal Hour: {dec:4}");
        } */

        #region Matematika
        /*
        UŽDUOTIS 1
   1. Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
         - Main metode paprašykite įvesti 2 skaičius
         - Kiekvienas matematinis veiksmas turi turėti savo metodą
           metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
         - Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
         - Visų gautų rezultatų sumą atspausdinti Main metode.
         
        2. Skaičiuotuvas.Naudoti pirmos dalies matematinius metodus.
         - Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
         - Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius ir veiksmą. 
         - Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą (naudoti switch)
         - parašyti testus
         - gautą rezultatą atspausdinti į ekraną Main metode.*/
        #endregion

        public static int Skaiciuotuvas(int a1, int b1, string zenklas)
        {
            switch (zenklas) //state maxhine
            {
                case "+":
                    return Suma(a1, b1);

                case "-":
                    return Atimtis(a1, b1);

                case "/":
                    return Dalyba(a1, b1);

                case "*":
                    return Daugyba(a1, b1);

            }
            return 0;
        }


        private static int Dalyba(int a, int b)
        {
            return a / b;
        }

        public static int Daugyba(int a, int b)
        {
            return a * b;
        }

        public static int Atimtis(int a, int b)
        {
            return a - b;
        }

        public static int Suma(int a, int b)
        {
            return a + b;
        }

        #region Daugiakampis
/*Paprašyti naudotojo įvesti taisyklingojo daugiakampio kraštių kiekį (n) ir kraštinės ilgį (b)., 
 metodo parinkimui naudoti switch expression
1. Kai įvestas trikampis, 
- paprašyti įvesti aukšį h
- A=1/2bh
2. Kai įvestas keturkampis,
- A=b*b
3. Kai įvestas penkiakampis, šešiakampis ir t.t.,
- paprašyti įvesti statmenį r
- A=n/2 * b * r
4. išvesti betkokio poligono vidinių kampų sumą
- 180 * (n - 2)
N.B! atkreipkite dėmesį į metodų testuojamumą. 
visi atvejai 1,2,3 ir 4 turi būti atskiruose metoduose ir metodai turi būti testuojami */
#endregion
        /*
public static DaugiakampioPlotas_Main(string[] args)
        {
            Console.WriteLine("Įveskite kraštinių kiekį ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite kraštinės b ilgį ");
            int b = Convert.ToInt32(Console.ReadLine());

            int h = 0;
            int r = 0;
            if (n == 3)
            {
                Console.WriteLine("Iveskite trikampio auksti h");
                h = Convert.ToInt32(Console.ReadLine());
            }          
            else if (n > 4)
            {
                Console.WriteLine("Iveskite statmeni r");
                r = Convert.ToInt32(Console.ReadLine());
            }


            var A = PoligonoPlotas(n, b, h, r);
            var S = VidineKampuSuma(n);
            Console.WriteLine(A);
        }

        public static double VidineKampuSuma(int n) => 180 * (n - 2);
        

        private static double PoligonoPlotas(int n, int b, int h=0, int r=0)
        {
            double A = n switch
            {
                3 => TrikampioPlotas(b, h),
                4 => KeturkampioPlotas(b),
                _ => DaugiakampioPlotas(n, b, r)

            };
            return A;
        }

        private static double DaugiakampioPlotas(int n, int b, int r)
        {          
            return n / 2 * b * r;
        }

        private static double TrikampioPlotas(int b, int h)
        {
           
            return 1d / 2 * b * h;
        }

        private static double KeturkampioPlotas(int b) => b * b;
        */
            
        
    }
}