namespace P015_Ciklai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, While/Do-while Ciklai!");
            Trecias();


        }

        public static void WhileCikloPavyzdys()
        {
            int skaicius = 1;
            while (skaicius <= 10)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
        } //While ciklo pavyzdys

        public static void WhileCIkloZaidejuPVZ()
        {
            int zaidejuskaicius = -1;
            while (zaidejuskaicius <= 0 || zaidejuskaicius > 10)
            {
                Console.WriteLine("Kiek zaideju zais zaidima?");
                zaidejuskaicius = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void DoWhilePVZ()
        {
            int zaidejuskaicius = 0;
            do
            {
                Console.WriteLine("Kiek zaideju zais zaidima?");
                zaidejuskaicius = Convert.ToInt32(Console.ReadLine());

            } while (zaidejuskaicius <= 0 || zaidejuskaicius > 10);

        } //Do While pavyzdys

        /*
         Paprašyti vartotojo įvesti bet kokį skaičių
        Išvesti skaičių suma nuo 1 iki įvesto skaičiausi */
        public static void PirmoSprendimoApskaiciavimas()
        {
            int suma = 0;
            int skaicius = 0;
            Console.WriteLine("Iveskit skaciu sumai isgauti");
            skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius > 0)
            {
                suma += skaicius;
                skaicius--;
                Console.WriteLine($"Suma  {suma} \n");
            }
            Console.WriteLine("----------------");
            Console.WriteLine($"Suma  {suma}");
        }

        /*         * Paprašyti vartotojo įvesti bet kokį skaičių.         
         *         * Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus,         
         *         * vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6.....         */
        public static void AntroSprendimoApskaiciavimas()
        {
            int skaicius1 = 0;
            int skaicius = 0;
            Console.WriteLine("Iveskit ");
            skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius1 <= skaicius)
            {
                if (skaicius1 % 2 == 0)
                {
                    Console.Write(skaicius1 + ",");

                }
                skaicius1++;
            }

        }

        /*  
         *  * Parasyti programa kuri apskaiciuoja visu ivestu skaiciu suma,         
         *  * kurie buvo ivesti iki ivesto neigiamo skaiciaus                 
         *  * PVZ         * 1,23,4,5,7,8,-1         */

        public static void Trecias()
        {
            int skaicius = 0;
            int suma = 0;
            do
            {
                suma += skaicius;
                Console.WriteLine("Iveskite skaiciu");
                skaicius = Convert.ToInt32(Console.ReadLine());
                
                
            } while (skaicius > -1); Console.WriteLine(suma);

        }
       


        /* 4. Parasykite slaptazodzio ivedimo simuliacija. Pirma kompiuteris paprasys, kad nustatytumete slaptazodi tada prasys naudotojo pakartoti slaptazodi.
         * Bet koks neteisingas ivedimas grazina “Slaptazodis neteisingas. Bandykite dar karta”. 
         * * Kada slaptazodis atspejamas turi buti isvedamas tekstas “Sveikinam! Prisijungete!”.       
         * * BONUS TASKAI: Padarykite taip, kad po 3 neteisingai ivestu slaptazodzio kartu programa ismestu teksta “Jus uzblokuotas” ir iseitu is ciklo.
         * */



        //Herbas ar skaicius
        public static void MathRandomPavyzdys()
        {
            Random randomObjektas = new Random();
            var IsmestaMoneta = randomObjektas.Next(1,2);
            int monetosMetimas = 0;

            while(monetosMetimas < 10)
            {
                monetosMetimas++;
            }
        }







    }
}