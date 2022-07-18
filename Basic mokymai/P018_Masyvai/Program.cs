using System.Text;

namespace P018_Masyvai
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvai");
            /*
            bool reiksme = false;
            Console.WriteLine(reiksme);
            Console.WriteLine(Convert.ToInt32(reiksme)); //gauname 0
            bool reiksme1 = true;
            Console.WriteLine(reiksme1);
            Console.WriteLine(Convert.ToInt32(reiksme1)); //gauname 1

            var isWrong = false; //Flag 

            while (true)
            {
                reiksme = !reiksme; //false true false true
            }*/

            int[] mas = new int[] { 1, 2, 2, 4, 2, 7, 6, 1 };
            Console.WriteLine(PenktaUzduotis(mas)); 

            var saknis = Math.Sqrt(4);
        }

        /*
        1.Parasykite programa, kuri atspausdintu sia figura pvz:
            1 
            01
            101 
            0101 
            10101 */

        private static void PirmaUzduotis()
        {
            Console.Write("Kiek norite eiluciu: ");
            int eilutes = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= eilutes; i++)
                Console.WriteLine(sb.Insert(0, i % 2).ToString());

            
        }

        //skaiciaus tikrinimas
        //private static int SkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius)

        /*
        2. Parasykite programa, kuri paprasytu ivesti skaiciu ir ivesta skaiciu 
        atspausdintu atvirkstine seka.Naudoti tik ciklus ir matematines operacijas.
        Visi kintamieji yra integer tipo. Pvz:            Ivedam- 12345 (int) Rezultatas-54321 (int)*/

        public static void Reverse(int num)
        {
            int reversed = 0;
            while(num > 0)
            {
                reversed = reversed * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine(reversed);
        }
        public static void IsgautiAtvirksciaSkaiciu()
        {
            int skaicius = 0;
            int likutis;
            int rezultatas = 0;

            bool validu = false;
            while (!validu)
            {
                Console.WriteLine("Iveskite skaicius:");
                if (int.TryParse(Console.ReadLine(), out skaicius));
                {
                    validu = true;
                }
            }
            while(skaicius != 0)
            {
                likutis = skaicius % 10;
                Console.WriteLine($"likutis {likutis}");
                rezultatas = rezultatas * 10 + likutis; //
                Console.WriteLine($"Rezultatas {rezultatas}");
                skaicius = skaicius / 10;
                Console.WriteLine($"Skaicius {skaicius}");

            }

            Console.WriteLine($"Rezultatas {rezultatas}");
        }

        /*
        public static void Saknis() //saknie istraukimas be math 
        {
            double root = 1;
            int i = 0;
            while (true)
            {
                i = i + 1;
                root = (sk1 / root + root) / 2;
                if (i == sk1 + 1) { break; }
            }
        }      
        */

        //metodas skaiciaus int validacijai
        static int IntAsk(string specify = "an int number")
        {
            Console.WriteLine($"Please write {specify}: ");
            string? input = Console.ReadLine();
            for (; ; )
            {
                if (Int32.TryParse(input, out _) == false)
                {
                    Console.WriteLine("That is not an int, try again");
                    input = Console.ReadLine();
                }
                else
                {
                    return Convert.ToInt32(input);
                }
            }
        }

        //skaiciaus tikrinimas

        int skaicius = SkaiciausTikrinimas(Console.ReadLine());

        private static int SkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;

     /*   3. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka.Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. Kada visi vardai buna ivesti programa turetu atspausdinti visu vardus atvirkstine seka.
Pvz: 
3
Edvinas
Jonas
Petras----------
Petras
Jonas
Edvinas*/

        public static void TreciasUzdavinys()
        {
            bool validu = false;
            int zmoniuSkaicius = 0;

            while (!validu)
            {
                Console.WriteLine("Iveskite zmoniu skaicius");
                if (int.TryParse(Console.ReadLine(), out zmoniuSkaicius))
                {
                    validu = true;
                }
                string[] vardai = new string[zmoniuSkaicius];
                for (int i = 0; i < zmoniuSkaicius; i++)
                {
                    Console.WriteLine($"Iveskite {i + 1}-j1 varda");
                    string vardas = Console.ReadLine();
                    vardai[i] = vardas;
                }
                Console.WriteLine("------------------");
                for (int i = zmoniuSkaicius -1; i >= 0; i--)
                {
                    Console.WriteLine(vardai[i]);
                }
            }
        }
        /*
        4. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka.
            Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
            Kada visi vardai buna ivesti programa turetu atspausdinti ilgiausia varda ekrane.
            Jei vardai yra vienodo ilgio turetu atspausdinti abu vardus.
            Pvz:            
            3        
            Edvinas 
            Jonas       
            Petras
            ---------------------            
            Edvinas */
        public static void KetvirtasUzdavinys()
        {
            bool arvalidu = false;
            int KiekZmoniuAtejo = 0;

            while (!arvalidu)
            {
                Console.WriteLine("Iveskite zmoniu skaiciu");
                if (int.TryParse(Console.ReadLine(), out KiekZmoniuAtejo))
                {
                    arvalidu = true;
                }
                string[] vardai = new string[KiekZmoniuAtejo];
                for (int i = 0; i < KiekZmoniuAtejo; i++)
                {
                    Console.WriteLine($"Iveskite {i + 1} varda");
                    string vardas = Console.ReadLine();
                    vardai[i] = vardas;
                }
                Console.WriteLine("------------------");
                
                string ilgiausias = vardai.OrderByDescending(i => i.Length).First(); //randam ilgiausią vardą
                Console.WriteLine($"ilgiausias vardas {ilgiausias}");
                
            }
        }

        /*         * 5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane  
         *         * PVZ: 1,2,2,4,2,7,6,1       
         *         * Pasikartojantys skaiciai: 1, 2         */

        public static string PenktaUzduotis(int[] mas)
        {
            
            var sb = new StringBuilder();

            var skaiciai = string.Join(",", mas);
                {
                for (int i = 0; i < mas.Length; i++)
                {
                    var ind = skaiciai.IndexOf(mas[i].ToString());
                    var indLast = skaiciai.LastIndexOf(mas[i].ToString());
                    if (ind != indLast)
                    {
                        sb.Append(mas[i]);
                        sb.Append(",");
                    }
                    skaiciai = skaiciai.Replace(mas[i].ToString(), string.Empty);
                }
            }
            return sb.ToString().TrimEnd(',');

        }


    }
}